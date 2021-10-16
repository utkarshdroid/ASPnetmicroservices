﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.api.Entities
{
    public class Product
    {   [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("Name")]
        public string Name { get; set; }
        public string Category { get; set; }
        public int Summary { get; set; }
        public string  Description { get; set; }
        public string ImageFile { get; set; }
        public decimal Price { get; set; }
    }
}
