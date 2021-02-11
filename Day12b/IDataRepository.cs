using System;
using System.Collections.Generic;
using System.Text;

namespace Day12b
{
    public interface IDataRepository
    {
        void Save(string data);
        string GetAll();
    }
}
