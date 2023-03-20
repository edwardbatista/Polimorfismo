using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class GoldenRetriever : Perro
    {
        public override string dormir()
        {
            return "El Golden Retriever duerme.";
        }
        public override string jugar()
        {
            return "El Golden Retriever juega.";
        }
        public override string orinar()
        {
            return "El Golden Retriever orina.";
        }
        public override string defecar()
        {
            return "El Golden Retriever defeca.";
        }
        public override string comer()
        {
            return "El Golden Retriever come.";
        }
    }
}
