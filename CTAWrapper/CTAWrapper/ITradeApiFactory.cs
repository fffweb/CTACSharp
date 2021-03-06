﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTAWrapper
{
    public interface ITradeApiFactory
    {
        ITradeApi CreateTradeApi();
        ITradeCallbackMapping CreateTradeCallbackMapping();
    }
}
