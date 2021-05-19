using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoDbORM
{
    public class TitleElement
    {
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("id")]
        public string Id { get; set; }
        [BsonElement("tconst")]
        public string TConst { get; set; }
        [BsonElement("titleType")]
        public string TitleType { get; set; }
        [BsonElement("primaryTitle")]
        public string PrimaryTitle { get; set; }
        [BsonElement("originalTitle")]
        public string OriginalTitle { get; set; }
        [BsonElement("isAdult")]
        public bool IsAdult { get; set; }
        [BsonElement("startYear")]
        public int? StartYear { get; set; }
        [BsonElement("endYear")]
        public string EndYear { get; set; }
        [BsonElement("runtimeMinutes")]
        public int RuntimeMinutes { get; set; }
        [BsonElement("genres")]
        public string Genres { get; set; }

    }
}
