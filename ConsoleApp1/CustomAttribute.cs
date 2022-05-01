using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [AttributeUsage(AttributeTargets.Class)]
    public class SampleAttribute : Attribute
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    [Sample(Id = 10; Name = "Tutorials";)]
    public class MyClass
    {

    }
}