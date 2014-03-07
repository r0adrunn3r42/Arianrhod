//#pragma comment(linker, "/ENTRY:DllMain")
#pragma comment(linker, "/SECTION:.text,ERW /MERGE:.rdata=.text /MERGE:.data=.text")
#pragma comment(linker, "/SECTION:.Asuna,ERW /MERGE:.text=.Asuna")
//#pragma comment(linker, "/EXPORT:LeCreateProcess=_LeCreateProcess@44")

#include "MyLibrary.cpp"
#include "LoaderDll.h"

EXTC
NTSTATUS
NTAPI
LeCreateProcess(
    PLEB                    Leb,
    PCWSTR                  ApplicationName,
    PWSTR                   CommandLine,
    PCWSTR                  CurrentDirectory,
    ULONG                   CreationFlags,
    LPSTARTUPINFOW          StartupInfo,
    PML_PROCESS_INFORMATION ProcessInformation,
    LPSECURITY_ATTRIBUTES   ProcessAttributes,
    LPSECURITY_ATTRIBUTES   ThreadAttributes,
    PVOID                   Environment,
    HANDLE                  Token
)
{
    ULONG_PTR               Length;
    PWSTR                   DllFullPath;
    PLDR_MODULE             Module;
    NTSTATUS                Status;
    ML_PROCESS_INFORMATION  ProcessInfo;

    static WCHAR Dll[] = L"LocaleEmulator.dll";

    Module = FindLdrModuleByHandle(nullptr);

    Length = Module->FullDllName.Length - Module->BaseDllName.Length;
    DllFullPath = (PWSTR)AllocStack(Length + sizeof(Dll));
    CopyMemory(DllFullPath, Module->FullDllName.Buffer, Length);
    CopyStruct(PtrAdd(DllFullPath, Length), Dll, sizeof(Dll));

    Status = CreateProcessWithDll(
                CPWD_BEFORE_KERNEL32,
                DllFullPath,
                ApplicationName,
                CommandLine,
                CurrentDirectory,
                CreationFlags | CREATE_SUSPENDED,
                StartupInfo,
                &ProcessInfo,
                ProcessAttributes,
                ThreadAttributes,
                Environment,
                Token
            );

    if (NT_FAILED(Status))
        return Status;

    PLEPEB LePeb;

    LePeb = nullptr;

    LOOP_ONCE
    {
        if (Leb == nullptr)
            break;

        ULONG_PTR   ExtraSize;
        PVOID       MaximumAddress;
        PREGISTRY_REDIRECTION_ENTRY64 Entry64;

        ExtraSize = Leb->NumberOfRegistryRedirectionEntries * sizeof(Leb->RegistryReplacement[0]);

        if (ExtraSize != 0)
        {
            MaximumAddress = Leb->RegistryReplacement + Leb->NumberOfRegistryRedirectionEntries;
            FOR_EACH(Entry64, Leb->RegistryReplacement, Leb->NumberOfRegistryRedirectionEntries)
            {
                MaximumAddress = ML_MAX(MaximumAddress, PtrAdd(PtrAdd(Entry64->Original.SubKey.Buffer,      Leb),   Entry64->Original.SubKey.MaximumLength));
                MaximumAddress = ML_MAX(MaximumAddress, PtrAdd(PtrAdd(Entry64->Original.ValueName.Buffer,   Leb),   Entry64->Original.ValueName.MaximumLength));
                MaximumAddress = ML_MAX(MaximumAddress, PtrAdd(PtrAdd((PVOID)Entry64->Original.Data,        Leb),   Entry64->Original.DataSize));

                MaximumAddress = ML_MAX(MaximumAddress, PtrAdd(PtrAdd(Entry64->Redirected.SubKey.Buffer,    Leb),   Entry64->Redirected.SubKey.MaximumLength));
                MaximumAddress = ML_MAX(MaximumAddress, PtrAdd(PtrAdd(Entry64->Redirected.ValueName.Buffer, Leb),   Entry64->Redirected.ValueName.MaximumLength));
                MaximumAddress = ML_MAX(MaximumAddress, PtrAdd(PtrAdd((PVOID)Entry64->Redirected.Data,      Leb),   Entry64->Redirected.DataSize));
            }

            ExtraSize += PtrOffset(MaximumAddress, Leb);
        }

        LePeb = OpenOrCreateLePeb(ProcessInfo.dwProcessId, TRUE, ExtraSize);
        if (LePeb == nullptr)
        {
            Status = STATUS_NONE_MAPPED;
            break;
        }

        CopyMemory(&LePeb->Leb, Leb, FIELD_OFFSET(LEB, NumberOfRegistryRedirectionEntries) + ExtraSize);
    }

    CloseLePeb(LePeb);

    if (NT_SUCCESS(Status) && FLAG_OFF(CreationFlags, CREATE_SUSPENDED))
        Status = NtResumeProcess(ProcessInfo.hProcess);

    if (NT_FAILED(Status))
    {
        NtTerminateProcess(ProcessInfo.hProcess, Status);
        NtClose(ProcessInfo.hProcess);
        NtClose(ProcessInfo.hThread);
    }
    else if (ProcessInformation != nullptr)
    {
        *ProcessInformation = ProcessInfo;
    }
    else
    {
        NtClose(ProcessInfo.hProcess);
        NtClose(ProcessInfo.hThread);
    }

    return Status;
}
