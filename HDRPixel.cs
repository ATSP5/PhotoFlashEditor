using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEditor
{
     class HDRPixel
    {
        private UInt16 R;
        private UInt16 G;
        private UInt16 B;
        private UInt16 A;

        public HDRPixel()
        {
            R = 0;
            G = 0;
            B = 0;
            A = 0;
        }
        protected UInt16 r_
            {
            get { return R; }
            set { R = value; }
            }
        protected UInt16 g_
        {
            get { return G; }
            set { G = value; }
        }
        protected UInt16 b_
        {
            get { return B; }
            set { B = value; }
        }
        protected UInt16 a_
        {
            get { return A; }
            set { A = value; }
        }
        protected virtual byte To8Bit() { return (byte)0; }
    }
}
