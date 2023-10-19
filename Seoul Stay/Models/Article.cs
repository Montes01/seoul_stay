using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seoul_Stay.Models
{
    internal class Article
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int ItemTypeId { get; set; }
        public int AreaId { get; set; }
        public string Titulo { get; set; }
        public int Capacidad { get; set; }
        public int NumeroDeCamas { get; set; }
        public int NumeroDeHabitaciones { get; set; }
        public int NumeroDeBaños { get; set; }
        public string DireccionExacta { get; set; }
        public string DireccionAproximada { get; set; }
        public string Descripcion { get; set; }
        public string HostRules { get; set; }
        public int NochesMinimas { get; set; }
        public int NochesMaximas { get; set; }
    }
}
