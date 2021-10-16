using System;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using Catalog.api.Entities;
using System.Threading.Tasks;

namespace Catalog.api.Data
{
    public interface ICatalogConext
    {
        IMongoCollection<Product> Products { get; }

    }
}
