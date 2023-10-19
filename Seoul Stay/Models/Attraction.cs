using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seoul_Stay.Models
{
    public class Attraction
    {
        public int id = new Random().Next();
        public string AttractionName { get; set; }
        public int Area { get; set; }
        public double Distance { get; set; }
        public int OnFoot { get; set; }
        public int OnCar { get; set; }
    }
}
