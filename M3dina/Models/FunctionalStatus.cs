using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace M3dina.Models
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class FunctionalStatus
    {
        public string FunctionalCondition { get; set; }
        public string EffectiveDates { get; set; }
        public string ConditionStatus { get; set; }
    }
}
