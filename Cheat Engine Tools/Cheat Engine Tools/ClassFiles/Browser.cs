using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Memory
{
    class Browser
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        static public extern bool CloseHandle(IntPtr hHandle);

        [DllImport("kernel32.dll")]
        static public extern bool Module32First(IntPtr hSnapshot, ref MODULEENTRY32 lpme);

        [DllImport("kernel32.dll")]
        static public extern bool Module32Next(IntPtr hSnapshot, ref MODULEENTRY32 lpme);

        [DllImport("kernel32.dll", SetLastError = true)]
        static public extern IntPtr CreateToolhelp32Snapshot(SnapshotFlags dwFlags, uint th32ProcessID);

        public const short INVALID_HANDLE_VALUE = -1;

        [Flags]
        public enum SnapshotFlags : uint
        {
            HeapList = 0x00000001,
            Process = 0x00000002,
            Thread = 0x00000004,
            Module = 0x00000008,
            Module32 = 0x00000010,
            Inherit = 0x80000000,
            All = 0x0000001F
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct MODULEENTRY32
        {
            public uint dwSize;
            public uint th32ModuleID;
            public uint th32ProcessID;
            public uint GlblcntUsage;
            public uint ProccntUsage;
            IntPtr modBaseAddr;
            public uint modBaseSize;
            IntPtr hModule;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string szModule;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szExePath;
        };

        static List<string> EnumProcessModules(uint procIDDDDDDDDDDDDD)
        {
            List<string> modules = new List<string>();
            var snapshot = CreateToolhelp32Snapshot(SnapshotFlags.Module | SnapshotFlags.Module32, procIDDDDDDDDDDDDD);
            MODULEENTRY32 mod = new MODULEENTRY32() { dwSize = (uint)Marshal.SizeOf(typeof(MODULEENTRY32)) };

            if (!Module32First(snapshot, ref mod))
            { return modules; }

            do
            { modules.Add(mod.szModule); }

            while (Module32Next(snapshot, ref mod));
            { return modules; }
        }

        public int Chrome()
        {
            Process[] chrome = Process.GetProcessesByName("chrome");
            foreach (Process subchrome in chrome)
            {
                List<string> modules = EnumProcessModules((uint)subchrome.Id);
                foreach (string submodule in modules)
                {
                    if (submodule.Contains("pepflashplayer"))
                    { return subchrome.Id; }
                }
            }
            return 0;
        }
       
        public int Gameroom_Flash()
        {
            Process[] gameroom_flash = Process.GetProcessesByName("Facebook Gameroom Browser");
            foreach (Process subchrome in gameroom_flash)
            {
                List<string> modules = EnumProcessModules((uint)subchrome.Id);
                foreach (string submodule in modules)
                {
                    if (submodule.Contains("fenix"))
                    { return subchrome.Id; }
                }
            }
            return 0;
        }
    }
}
