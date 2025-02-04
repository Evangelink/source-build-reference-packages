// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// ------------------------------------------------------------------------------
// Changes to this file must follow the http://aka.ms/api-review process.
// ------------------------------------------------------------------------------
[assembly: System.Runtime.CompilerServices.CompilationRelaxations(8)]
[assembly: System.Runtime.CompilerServices.RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: System.Diagnostics.Debuggable(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: System.Security.AllowPartiallyTrustedCallers]
[assembly: System.Runtime.CompilerServices.ReferenceAssembly]
[assembly: System.Reflection.AssemblyTitle("System.Diagnostics.StackTrace")]
[assembly: System.Reflection.AssemblyDescription("System.Diagnostics.StackTrace")]
[assembly: System.Reflection.AssemblyDefaultAlias("System.Diagnostics.StackTrace")]
[assembly: System.Reflection.AssemblyCompany("Microsoft Corporation")]
[assembly: System.Reflection.AssemblyProduct("Microsoft® .NET Framework")]
[assembly: System.Reflection.AssemblyCopyright("© Microsoft Corporation.  All rights reserved.")]
[assembly: System.Reflection.AssemblyFileVersion("1.0.24301.01")]
[assembly: System.Reflection.AssemblyInformationalVersion("1.0.24301.01. Commit Hash: 4ed15a98d1c957ae661d490ccfcfe77f4ed31d5a")]
[assembly: System.CLSCompliant(true)]
[assembly: System.Reflection.AssemblyMetadata(".NETFrameworkAssembly", "")]
[assembly: System.Reflection.AssemblyMetadata("Serviceable", "True")]
[assembly: System.Reflection.AssemblyVersionAttribute("4.0.2.0")]
[assembly: System.Reflection.AssemblyFlagsAttribute((System.Reflection.AssemblyNameFlags)0x70)]
namespace System.Diagnostics
{
    public sealed partial class StackFrame
    {
        public const int OFFSET_UNKNOWN = -1;
        public int GetFileColumnNumber() { throw null; }

        public int GetFileLineNumber() { throw null; }

        public string GetFileName() { throw null; }

        public int GetILOffset() { throw null; }

        public Reflection.MethodBase GetMethod() { throw null; }

        public override string ToString() { throw null; }
    }

    public static partial class StackFrameExtensions
    {
        public static IntPtr GetNativeImageBase(this StackFrame stackFrame) { throw null; }

        public static IntPtr GetNativeIP(this StackFrame stackFrame) { throw null; }

        public static bool HasILOffset(this StackFrame stackFrame) { throw null; }

        public static bool HasMethod(this StackFrame stackFrame) { throw null; }

        public static bool HasNativeImage(this StackFrame stackFrame) { throw null; }

        public static bool HasSource(this StackFrame stackFrame) { throw null; }
    }

    public sealed partial class StackTrace
    {
        public StackTrace(Exception exception, bool needFileInfo) { }

        public StackFrame[] GetFrames() { throw null; }

        public override string ToString() { throw null; }
    }
}