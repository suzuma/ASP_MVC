using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PlantillaMVC_EF.Models
{
    public class DataModel:DbContext
    {
        public DbSet<Alumno> Alumnos { get; set;}
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}