using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaDeResponsabilidad.Chain
{
    public class Director : Handler
    {
        public override void handleRequest(Request request)
        {
            if (request.getRequestType() == RequestType.CONFERENCE)
            {
                Console.WriteLine("Director aprueba Conferencias");
            }
            else
            {
                successor.handleRequest(request);
            }
        }
    }
}
