﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Common
{
    public class WebApiConfig
    {
        public string BaseAddress { get; set; }

        public string Token { get; set; }

        public int Timeout { get; set; }
    }
}