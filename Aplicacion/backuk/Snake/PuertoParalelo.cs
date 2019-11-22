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
        private int puerto890 = 890;
        private byte D0;
        private byte INIT;
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
            i = PortAccess.Input(puerto890);
            if (i==1)
            {
                INIT = 1;
            }
            else
            {
                INIT = 0;
            }
        }
        public void Output()
        {
            PortAccess.Output(puerto888, D0);
            PortAccess.Output(puerto890, INIT*4);
        }
        public void clock(int dato)
        {
            if (dato==1)
            {
                INIT = 1;
                Console.WriteLine(INIT);
            }
            if (dato == 0)
            {
                INIT = 0;
                Console.WriteLine(INIT);
            }
            Output();
        }
        public void activaINIT()
        {
            INIT = 1;
            Output();
        }
        public void desactivaINIT()
        {
            INIT = 0;
            Output();
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
