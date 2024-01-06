using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quote.Application.Dto.Quote
{
    public class VehicleDetailAddOnDto
    {
        public bool IsPabDriver { get; set; }
        public bool IsPabPassenger { get; set; }
        public string RtaEvg { get; set; }
        public string Grasp { get; set; }
        public bool IsHireCar { get; set; }
    }
}
