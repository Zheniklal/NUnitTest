using MyTestedApp;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1MakeFriend_True()
        {
            Person person1 = new Person("Anya", 19);
            Person person2 = new Person("Vanya", 19);

            bool result = person1.MakeFriend(person2);

            Assert.IsTrue(result);
        }
        [Test]
        public void Test2MakeFriend_False()
        {
            Person person1 = new Person("Anya", 19);
            Person person2 = new Person("Vanya", 19);

            person2 = null;

            bool result = person1.MakeFriend(person2);

            Assert.IsFalse(result);
        }
        [Test]
        public void Test3MathDiv_Equal()
        {
            int result = Mathematica.Div(9, 3);

            Assert.AreEqual(3, result);
        }
        [Test]
        public void Test4MathDiv_ExDivBy0()
        {
            Assert.Throws<System.ArithmeticException>(() => Mathematica.Div(9, 0));
        }
        [Test]
        public void Test5MathIsMoreThan_True()
        {
            int a = 5;
            int b = 3;

            bool result = Mathematica.isMoreThan(a, b);

            Assert.IsTrue(result);
        }
        [Test]
        public void Test6MathIsMoreThan_False()
        {
            int a = 5;
            int b = 9;

            bool result = Mathematica.isMoreThan(a, b);

            Assert.IsFalse(result);
        }
        [Test]
        public void Test7PhoneCall_True()
        {
            Phone phone1 = new Phone("+375331234567", "Anya", "Iphone", 999);
            Phone phone2 = new Phone("+375338765432", "Vanya", "Samsung", 666);

            bool result = phone1.Call(phone2.Number());
            
            Assert.IsTrue(result);
        }
        [Test]
        public void Test8PhoneCall_False()
        {
            Phone phone1 = new Phone("+375331234567", "Anya", "Iphone", 999);
            Phone phone2 = new Phone("+375338765432", "Vanya", "Samsung", 666);

            phone2.Number(null);

            bool result = phone1.Call(phone2.Number());

            Assert.IsFalse(result);
        }
        [Test]
        public void Test9PhoneGetOwner_Correct()
        {
            Phone phone = new Phone("+375331111111", "Anya", "Iphone", 555);

            string owner = "Anya";

            string result = phone.GetOwner(phone.Number());
            
            Assert.AreEqual(owner, result);
        }
        [Test]
        public void Test10PhoneGetOwner_Incorrect()
        {
            Phone phone1 = new Phone("+375331111111", "Anya", "Iphone", 555);
            Phone phone2 = new Phone("+375332222222", "Vanya", "Iphone", 111);

            string owner = "Anya";

            string result = phone1.GetOwner(phone2.Number());

            Assert.AreNotEqual(owner, result);

        }
    }
}