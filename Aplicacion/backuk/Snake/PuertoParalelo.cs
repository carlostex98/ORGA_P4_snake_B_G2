using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class PuertoParalelo
    {
        private int puerto888 = 888;
        private byte D0;
        public PuertoParalelo()
        {
            D0 = 0;
            Output();
            Input();
        }
        private void Input()
        {
            int i = 0;
            i = PortAccess.Input(puerto888);
            if (i==1)
            {
                D0 = 1;
            }
            else
            {
                D0 = 0;
            }
        }
        public void Output()
        {
            PortAccess.Output(puerto888, D0);
            Input();
        }
        public void activaD0()
        {
            D0 = 1;
            Output();
        }
        public void desactivaD0()
        {
            D0 = 0;
            Output();
        }
    }
}
