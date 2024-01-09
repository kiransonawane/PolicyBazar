namespace Quote.Application.Interfaces
{
    public interface IUnitOfWork
    {
        IQuoteRequestRepository quoteRequests { get; }
    }
}
