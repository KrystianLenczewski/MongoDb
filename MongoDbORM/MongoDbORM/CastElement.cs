using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoDbORM
{
    public class CastElement
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }
        public string tconst { get; set; }
        public int ordering { get; set; }
        public string nconst { get; set; }
        public string category { get; set; }
        public string job { get; set; }
        public string characters { get; set; }

    }
}
