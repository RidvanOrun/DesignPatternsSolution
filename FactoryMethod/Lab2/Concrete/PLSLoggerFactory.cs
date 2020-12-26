﻿using FactoryMethod.Lab2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Lab2.Concrete
{
    public class PLSLoggerFactory:ILoggerFactory
    {
        public ILogger CreateLogger() => new PLSLogger();
    }
}
