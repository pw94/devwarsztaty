using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Warsztaty.Api.Storage
{
    public class InMemoryDb : IStorage
    {
        private readonly ConcurrentBag<string> addedKeys = new ConcurrentBag<string>();

        public void Add(string key)
        {
            addedKeys.Add(key);
        }

        public IList<string> GetAll() => addedKeys.ToArray();
    }
}