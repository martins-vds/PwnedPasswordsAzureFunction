using System.Threading;
using System.Threading.Tasks;

namespace Functions
{
    public interface IStorageService
    {
        Task<BlobStorageEntry?> GetHashesByPrefix(string hashPrefix, CancellationToken cancellationToken = default);
    }
}
