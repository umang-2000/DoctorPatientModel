using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Day4WebApplication.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        [ForeignKey("pat")]
        
        public int PatientID { get; set; }
        public Patient pat { get; set; }

        [ForeignKey("doc")]
        public int DoctorID { get; set; }
        public Doctor doc { get; set; }
        public DateTime Date { get; set; }
        public int appointTime { get; set; }

        
    }

    [ComplexType]
    public class Times
    {
        public int val { get; set; }
        public int txt { get; set; }
    }



}