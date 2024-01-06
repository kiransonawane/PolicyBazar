using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quote.Application.Dto
{
    public class ErrorResponseDto
    {
        public string Message { get; set; } = "An internal error occurred. Please contact support.";
        public string Detail { get; set; }
    }
}
