using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Pastor_Aleman : Perro
    {
        public override string dormir()
        {
            return "El Pastor Aleman duerme.";
        }
        public override string jugar()
        {
            return "El Pastor Aleman juega.";
        }
        public override string orinar()
        {
            return "El Pastor Aleman orina.";
        }
        public override string defecar()
        {
            return "El Pastor Aleman defeca.";
        }
        public override string comer()
        {
            return "El Pastor Aleman come.";
        }
    }
}

