﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BlogProject.Application.Utilities.ILogging
{
    public interface ILogging
    {
        void LogInfo(string message);
        void LogWarning(string message);
        void LogError(string message);



    }
}
