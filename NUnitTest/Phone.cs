using System;
using System.Collections.Generic;
using System.Text;

namespace MyTestedApp
{
    class Phone
    {
        private string number;
        private string owner;
        private string model;
        private float price;

        public Phone()
        {

        }
        public Phone(string number, string owner, string model, float price)
        {
            this.number = number;
            this.owner = owner;
            this.model = model;
            this.price = price;
        }
        
        public string Number()
        {
            return number;
        }
        public void Number(string number)
        {
            this.number = number;
        }
      
        public void Owner(string owner)
        {
            this.owner = owner;
        }
        public string Model()
        {
            return this.model;
        }
        public float Price()
        {
            return price;
        }
        public void Price(float price)
        {
            this.price = price;
        }

        
        public bool Call(string number)
        {
            if (number != null)
            {
                LogToFile.WriteToFile(true, this.owner + " is calling " + number);
                return true;
            }
            else
            {
                LogToFile.WriteToFile(false, "Cant call because there is no number");
                return false;
            }
        }
        public string GetOwner(string number)
        {
            if (this.number.Equals(number))
            {
                LogToFile.WriteToFile(true, owner + " is returned by number");
                return owner;
            }
            else
            {
                LogToFile.WriteToFile(false, "Cant return owner cause you dont know the number");
                return null;
            }
        }
        
    }
}
