using Microsoft.AspNetCore.Http;
using Quote.Application.Interfaces;
using System.Security.Claims;
using ILogger = Quote.Application.Interfaces.ILogger;

namespace Quote.Application.Services
{
    public class ClaimService : IClaimService
    {
        private readonly ILogger _logger;
        public int AgreegatorId { get; }
        public ClaimService(ILogger logger, IHttpContextAccessor httpContextAccessor)
        {
            try
            {
                var claimsIdentity = httpContextAccessor.HttpContext.User.Identity as ClaimsIdentity;
                if (claimsIdentity != null)
                {
                    AgreegatorId = 11; //= Int32.Parse(claimsIdentity.FindFirst("AgreegatorId").Value);
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
                throw;
            }
        }
    }
}
