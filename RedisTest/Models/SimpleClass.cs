using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedisTest.Models
{
    [Serializable]
    public class SimpleClass
    {
        public int Id { get; set; }
        public string Value { get; set; }
    }
}