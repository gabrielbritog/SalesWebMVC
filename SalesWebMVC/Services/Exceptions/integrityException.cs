﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Services.Exceptions
{
    public class integrityException : ApplicationException
    {
        public integrityException(string message) : base(message)
        {

        }
    }
}
