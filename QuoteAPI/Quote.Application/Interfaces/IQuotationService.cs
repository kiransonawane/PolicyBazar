using Quote.Application.Dto.Quote;
using Quote.Application.Request.Quote;
using Quote.Application.Response.Quote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quote.Application.Interfaces
{
    public interface IQuotationService
    {
        Task<List<QuoteDto>> GetQuotation(QuoteRequest quotationRequest, CancellationToken cancellationToken);
        Task<int> SaveQuotation(SaveQuoteRequest saveQuotationRequest, CancellationToken cancellationToken);
    }
}
