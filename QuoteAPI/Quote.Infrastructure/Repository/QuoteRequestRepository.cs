using Quote.Application.Interfaces;
using Quote.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ILogger = Quote.Application.Interfaces.ILogger;

namespace Quote.Infrastructure.Repository
{
    public class QuoteRequestRepository : IQuoteRequestRepository
    {
        private readonly ILogger _logger;
        private readonly PbContext _pbContext;

        public QuoteRequestRepository(ILogger logger, PbContext pbContext)
        {
            _logger = logger;
            _pbContext = pbContext;
        }

        public async Task<bool> AddAsync(QuoteRequest entity, CancellationToken cancellationToken)
        {
            try
            {
                await _pbContext.QuoteRequests.AddAsync(entity, cancellationToken);
                await _pbContext.SaveChangesAsync(cancellationToken);
                return true;
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
                throw;
            }
        }

        public Task<bool> DeleteAsync(long id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<QuoteRequest>> GetAllAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<QuoteRequest> GetByIdAsync(long id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(QuoteRequest entity, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

    }
}
