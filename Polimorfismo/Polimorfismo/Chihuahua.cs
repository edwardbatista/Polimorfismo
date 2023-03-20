using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Chihuahua : Perro
    {
        public override string dormir()
        {
            return "El Chihuahua duerme.";
        }
        public override string jugar()
        {
            return "El Chihuahua juega.";
        }
        public override string orinar()
        {
            return "El Chihuahua orina.";
        }
        public override string defecar()
        {
            return "El Chihuahua defeca.";
        }
        public override string comer()
        {
            return "El Chihuahua come.";
        }
    }
}
