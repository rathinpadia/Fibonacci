using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Models.Common
{
    public class ApiErrorResponse : ApiResponse
    {
        public string Message { get; set; }

        public ApiErrorResponse()
        {
            Status = Status.Failure;
        }

        public ApiErrorResponse(string message)
        {
            Message = message;
            Status = Status.Failure;
        }
    }
}
