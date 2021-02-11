using System;
using System.Collections.Generic;
using System.Text;

namespace Day12b
{
    public class ListDataRepository : IDataRepository
    {
        private readonly List<string> _data = new List<string>();

        public string GetAll()
        {
            return string.Join(" ", _data);
        }

        public void Save(string data)
        {
            _data.Add(data);
        }
    }
}
