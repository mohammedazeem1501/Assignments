using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_1
{
    class Access_Mod
    {
        
        public int b = 20;
        protected int c = 30; // this member is used in Program.cs by inheriting it.
        internal int d = 40;
        internal protected int e = 50;
    }
}
