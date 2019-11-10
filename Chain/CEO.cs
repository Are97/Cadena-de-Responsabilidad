using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaDeResponsabilidad.Chain
{
    public class CEO : Handler
    {
        public override void handleRequest(Request request)
        {
            Console.WriteLine("CEO aprueba TODO");
        }
    }
}
