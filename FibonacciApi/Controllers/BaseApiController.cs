using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts.Models.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FibonacciApi.Controllers
{
    public class BaseApiController : ControllerBase
    {
        public IActionResult Ok<T>(T response)
        {
            var reponse = new ApiSuccessResponse<T>(response);
            return base.Ok(reponse);
        }
    }
}