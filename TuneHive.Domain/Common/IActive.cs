﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuneHive.Domain.Common
{
    public interface IActive
    {
        [DefaultValue(true)]
        bool isActive { get; set; }
    }
}
