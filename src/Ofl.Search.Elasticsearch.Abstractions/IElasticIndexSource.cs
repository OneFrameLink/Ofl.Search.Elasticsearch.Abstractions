using System;
using Nest;

namespace Ofl.Search.Elasticsearch
{
    public interface IElasticIndexSource
    {
        Type Type { get; }

        IClrTypeMapping DefineMapping(ClrTypeMappingDescriptor mapping);

        IIndex CreateIndex(IElasticClient elasticClient);
    }
}
