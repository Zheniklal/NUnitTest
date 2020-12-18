using System;
using System.Collections.Generic;
using System.Text;

namespace MyTestedApp
{
    class Person
    {
        private string name;
        private int age;
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        
        public string Name()
        {
            return this.name;
        }
        public bool MakeFriend(Person person)
        {
            if (person != null)
            {
                LogToFile.WriteToFile(true, this.name + " is a friend with " + person.Name());
                return true;
            }
            else
            {
                LogToFile.WriteToFile(false, "There is nobody to make new friends with " + name);
                return false;
            }
                
        }
    }
}
