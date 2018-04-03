using System;
using System.Collections.Generic;

namespace M3dina.Models
{
    public class PatientDetails
    {
        public string _class { get; set; }

        public string PatientID { get; set; }

        public Patient Patient { get; set; }

        public Patientcontact PatientContact { get; set; }

        public Patientaddress PatientAddress { get; set; }

        public List<AdvanceDirectives> advancedDirectives { get; set; }

        public List<FunctionalStatus> FunctionalStatus { get; set; }

        public List<problems> problems { get; set; }

        public Fatherhistory fatherHistory { get; set; }

        public Motherhistory motherHistory { get; set; }

        public string currentFacility { get; set; }
    }
}
