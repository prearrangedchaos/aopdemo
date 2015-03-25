using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOPDemo.Aspects;
using PostSharp.Extensibility;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("AOPDemo")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("AOPDemo")]
[assembly: AssemblyCopyright("Copyright ©  2015")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("54201952-cf95-49ed-9349-1c50ade668fa")]

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

[assembly: AuthenticateAspect(AttributeTargetTypes = "AOPDemo.Logic.*", AttributeTargetMemberAttributes = MulticastAttributes.Public)]

[assembly: RequireLoverCaseParameters(
    AttributeTargetMemberAttributes = MulticastAttributes.Public | MulticastAttributes.Instance,
    AttributeTargetTypes = "AOPDemo.Logic.*")]

