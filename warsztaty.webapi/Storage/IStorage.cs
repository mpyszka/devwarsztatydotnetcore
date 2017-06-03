using System.Collections.Generic;

namespace warsztaty.webapi.Storage
{
    public interface IStorage
    {
        void Add(string key);
        List<string> GetAll();
    }

    public class InMemoryDb : IStorage
    {
        private readonly List<string> _addedKeys = new List<string>();
        public void Add(string key)
        {
            _addedKeys.Add(key);
        }

        public List<string> GetAll() => new List<string>(_addedKeys);
  
    }
}