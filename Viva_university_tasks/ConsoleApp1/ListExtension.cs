using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        string? name;
        int age;
        string? position;
        public Person()
        {
            Console.Write("Please input name: ");
            this.name = Console.ReadLine();
            Console.Write("Please input age: ");
            this.age = int.Parse(Console.ReadLine());
            Console.Write("Please input your position: ");
            this.position = Console.ReadLine();

        }
        public Person(string name, int age,string position)
        {
            this.name = name;
            this.age = age;
            this.position = position;   
        }
        //inthernet versia
        /* public int CompareTo(Person comparePerson)
        {
            // A null value means that this object is greater.
            if (comparePerson == null)
                return 1;

            else
                return this.age.CompareTo(comparePerson.age);
        }*/
        public string Name
        {
            get { return name; }
        }
        public int Age
        {
            get { return age; }
        }
        public string Position
        {
            get { return position; }
        }
    }
    public static class ListExtension
    {
        public static List<Person> SortedByProperty(this List<Person> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i].Age > list[j].Age)
                    {
                        Person temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
            return list;
        }
    }
}
