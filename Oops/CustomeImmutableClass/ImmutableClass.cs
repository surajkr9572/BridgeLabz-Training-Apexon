using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops.CustomeImmutableClass
{
    public sealed class ImmutableClass
    {
        //create a readonly variable
        private readonly string name;
        private readonly int age;
        private readonly List<string> hobbies;
        private readonly int salary;
        public ImmutableClass(string name,int age,List<string>hobbies,int salary)
        {
            this.name = name;
            this.age = age;
            this.hobbies=new List<string>(hobbies);
            this.salary = salary;
        }
        public string Name
        {
            get { return name; }
        }
        public int Age
        {
            get { return age; }
        }
        public List<string>Hobbies
        {
            get
            {
                return new List<string>(hobbies);
            }
        }
        public int Salary
        {
            get { return salary; }
        }
    }
}
