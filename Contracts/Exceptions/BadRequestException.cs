using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Exceptions
{
    public class BadRequestException : ApiException
    {
        public BadRequestException(string message)
            : base(message)
        {
            HttpStatusCode = (int)System.Net.HttpStatusCode.BadRequest;
        }
    }
}
