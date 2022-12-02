using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace binaryadderwithcarry
{
    public class binaddc
    {
        public int a = 0;
        public int b = 0;
        public int c = 0;
        public int r = 0;

        public binaddc() { }

        public binaddc(int pa, int pb, int pc, int pr)
        {
            a = pa;
            b = pb;
            c = pc;
            r = pr;
        }

        public void addcAB()
        {
          

            if (a == 0 && b == 0) {
                r = 0;
            }
            else if (a == 1 && b == 0)
            {
                r = 1;
            }
            else if (a == 0 && b == 1)
            {
                r = 1;
            }
            else if (a == 1 && b == 1)
            {
                r = 1;
                c = 1;
            }


        }
    }
}
