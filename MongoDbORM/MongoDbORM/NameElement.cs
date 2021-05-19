using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoDbORM
{
    class NameElement
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }
        public string NConst { get; set; }
        public string PrimaryName { get; set; }
        public DateTime BirthYear { get; set; }
        public DateTime DeathYear { get; set; }
        public string PrimaryProfession { get; set; }
        public string KnownForTitles { get; set; }


    }
}
