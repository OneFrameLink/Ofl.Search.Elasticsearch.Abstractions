using System;

namespace Ofl.Search.Elasticsearch
{
    public class ElasticsearchConfiguration
    {
        public Uri Url { get; set; }

        public bool EnableHttpCompression { get; set; }
    }
}
