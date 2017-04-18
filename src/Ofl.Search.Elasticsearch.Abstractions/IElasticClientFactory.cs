using System;
using System.Threading;
using System.Threading.Tasks;
using Nest;

namespace Ofl.Search.Elasticsearch
{
    public interface IElasticClientFactory
    {
        Task<IElasticClient> CreateClientAsync(Func<ConnectionSettings, ConnectionSettings> connectionSettingsModifier,
            CancellationToken cancellationToken);
    }
}
