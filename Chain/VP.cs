using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaDeResponsabilidad.Chain
{
    public class VP : Handler
    {
        public override void handleRequest(Request request)
        {
            if (request.getRequestType() == RequestType.PURCHASE)
            {
                if (request.getAmount() < 1500)
                {
                    Console.WriteLine("VP aprueba compras menores a $1,500");
                }
                else
                {
                    successor.handleRequest(request);
                }
            }
        }
    }
}
