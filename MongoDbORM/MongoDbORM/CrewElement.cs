using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoDbORM
{
    public class CrewElement
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string TConst { get; set; }
        public string Directors { get; set; }
        public string Writers { get; set; }


    }
}
