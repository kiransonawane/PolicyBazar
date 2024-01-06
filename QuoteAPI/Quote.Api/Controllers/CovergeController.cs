using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Quote.Api.Models;
using Quote.Application.Dto;
using Quote.Application.Request.Quote;
using Quote.Application.Response.Quote;
using ILogger = Quote.Application.Interfaces.ILogger;

namespace Quote.Api.Controllers
{
    //[Authorize]
    public class CovergeController : BaseApiController
    {
        private readonly ILogger _logger;

        public CovergeController(ILogger logger)
        {
            _logger = logger;
        }

        [HttpGet("coverage-by-product/{productId}")]
        public async Task<IActionResult> GetCoverageByProduct(int productId, CancellationToken cancellationToken)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
                var errorResponse = new ErrorResponseDto
                {
                    Detail = ex.Message
                };
                return StatusCode(500, errorResponse);
            }
        }
    }
}
