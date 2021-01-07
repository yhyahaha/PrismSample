using System;
using System.Collections.Generic;

namespace PrismSample
{
    public interface IPersonRepository
    {
        public List<Person> GetPersons();
    }
}
