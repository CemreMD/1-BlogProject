﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BlogProject.Application.Exceptions
{
    public class MyException : Exception
    {
        public MyException() : base("Sistemde bir hata gerçekleşti")
        {

        }
        public MyException(string message) : base(message)
        {

        }
        public MyException(Exception exception):base (exception.Message)
        {

        }
    }
}
