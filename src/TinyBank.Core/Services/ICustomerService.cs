﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TinyBank.Core.Model;

namespace TinyBank.Core.Services
{
    public interface ICustomerService
    {
        public Customer Register(Options.RegisterCustomerOptions options);
        public bool IsValidVatNumber(string countryCode, string vatNumber);
    }
}
