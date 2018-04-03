using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace M3dina.Models
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class FamilyHistory
    {
        public string Diagnosis { get; set; }
        public string AgeAtOnset { get; set; }
    }
}
