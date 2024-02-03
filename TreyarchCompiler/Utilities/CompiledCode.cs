﻿using System.Collections.Generic;

namespace TreyarchCompiler.Utilities
{
    public class CompiledCode
    {
        public string Error;
        public List<string> Warning;
        public byte[] CompiledScript;
        public Dictionary<uint, byte[]> WriteData;
        public Dictionary<int, byte[]> MaskData;
        public byte[] OpcodeMap;
        public byte[] Dll;
        public bool RequiresGSI;
        public Dictionary<ulong, string> HashMap;
        public List<uint> OpcodeEmissions;

        internal CompiledCode()
        {
            Error = string.Empty;
            Warning = new List<string>();
            CompiledScript = new byte[0];
            WriteData = new Dictionary<uint, byte[]>();
            Dll = new byte[0];
            HashMap = new Dictionary<ulong, string>();
            OpcodeEmissions = new List<uint>();
        }
    }
}