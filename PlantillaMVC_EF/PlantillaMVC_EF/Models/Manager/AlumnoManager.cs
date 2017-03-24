using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;


namespace PlantillaMVC_EF.Models.Manager
{
    public class AlumnoManager
    {
        public static List<Alumno> ListarContenido() {
            try
            {
                using (var ctx = new DataModel()) {
                    return ctx.Alumnos.Where(r=>r.bStatus==true).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static Alumno getById(int Id)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.Alumnos.Where(r => r.bStatus == true && r.AlumnoId == Id).FirstOrDefault();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}