﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentWebApiNinject.Utilities.Interface
{
    public interface IDateTimeProvider
    {
        DateTime CurrentUtcTime();
    }
}
