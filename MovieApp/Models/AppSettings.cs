﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Helpers
{
    public class AppSettings
    {
        public string Secret { get; set; }

        public AppSettings()
        {
            Secret = "secretsecretsecretsecretsecretsecret";
        }
    }
}
