﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Company.Models
{
    public class Company
    {
          public int CompanyId { get; set; }
          public string CompanyName { get; set; }

          public string Establish { get; set; }

          public string Address { get; set; }

          public string PhotoFileName { get; set; }
    }
}