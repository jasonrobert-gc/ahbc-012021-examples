using System;
using System.Collections.Generic;
using System.Text;

namespace Day12b
{
    public class EmptyDataRepository : IDataRepository, ISomeOtherInterface
    {
        public string GetAll()
        {
            return string.Empty;
        }

        public void Save(string data)
        {

        }

        public string SayHello()
        {
            return "hello world";
        }
    }
}
