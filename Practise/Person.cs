using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Practise
{
    [DataContract]
    public class Person
    {
        [DataMember]
        public bool IsMember { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Age { get; set; }
        
        public Person(bool ismember, string name, int age)
        {
            IsMember = ismember;
            Name = name;
            Age = age;
        }
    }

    
}
