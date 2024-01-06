using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Quote.Application.Dto;
using Quote.Application.Interfaces;
using Quote.Application.Request;
using Quote.Application.Request.Quote;
using ILogger = Quote.Application.Interfaces.ILogger;

namespace Quote.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]

    public class AuthController : Controller
    {
        private readonly IAuthService _authService;
        private readonly ILogger _logger;
        private readonly IValidator<TokenRequest> _tokenRequestValidator;
        public AuthController(IAuthService authService, ILogger logger, IValidator<TokenRequest> tokenRequestValidator)
        {
            _authService = authService;
            _logger = logger;
            _tokenRequestValidator = tokenRequestValidator;
        }

        [AllowAnonymous]
        [HttpGet("token")]
        public async Task<IActionResult> Token(TokenRequest tokenRequest, CancellationToken cancellationToken)
        {
            var tokenRequestValidationResult = _tokenRequestValidator.Validate(tokenRequest);

            if (!tokenRequestValidationResult.IsValid)
            {
                return BadRequest(tokenRequestValidationResult.Errors.Select(error => new
                {
                    Field = error.PropertyName,
                    Message = error.ErrorMessage
                }));
            }

            try
            {
                // Validate User if user not found return Unauthorized()
                return Ok(_authService.GenerateJwtToken());
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
                var errorResponse = new ErrorResponseDto
                {
                    Detail = "Error details are logged on the server."
                };
                return StatusCode(500, errorResponse);
            }

        }
    }
}
