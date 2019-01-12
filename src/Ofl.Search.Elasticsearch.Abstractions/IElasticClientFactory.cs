using Nest;

namespace Ofl.Search.Elasticsearch
{
    public interface IElasticClientFactory
    {
        IElasticClient CreateClient();
    }
}
