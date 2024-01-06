using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Quote.Api.Models;
using Quote.Api.Validators;
using Quote.Application.Dto;
using Quote.Application.Interfaces;
using Quote.Application.Request.Quote;
using Quote.Application.Response;
using Quote.Application.Response.Quote;
using ILogger = Quote.Application.Interfaces.ILogger;

namespace Quote.Api.Controllers
{
    //[Authorize]
    public class QuoteController : BaseApiController
    {
        private readonly IClaimService _claimInfo;
        private readonly ILogger _logger;
        private readonly IQuotationService _quotationService;
        private readonly IValidator<QuoteRequest> _quoteRequestValidator;
        private readonly IValidator<SaveQuoteRequest> _saveQuoteRequestValidator;
        public QuoteController(IClaimService claimInfo, ILogger logger, IValidator<QuoteRequest> quoteRequestValidator, IQuotationService quotationService, IValidator<SaveQuoteRequest> saveQuoteRequestValidator)
        {
            _claimInfo = claimInfo;
            _logger = logger;
            _quoteRequestValidator = quoteRequestValidator;
            _quotationService = quotationService;
            _saveQuoteRequestValidator = saveQuoteRequestValidator;
        }

        [HttpPost("get-quote")]
        public async Task<IActionResult> GetQuote(QuoteRequest quoteRequest, CancellationToken cancellationToken)
        {
            var quoteRequestValidationResult = _quoteRequestValidator.Validate(quoteRequest);
            if (!quoteRequestValidationResult.IsValid)
            {
                return BadRequest(quoteRequestValidationResult.Errors.Select(error => new
                {
                    Field = error.PropertyName,
                    Message = error.ErrorMessage
                }));
            }
            
            try
            {
                var quotation = await _quotationService.GetQuotation(quoteRequest);
                return Ok(quotation);
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

        [HttpPost("save-quote")]
        public async Task<IActionResult> SaveQuote(SaveQuoteRequest saveQuoteRequest, CancellationToken cancellationToken)
        {
            var saveQuoteRequestValidationResult = _saveQuoteRequestValidator.Validate(saveQuoteRequest);
            if (!saveQuoteRequestValidationResult.IsValid)
            {
                return BadRequest(saveQuoteRequestValidationResult.Errors.Select(error => new
                {
                    Field = error.PropertyName,
                    Message = error.ErrorMessage
                }));
            }

            try
            {
                var quotationNumber = await _quotationService.SaveQuotation(saveQuoteRequest);
                return Ok(quotationNumber);
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
