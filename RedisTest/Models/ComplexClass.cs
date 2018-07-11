using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedisTest.Models
{
    [Serializable]
    public class ComplexClass
    {
        public ComplexClass(int id, int listSize)
        {
            Id = id;
            Value = Id.ToString();
            List = new List<SimpleClass>();
            List2 = new List<SimpleClass>();
            for (var i = 0; i < listSize; ++i)
            {
                List.Add(new SimpleClass {Id = i, Value = i.ToString()});
                List2.Add(new SimpleClass { Id = i, Value = i.ToString() });
            }
        }
        public int Id { get; set; }
        public string Value { get; set; }
        public List<SimpleClass> List;
        public List<SimpleClass> List2;
    }
}