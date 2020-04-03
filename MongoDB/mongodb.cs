using Indeed;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace MongoDB
{
    
        public class Mongo
        {
            MongoClient client = new MongoClient();
            IMongoDatabase database;
            IMongoCollection<Result> collection;

            public void Connect()
            {
                database = client.GetDatabase("Indeed");
                collection = database.GetCollection<Result>("Jobs");
            }


            public void PostJob(Result Jobs)
            {
                    collection.InsertOne(Jobs);
            }

            public List<Result> FindJobs(string query)
            {

                return (List<Result>)collection.Find<Result>(x => x.Query == query).ToList<Result>();

            }

            
        }
    
}
