using MongoDB.Driver;
using System;

namespace MongoDbORM
{
    class Program
    { 
        static MongoClient dbClient = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&ssl=false");
        static IMongoDatabase localDatabase = dbClient.GetDatabase("local");
        static void Main(string[] args)
        {


            zad3();
            Console.ReadLine();
        }

        public static void zad2()
        {
           
            var castCount = localDatabase.GetCollection<CastElement>("Cast").CountDocuments(x=>true);
            Console.WriteLine($"Liczba elementów kolekcji Cast to : {castCount}");

            var titleCount = localDatabase.GetCollection<TitleElement>("Title").CountDocuments(x => true);
            Console.WriteLine($"Liczba elementów kolekcji Title to : {titleCount}");

            var crewCount = localDatabase.GetCollection<CrewElement>("Crew").CountDocuments(x => true);
            Console.WriteLine($"Liczba elementów kolekcji Crew to : {crewCount}");

            var ratingCount = localDatabase.GetCollection<RatingElement>("Rating").CountDocuments(x => true);
            Console.WriteLine($"Liczba elementów kolekcji Rating to : {ratingCount}");

            var nameCount = localDatabase.GetCollection<NameElement>("Name").CountDocuments(x => true);
            Console.WriteLine($"Liczba elementów kolekcji Name to : {nameCount}");
        }

        public static void zad3()
        {
            var titleCollection = localDatabase.GetCollection<TitleElement>("Title").Find(x =>true).Limit(5);

            foreach (var item in titleCollection.ToList())
            {
                Console.WriteLine(item.OriginalTitle);
            }
        }
    }
}
