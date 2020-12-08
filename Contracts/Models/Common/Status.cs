using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Models.Common
{
    public enum Status
    {
        Success,

        Failure
    }

    public static class ErrorMessage
    {
        public const string Number_Greater_THEN_ZER0 = "Fibonnaci number to get must be greater than 0.";
        public const string Number_Generate_Error = "There was an error while generating fibonnaci number.";
    }
}