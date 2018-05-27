using MongoDbPoc.Builder;
using MongoDbPoc.Repository;
using System;

namespace MongoDbPoc
{
    class Program
    {
        static void Main(string[] args)
        {
            var personBuilder = new PersonBuilder();

            var person = personBuilder
                .Infos
                    .MyNameIs("Raphael")
                    .MyDocumentNumberIs("01234567890")
                    .IWasBornIn(new DateTime(1991, 04, 30))
                .Lives
                    .At("Building build")
                    .In("Santos")
                .Works
                    .At("Avanade")
                    .IsEmployed(true)
                    .WithIncome(1000)
                .ToPerson();

            var repository = new MongoDbRepository();

            repository.Add(person);

            var personGet = repository.GetByName(person.Name);

            var listOfPeople = repository.GetAll();

            person.Company = "New Company";

            repository.Update(person);

            
            repository.Remove(personGet._id);
        }
    }
}
