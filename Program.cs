using CadenaDeResponsabilidad.Chain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaDeResponsabilidad
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Director Pablo = new Director();
            VP Velarde = new VP();
            CEO Ramiro = new CEO();

            Pablo.setSuccessor(Velarde);
            Velarde.setSuccessor(Ramiro);

            Request request = new Request(RequestType.CONFERENCE, 500);
            Pablo.handleRequest(request);

            Request request2 = new Request(RequestType.PURCHASE, 1000);
            Pablo.handleRequest(request2);

            Request request3 = new Request(RequestType.PURCHASE, 1500);
            Pablo.handleRequest(request3);

            Console.ReadKey();
        }
    }
}
