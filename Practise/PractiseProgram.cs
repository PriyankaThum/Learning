using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Practise
{
    class PractiseProgram
    {
        static void Main(string[] args)
        {
            ////Console.WriteLine("Enter JSON Input");
            ////string input = Console.ReadLine();
            //byte[] asciiBytes = Encoding.ASCII.GetBytes(input);
            //MemoryStream mStream = new MemoryStream(asciiBytes);
            //DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Person));
            //Person p2 = (Person)ser.ReadObject(mStream);

            //Console.Write("Deserialized back, got name=");
            //Console.Write(p2.Name);
            //Console.Write(", age=");
            //Console.WriteLine(p2.Age);
            // User user = new User(input);

            //JObject json = JObject.Parse(input);
            //JArray token = (JArray)json["users"];
            //foreach(JToken jt in token)
            //{
            //    bool memberornot = (bool)jt["IsMember"];
            //    string Name = (string)jt["Name"];
            //    int Age = (int)jt["Age"];

            //    Console.WriteLine("Ismember : " + memberornot);
            //    Console.WriteLine("Name : " + Name);
            //    Console.WriteLine("Age : " + Age);
            //}
            ////List<User> user = JsonConvert.DeserializeObject<List<User>>(input);

            //List<Student> list = new List<Student>();
            //list.Add(new Student() { Name = "Priyanka", DOB = new DateTime(1992, 12, 08) });
            //list.Add(new Student() { Name = "Varsha", DOB = new DateTime(1994, 09, 24) });
            //list.Add(new Student() { Name = "Varshith", DOB = new DateTime(1996, 09, 07) });
            //list.Add(new Student() { Name = "Priya", DOB = new DateTime(1990, 09, 07) });
            //list.Add(new Student() { Name = "Latha", DOB = new DateTime(1980, 09, 07) });
            //list.Add(new Student() { Name = "Alekya", DOB = new DateTime(2010, 09, 07) });
            //list.Sort();
            //foreach (var element in list)
            //{
            //    Console.WriteLine(element.DOB);
            //}

            GuessTheNumberGame g = new GuessTheNumberGame();
            g.guess();
            Console.ReadLine();
        }
    }
}
