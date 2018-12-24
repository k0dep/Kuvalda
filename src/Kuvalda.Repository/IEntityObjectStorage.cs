using System.Threading.Tasks;

namespace Kuvalda.Repository
{
    public interface IEntityObjectStorage<TEntity>
    {
        bool IsExists(string key);
        Task<TEntity> Get(string key);
        Task<string> Store(TEntity entity);
    }
}