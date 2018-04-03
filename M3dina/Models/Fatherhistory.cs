using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace M3dina.Models
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class Fatherhistory
    {
        public string _class { get; set; }

        public string Status { get; set; }

        public List<FamilyHistory> history { get; set; }
    }
}
