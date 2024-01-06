using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quote.Application.Request
{
    public class TokenRequest
    {
        public string UserName { get; set; }
        public string Secrete { get; set; }
    }
}
