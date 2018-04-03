using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace M3dina.Models
{
    public class Patientcontact 
    {
        public string _class { get; set; }

        public string CellPhone { get; set; }

        public string OtherPhone { get; set; }

        public string Email { get; set; }
    }
}
