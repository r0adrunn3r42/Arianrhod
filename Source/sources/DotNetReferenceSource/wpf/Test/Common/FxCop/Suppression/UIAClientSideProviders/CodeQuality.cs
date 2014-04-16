using System.Diagnostics.CodeAnalysis;

// Using Avalon's pinvokes
[module: SuppressMessage("Microsoft.Portability", "CA1901:PInvokeDeclarationsShouldBePortable", Scope = "member", Target = "MS.Win32.UnsafeNativeMethods.IntWindowFromPoint(MS.Win32.UnsafeNativeMethods+POINTSTRUCT):System.IntPtr")]

// Code generated by gensr.pl
[module: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Windows.STID.get_Default():System.Windows.STID")]
[module: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Windows.SRID.get_Default():System.Windows.SRID")]
// No way to Marshal an array of SafeHandles to an array of IntPtrs for MsgWaitForMultipleObjects
[module: SuppressMessage("Microsoft.Reliability", "CA2001:AvoidCallingProblematicMethods", Scope = "member", Target = "MS.Internal.AutomationProxies.Misc.MsgWaitForMultipleObjects(Microsoft.Win32.SafeHandles.SafeWaitHandle,System.Boolean,System.Int32,System.Int32):System.Int32", MessageId = "System.Runtime.InteropServices.SafeHandle.DangerousGetHandle")]
[module: SuppressMessage("Microsoft.Reliability", "CA2001:AvoidCallingProblematicMethods", Scope = "member", Target = "MS.Internal.Automation.Misc.TryMsgWaitForMultipleObjects(Microsoft.Win32.SafeHandles.SafeWaitHandle,System.Boolean,System.Int32,System.Int32,System.Int32&):System.Int32", MessageId = "System.Runtime.InteropServices.SafeHandle.DangerousGetHandle")]

// The rule doesn't apply to non-public namespaces
[module: SuppressMessage("Microsoft.MSInternal", "CA904:DeclareTypesInMicrosoftOrSystemNamespace", Scope="namespace", Target="MS.Win32")]
[module: SuppressMessage("Microsoft.Naming", "CA1703:ResourceStringsShouldBeSpelledCorrectly", Scope="resource", Target="StringTable.resources", MessageId="Prt")]
[module: SuppressMessage("Microsoft.Naming", "CA1703:ResourceStringsShouldBeSpelledCorrectly", Scope="resource", Target="StringTable.resources", MessageId="Scn")]
[module: SuppressMessage("Microsoft.Naming", "CA1703:ResourceStringsShouldBeSpelledCorrectly", Scope="resource", Target="StringTable.resources", MessageId="Rq")]
[module: SuppressMessage("Microsoft.Naming", "CA1703:ResourceStringsShouldBeSpelledCorrectly", Scope="resource", Target="StringTable.resources", MessageId="Lk")]
[module: SuppressMessage("Microsoft.Naming", "CA1703:ResourceStringsShouldBeSpelledCorrectly", Scope="resource", Target="StringTable.resources", MessageId="Scr")]
[module: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="MS.Internal.AutomationProxies.WindowsScrollBar.Create(System.IntPtr,System.Int32,System.Int32):System.Windows.Automation.Provider.IRawElementProviderSimple")]
[module: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="MS.Internal.AutomationProxies.WindowsScrollBar.Create(System.IntPtr,System.Int32):System.Windows.Automation.Provider.IRawElementProviderSimple")]
// The rule doesn't apply if the resource isn't owned by this code (these are mainly hwnds)
[module: SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources", Scope="member", Target="MS.Internal.AutomationProxies.Accessible._hwnd")]
[module: SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources", Scope="member", Target="MS.Internal.AutomationProxies.ClickablePoint._hwndDesktop")]
[module: SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources", Scope="member", Target="MS.Internal.AutomationProxies.ProxySimple._hwndDesktop")]
// No threading issue here
[module: SuppressMessage( "Microsoft.Usage", "CA2211:NonConstantFieldsShouldNotBeVisible", Scope = "member", Target = "UIAutomationClientsideProviders.UIAutomationClientSideProviders.ClientSideProviderDescriptionTable" )]
// Spelling is correct for this usage
[module: SuppressMessage( "Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Scope = "namespace", Target = "UIAutomationClientsideProviders" )]
[module: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId="Clientside", Scope="module", Target="uiautomationclientsideproviders.dll")]
//related to usage
[module: SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly", Scope="member", Target="MS.Internal.AutomationProxies.ByteEditBoxOverride.#System.Windows.Automation.Provider.IRangeValueProvider.SetValue(System.Double)")]
[module: SuppressMessage("Microsoft.Usage","CA2208:InstantiateArgumentExceptionsCorrectly", Scope="member", Target="MS.Internal.AutomationProxies.WindowsEditBox.#System.Windows.Automation.Provider.IValueProvider.SetValue(System.String)")]
[module: SuppressMessage("Microsoft.Usage","CA2208:InstantiateArgumentExceptionsCorrectly", Scope="member", Target="MS.Internal.AutomationProxies.WindowsRichEdit.#System.Windows.Automation.Provider.IValueProvider.SetValue(System.String)")]
[module: SuppressMessage("Microsoft.Usage","CA2208:InstantiateArgumentExceptionsCorrectly", Scope="member", Target="MS.Internal.AutomationProxies.WindowsScrollBar.#SetScrollValue(System.Int32)")]
[module: SuppressMessage("Microsoft.Usage","CA2208:InstantiateArgumentExceptionsCorrectly", Scope="member", Target="MS.Internal.AutomationProxies.WindowsSlider.#SetSliderValue(System.Int32)")]
[module: SuppressMessage("Microsoft.Usage","CA2208:InstantiateArgumentExceptionsCorrectly", Scope="member", Target="MS.Internal.AutomationProxies.WindowsListViewScrollBar.#System.Windows.Automation.Provider.IRangeValueProvider.SetValue(System.Double)")]
[module: SuppressMessage("Microsoft.Usage", "CA1816:CallGCSuppressFinalizeCorrectly", Scope="member", Target="MS.Internal.AutomationProxies.ThemePart.#Dispose()")]
[module: SuppressMessage("Microsoft.Usage","CA2208:InstantiateArgumentExceptionsCorrectly", Scope="member", Target="MS.Internal.AutomationProxies.WindowsUpDown.#System.Windows.Automation.Provider.IRangeValueProvider.SetValue(System.Double)")]
[module: SuppressMessage("Microsoft.Usage","CA1806:DoNotIgnoreMethodResults", MessageId="MS.Win32.UnsafeNativeMethods.DwmIsCompositionEnabled(System.Int32@)", Scope="member", Target="MS.Internal.AutomationProxies.WindowsTooltip.#GetTitleBarToolTipText()")]
// This is non-public code
[module: SuppressMessage( "Microsoft.MSInternal", "CA904:DeclareTypesInMicrosoftOrSystemNamespace", Scope = "namespace", Target = "UIAutomationClientsideProviders" )]
[module: SuppressMessage( "Microsoft.Naming", "CA1724:TypeNamesShouldNotMatchNamespaces", Scope = "type", Target = "UIAutomationClientsideProviders.UIAutomationClientSideProviders" )]

//don't need assembly-level critical on this assembly
[module: SuppressMessage("Microsoft.SecurityCritical", "Test002:SecurityCriticalMembersMustExistInCriticalTypesAndAssemblies")]

//Related to ST and SR class:
[module: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Windows.SR.Get(System.String,System.Object[]):System.String")]
[module: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Windows.SR.get_ResourceManager():System.Resources.ResourceManager")]
[module: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Windows.ST.Get(System.String,System.Object[]):System.String")]
[module: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Windows.ST.Get(System.Windows.STID,System.Object[]):System.String")]
[module: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Windows.ST.get_ResourceManager():System.Resources.ResourceManager")]
[module: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Windows.ST.#Get(System.Windows.STID)")]


// This doesn't need Globalization
[module: SuppressMessage("Microsoft.Globalization", "CA1307:SpecifyStringComparison", Scope="member", Target="MS.Internal.AutomationProxies.Misc.#IsProgmanWindow(System.IntPtr)", MessageId="System.String.CompareTo(System.String)")]

// This Marshalling of these types are proper considering the unKnown Target platform which may not be WPF itself as well.
[module: SuppressMessage("Microsoft.Globalization", "CA2101:SpecifyMarshalingForPInvokeStringArguments", Scope="member", Target="MS.Win32.UnsafeNativeMethods.#GetAltTabInfo(System.IntPtr,System.Int32,MS.Win32.UnsafeNativeMethods+ALTTABINFO&,System.Text.StringBuilder,System.UInt32)", MessageId="3")]