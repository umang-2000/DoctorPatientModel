using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Day4WebApplication.Models
{
    public class HospitalContext : DbContext
    {
        public DbSet<Patient> patient { get; set; }
        public DbSet<Doctor> doctor { get; set; }
        public DbSet<Appointment> appointment { get; set; }

        public System.Data.Entity.DbSet<Schedule> Schedules { get; set; }

    }
}