﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intel8080Emulator
{
    public class Flags 
    {
        byte z; // Zero bit
        byte s; // Sign bit
        byte p; // Parity bit
        byte cy; // Carry bit
        byte ac; // Auxiliary carry bit
        byte pad; // 

        public Flags()
        {
            this.Z = 1;
            this.S = 1;
            this.P = 1;
            this.Cy = 1;
            this.Ac = 1;
            this.Pad = 3;
        }

        public byte Z { get => z; set => z = value; }
        public byte S { get => s; set => s = value; }
        public byte P { get => p; set => p = value; }
        public byte Cy { get => cy; set => cy = value; }
        public byte Ac { get => ac; set => ac = value; }
        public byte Pad { get => pad; set => pad = value; }
    }
}