﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT10TryCatch
{
    class WrongPasswordException : Exception
    {
        public WrongPasswordException(string message) : base(message) 
        {
            
        }
        public WrongPasswordException() : base("WrongPasswordException") 
        {
            
        }
    }
}
