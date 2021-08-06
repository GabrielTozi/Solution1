using System;
using System.Collections.Generic;
using System.Text;

namespace nsei
{
    class Somando
    {
        public int numero1 { get; set; }
        public int numero2 { get; set; }

        public int Calculo()
        {            
            return this.numero1 + this.numero2;
        }
    }
}
