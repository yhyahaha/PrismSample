using System;

namespace PrismSample
{
    public class DataAgent : IDisposable
    {
        public DataAgent(IPersonRepository personRepository)
        {
            this.repository = personRepository;
        }

        public Person GetPerson(int personId)
        {
            var persons = this.repository.GetPersons();
            return persons.Find(p => p.Id == personId);
        }
        public virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {

                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        private IPersonRepository repository = null;
        private bool disposedValue;
    }
}
