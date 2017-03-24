using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlantillaMVC_EF.Models
{
    [Table(name:"Alumnos")]
    public class Alumno
    {
        [Key]
        public int AlumnoId { get; set; }
        [Required]
        public String sNombre { get; set; }
        [Required]
        public String sApellidos { get; set; }
        [Required]
        public String sGrupo { get; set; }
        public String sImagen { get; set; }
        public Boolean bStatus { get; set; }

        public Alumno() {
            bStatus = true;
        }
    }
}