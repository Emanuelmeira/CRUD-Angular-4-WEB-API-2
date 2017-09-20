using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domain.Exceptions
{
    public class RepositoryException : Exception
    {
        public RepositoryException() { }
        public RepositoryException(string message) : base(message) { }
        public RepositoryException(string message, Exception inner) : base(message, inner) { }

    }
}