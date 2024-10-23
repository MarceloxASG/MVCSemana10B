using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCSemana10B.Models
{
    public class Alumno
    {
        public int AlumnoID { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
    }
}