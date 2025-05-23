using System;

namespace CarRent_WithInterface.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message) { }
    }
}
