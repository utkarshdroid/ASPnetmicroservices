using System;
using Catalog.api.Entities;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Catalog.api.Data
{
    public class CatalogContext: ICatalogContext
    {
        public IMongoCollection<Product> Products { get; }
        public CatalogContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetValue<String>("DatabaseSettings:ConnectionString"));
            var database = client.GetDatabase(configuration.GetValue<String>("DatabaseSettings:DatabaseName"));
            Products = database.GetCollection<Product>(configuration.GetValue<String>("DatabaseSettings:CollectionName"));
            CatalogContextSeed.SeedData(Products);
            
        }
    }
}
