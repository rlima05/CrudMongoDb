using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDbPoc.Builder
{
    public class PersonBuilder
    {
        protected Person Person = new Person();

        public PersonInfoBuilder Infos => new PersonInfoBuilder(Person);

        public PersonAddressBuilder Lives => new PersonAddressBuilder(Person);

        public PersonJobBuilder Works => new PersonJobBuilder(Person);

        public Person ToPerson()
        {
            return Person;
        }
    }
}
