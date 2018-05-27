using MongoDB.Bson;
using System;

namespace MongoDbPoc
{


    public class Person
    {
        public ObjectId _id{ get; set; }
        

        public string Name { get; set; }

        public string DocumentNumber { get; set; }

        public DateTime BirthDate { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public bool IsEmployed { get; set; }

        public string Company { get; set; }

        public decimal Income { get; set; }
    }
}
