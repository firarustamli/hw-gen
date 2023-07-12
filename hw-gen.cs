using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace hwgen
{


    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }

    
    class Program
    {


        public static void Main(string[] args)

        {

            Console.WriteLine("enter the name: ");
            var Input = Console.ReadLine();
            string A = Input.ToString();


            #region
            var pr1 = new Person()
            {
                Name = "fira1"
            };
            var pr2 = new Person()
            {
                Name = "fira2"
            };
            var pr3 = new Person()
            {
                Name = "fira3"
            };
            var pr4 = new Person()
            {
                Name = "fira4"
            };
            var pr5 = new Person()
            {
                Name = "fira5"
            };
            var pr6 = new Person()
            {
                Name = "fira6"
            };
            var pr7 = new Person()
            {
                Name = "fira7"
            };
            var pr8 = new Person()
            {
                Name = "fira8"
            };
            var pr9 = new Person()
            {
                Name = "fira9"
            };
            var pr10 = new Person()
            {
                Name = "fira10"
            };
            var InputName = new Person();
            #endregion

            List<Person> person = new List<Person>();

            person.Add(pr1);
            person.Add(pr2);
            person.Add(pr3);
            person.Add(pr4);
            person.Add(pr5);
            person.Add(pr6);
            person.Add(pr7);
            person.Add(pr8);
            person.Add(pr9);
            person.Add(pr10);
            person.Add(InputName);


            var result = person.Find(x => x == InputName);

            if (result == null)
            {
                Console.WriteLine("not found");
            }
            else
            {
                Console.WriteLine("found");
            }
        }


    }

}