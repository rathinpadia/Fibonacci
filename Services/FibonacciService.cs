using Contracts.Exceptions;
using Contracts.Interfaces;
using Contracts.Models.Common;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace Services
{
    public class FibonacciService : IFibonacciService
    {
        private readonly ILogger<FibonacciService> _logger;
        public FibonacciService(ILogger<FibonacciService> logger)
        {
            _logger = logger;
        }
        public int[] GetFibonacciSeries(int num)
        {
          
            try
            {
                _logger.Log(LogLevel.Debug, "GetFibonacciSeries : number received {0}", num);
                if (num <= 0)
                    throw new BadRequestException(ErrorMessage.Number_Greater_THEN_ZER0);

                int[] a = new int[num];

                a[0] = 0;
                a[1] = 1;

                for (int i = 2; i < num; i++)
                {
                    a[i] = a[i - 2] + a[i - 1];
                    _logger.Log(LogLevel.Debug, "Looping to get numbers Generated :  {0}", a[i]);
                }
                _logger.Log(LogLevel.Debug, "GetFibonacciSeries Generated : number  {0}", a);
                return a;
            }
            catch (BadRequestException ex)
            {
                _logger.Log(LogLevel.Error, ErrorMessage.Number_Greater_THEN_ZER0 + "{0}", ex.Message + ex.StackTrace);
                throw ex;
            }
            catch (Exception ex1)
            {
                _logger.Log(LogLevel.Error, ErrorMessage.Number_Greater_THEN_ZER0 + "{0}", ex1.Message + ex1.StackTrace);
                throw new BadRequestException(ErrorMessage.Number_Generate_Error);
            }
           
        }
    }
}
