﻿using System;
using ElasticLinq;

namespace Goldfinch.Demo.DAL
{
    public class SimpleItemElasticContext : ElasticSearchContext
    {

        public SimpleItemElasticContext()
            : base(new ElasticConnection(new Uri(DALSettingsWrapper.ElasticSearchEndpoint), index: DALSettingsWrapper.DefaultIndexName))
        {
            
        }

        public SimpleItemElasticContext(string uri, string index = null)
            : base(new ElasticConnection(new Uri(uri), index: index ?? DALSettingsWrapper.DefaultIndexName))
        {
            
        }
    }
}