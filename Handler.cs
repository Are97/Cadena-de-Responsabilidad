using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaDeResponsabilidad
{
    public abstract class Handler
    {
        protected Handler successor;

        public void setSuccessor(Handler _successor)
        {
            successor = _successor;
        }

        public abstract void handleRequest(Request request);
    }
}
