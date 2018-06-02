﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1H.Exceptions
{
    class WrongInputException : Exception
    {
        public WrongInputException(String message, Exception innerException): base(message, innerException) {
            
        }
    }

}
