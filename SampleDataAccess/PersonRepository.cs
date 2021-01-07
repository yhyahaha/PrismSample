using System;
using System.Collections.Generic;
using System.Text;

namespace PrismSample
{
    public class PersonRepository:IPersonRepository
    {
        public List<Person> GetPersons()
        {
            return new List<Person>();
        }
    }
}
