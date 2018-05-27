using System;

namespace MongoDbPoc.Builder
{
    public class PersonInfoBuilder : PersonBuilder
    {
        public PersonInfoBuilder(Person person)
        {
            Person = person;
        }

        public PersonInfoBuilder MyNameIs(string name)
        {
            Person.Name = name;
            return this;
        }

        public PersonInfoBuilder MyDocumentNumberIs(string documentNumber)
        {
            Person.DocumentNumber = documentNumber;
            return this;
        }

        public PersonInfoBuilder IWasBornIn(DateTime birthDate)
        {
            Person.BirthDate = birthDate;
            return this;
        }
    }
}
