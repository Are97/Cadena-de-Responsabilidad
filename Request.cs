using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaDeResponsabilidad
{
    public class Request
    {
        private RequestType requestType;
        private double amount;

        public Request(RequestType _requestType, double _amount)
        {
            requestType = _requestType;
            amount = _amount;
        }
        public RequestType getRequestType()
        {
            return requestType;
        }
        public double getAmount()
        {
            return amount;
        }
    }
}
