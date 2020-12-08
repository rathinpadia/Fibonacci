using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FibonacciApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FibonacciController : BaseApiController
    {
        private readonly IFibonacciService _fibonacciService;
        private readonly ILogger<FibonacciController> _logger;
        public FibonacciController(IFibonacciService fibonacciService, ILogger<FibonacciController> logger)
        {
            _fibonacciService = fibonacciService;
            _logger = logger;
        }

        // GET api/Fibonacci/10
        [HttpGet("{num}")]
        public IActionResult GetFibonacci(int num)
        {
            _logger.Log(LogLevel.Debug, "In Get Fibonacci + {0}", num);
            return Ok(_fibonacciService.GetFibonacciSeries(num));
        }
    }
}