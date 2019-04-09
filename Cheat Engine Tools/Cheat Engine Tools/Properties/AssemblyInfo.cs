using System.Resources;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Cheat Engine Tools")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("ScriptKiddys")]
[assembly: AssemblyProduct("Cheat Engine Tools")]
[assembly: AssemblyCopyright("Copyright © ScriptKiddys 2019")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("bab807a8-98e2-4c83-92cf-ee26d1e98251")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: NeutralResourcesLanguage("en")]

//
//  MetroFrameWork Info
//

internal static class MetroFrameworkDesignAssembly
{
    internal const string Title = "MetroFramework.Design.dll";
}

internal static class MetroFrameworkDesignAssemblyFonts
{
    internal const string Title = "MetroFramework.Fonts.dll";
}

internal static class MetroFrameworkAssembly
{
    internal const string Title = "MetroFramework.dll";
}

namespace MetroFramework
{
    internal static class AssemblyRef
    {
        internal const string MetroFrameworkDesignSN = "MetroFramework.Design";
        internal const string MetroFrameworkFontsSN = "MetroFramework.Fonts";
        internal const string MetroFrameworkFontResolver = "MetroFramework.Fonts.FontResolver";
    }
}
