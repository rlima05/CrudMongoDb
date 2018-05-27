namespace MongoDbPoc.Builder
{
    public class PersonJobBuilder : PersonBuilder
    {
        public PersonJobBuilder(Person person)
        {
            Person = person;
        }

        public PersonJobBuilder At(string company)
        {
            Person.Company = company;
            return this;
        }

        public PersonJobBuilder IsEmployed(bool isEmployed)
        {
            Person.IsEmployed = isEmployed;
            return this;
        }

        public PersonJobBuilder WithIncome(decimal income)
        {
            Person.Income = income;
            return this;
        }
        
    }
}
