using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Interfaces
{
    public interface IFibonacciService
    {
        int[] GetFibonacciSeries(int num);
    }
}
