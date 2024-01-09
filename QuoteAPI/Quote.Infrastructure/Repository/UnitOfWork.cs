using Quote.Application.Interfaces;

namespace Quote.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public IQuoteRequestRepository quoteRequests { get; set; }

        public UnitOfWork(IQuoteRequestRepository quoteRequestRepository)
        {
            quoteRequests = quoteRequestRepository;
        }

    }
}
