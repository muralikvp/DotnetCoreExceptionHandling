using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExcepDomain.Exception
{
    public abstract class DomainException :System.Exception
    {
        public DomainException(string message):base(message)
        {

        }
    }
    public class DomaiNotFoundException : DomainException
    {
        public DomaiNotFoundException(string message): base(message)
        {
            
        }
    }
     public class ValidationException : DomainException
    {
        public ValidationException(string message): base(message)
        {
            
        }
    }
}