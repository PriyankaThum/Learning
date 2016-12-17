using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    class Student 
    {
        public string Name { get; set; }
        public DateTime DOB { get; set; }


        //public int CompareTo(Student other)
        //{
        //    return this.Name.CompareTo(other.Name);
        //}
        public int CompareTo(Student other)
        {
            return this.DOB.CompareTo(other.DOB);
        }
    }
}
