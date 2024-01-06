using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quote.Application.Dto.Quote
{
    public class VehicleDetailQuoteDto
    {
        public int QuoteNumber { get; set; }
        public decimal SumInsured { get; set; }
        public bool IsExcesssDeductible { get; set; }
        public bool IsNewDrivingLicense { get; set; }
        public bool IsUnderageDriver { get; set; }
        public bool IsReventDLHolder { get; set; }
        public decimal Premium { get; set; }
        public decimal VAT { get; set; }
        public decimal Total { get; set; }
    }
}
