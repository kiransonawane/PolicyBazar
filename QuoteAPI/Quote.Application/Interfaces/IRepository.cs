namespace Quote.Application.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<IReadOnlyList<T>> GetAllAsync(CancellationToken cancellationToken);
        Task<T> GetByIdAsync(long id, CancellationToken cancellationToken);
        Task<bool> AddAsync(T entity, CancellationToken cancellationToken);
        Task<bool> UpdateAsync(T entity, CancellationToken cancellationToken);
        Task<bool> DeleteAsync(long id, CancellationToken cancellationToken);
    }
}
