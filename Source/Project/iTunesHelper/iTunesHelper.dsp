# Microsoft Developer Studio Project File - Name="iTunesHelper" - Package Owner=<4>
# Microsoft Developer Studio Generated Build File, Format Version 6.00
# ** DO NOT EDIT **

# TARGTYPE "Win32 (x86) Dynamic-Link Library" 0x0102

CFG=iTunesHelper - Win32 Release
!MESSAGE This is not a valid makefile. To build this project using NMAKE,
!MESSAGE use the Export Makefile command and run
!MESSAGE 
!MESSAGE NMAKE /f "iTunesHelper.mak".
!MESSAGE 
!MESSAGE You can specify a configuration when running NMAKE
!MESSAGE by defining the macro CFG on the command line. For example:
!MESSAGE 
!MESSAGE NMAKE /f "iTunesHelper.mak" CFG="iTunesHelper - Win32 Release"
!MESSAGE 
!MESSAGE Possible choices for configuration are:
!MESSAGE 
!MESSAGE "iTunesHelper - Win32 Release" (based on "Win32 (x86) Dynamic-Link Library")
!MESSAGE 

# Begin Project
# PROP AllowPerConfigDependencies 0
# PROP Scc_ProjName ""
# PROP Scc_LocalPath ""
CPP=cl.exe
MTL=midl.exe
RSC=rc.exe
# PROP BASE Use_MFC 0
# PROP BASE Use_Debug_Libraries 0
# PROP BASE Output_Dir "Release"
# PROP BASE Intermediate_Dir "Release"
# PROP BASE Target_Dir ""
# PROP Use_MFC 0
# PROP Use_Debug_Libraries 0
# PROP Output_Dir "Release"
# PROP Intermediate_Dir "Release"
# PROP Ignore_Export_Lib 0
# PROP Target_Dir ""
# ADD BASE CPP /nologo /W3 /GX /O2 /D "WIN32" /D "NDEBUG" /D "_MBCS" /YX /FD /c
# ADD CPP /nologo /Gr /MD /W4 /GR- /O2 /Ob1 /I "D:\Desktop\Python3\include" /D "WIN32" /D "NDEBUG" /FD /GL /arch:SSE /MP /GS- /c
# ADD BASE RSC /l 0x409 /d "NDEBUG"
# ADD RSC /l 0x409 /d "NDEBUG"
BSC32=bscmake.exe
# ADD BASE BSC32 /nologo
# ADD BSC32 /nologo
LINK32=link.exe
# ADD BASE LINK32 kernel32.lib user32.lib gdi32.lib winspool.lib comdlg32.lib advapi32.lib shell32.lib ole32.lib oleaut32.lib uuid.lib odbc32.lib odbccp32.lib kernel32.lib user32.lib gdi32.lib winspool.lib comdlg32.lib advapi32.lib shell32.lib ole32.lib oleaut32.lib uuid.lib odbc32.lib odbccp32.lib /nologo /dll /machine:I386
# ADD LINK32 mylib.lib undoc_ntdll.lib ntdll.lib kernel32.lib user32.lib gdi32.lib winspool.lib comdlg32.lib advapi32.lib shell32.lib ole32.lib oleaut32.lib uuid.lib odbc32.lib odbccp32.lib kernel32.lib user32.lib gdi32.lib winspool.lib comdlg32.lib advapi32.lib shell32.lib ole32.lib oleaut32.lib uuid.lib odbc32.lib odbccp32.lib /nologo /dll /pdb:"iTunesHelper.pdb" /debug /machine:I386 /out:"iTunesHelper.dll" /libpath:"D:\Desktop\Python3\libs" /LTCG /OPT:REF
# SUBTRACT LINK32 /pdb:none
# Begin Target

# Name "iTunesHelper - Win32 Release"
# Begin Source File

SOURCE=.\Interface.cpp
# End Source File
# Begin Source File

SOURCE=.\iOS.cpp
# End Source File
# Begin Source File

SOURCE=.\iOS.h
# End Source File
# Begin Source File

SOURCE=.\iOSAFC.h
# End Source File
# Begin Source File

SOURCE=.\iOSATH.cpp
# End Source File
# Begin Source File

SOURCE=.\iOSATH.h
# End Source File
# Begin Source File

SOURCE=.\iOSDevice.cpp
# End Source File
# Begin Source File

SOURCE=.\iOSDevice.h
# End Source File
# Begin Source File

SOURCE=.\iOSDeviceMonitor.h
# End Source File
# Begin Source File

SOURCE=.\iOSService.h
# End Source File
# Begin Source File

SOURCE=.\iTunesHelper.cpp
# End Source File
# Begin Source File

SOURCE=.\iTunesHelper.h
# End Source File
# Begin Source File

SOURCE=.\main.cpp
# End Source File
# End Target
# End Project
