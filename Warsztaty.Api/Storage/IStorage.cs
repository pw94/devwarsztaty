using System;
using System.Collections.Generic;

namespace Warsztaty.Api.Storage
{
    public interface IStorage
    {
        void Add(string key);
        IList<string> GetAll();
    }
}