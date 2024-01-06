using Quote.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quote.Application.Interfaces
{
    public interface IAuthService
    {
        TokenResponseDto GenerateJwtToken();
    }
}
