using System;
using Nest;

namespace Ofl.Search.Elasticsearch
{
    public interface IElasticIndexTypeMapper
    {
        Type Type { get; }

        IClrTypeMapping DefineMappingForType(ClrTypeMappingDescriptor mapping);
    }
}
