using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoDbORM
{
    class RatingElement
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }
        public string TConst { get; set; }
        public double AverageRating { get; set; }
        public int NumVotes { get; set; }


    }
}
