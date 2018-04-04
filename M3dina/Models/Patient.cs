using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace M3dina.Models
{
    public class Patient
    {
       
        public string _class { get; set; }

        public string GivenName { get; set; }

        public string FamilyName { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime BirthDate { get; set; }

        public string Gender { get; set; }

    }
}
