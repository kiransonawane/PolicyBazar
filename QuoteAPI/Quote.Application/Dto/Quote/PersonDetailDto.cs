using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quote.Application.Dto.Quote
{
    public class PersonDetailDto
    {
        public string InsuredName { get; set; }
        public string CustomerEmail { get; set; }
        public string QuotationDate { get; set; }
        public string PhoneNo { get; set; }
        public int Nationality { get; set; }
        public string InsuredDob { get; set; }
        public string BusinessCode { get; set; }
    }
}
