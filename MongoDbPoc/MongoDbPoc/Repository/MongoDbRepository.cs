using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections;
using System.Collections.Generic;

namespace MongoDbPoc.Repository
{
    public class MongoDbRepository
    {
        private readonly MongoClient _cliente;
        private readonly IMongoDatabase Db;
        private readonly IMongoCollection<Person> _collection;
        

        public MongoDbRepository()
        {
            _cliente = new MongoClient("");
            Db = _cliente.GetDatabase("CrudApi");
            _collection = Db.GetCollection<Person>("Person");            
        }

        public void Add(Person person)
        {
            _collection.InsertOne(person);
        }

        public IEnumerable<Person> GetAll()
        {
            return _collection.Find(Builders<Person>.Filter.Empty).ToList();
        }

        public Person GetByName(string name)
        {
            var filter = Builders<Person>.Filter.Eq(c => c.Name, name);
            return _collection.Find(filter).First();
        }

        public void Remove(ObjectId id)
        {
            var filter = Builders<Person>.Filter.Eq(c => c._id, id);
            _collection.DeleteOne(filter);
        }

        public void Update(Person person)
        {
            var filter = Builders<Person>.Filter.Eq(c => c._id, person._id);
            _collection.ReplaceOne(filter, person);
        }
    }
}
