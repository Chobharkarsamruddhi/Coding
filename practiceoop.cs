using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeC_
{
    class Animal

    {
        public String Name;
        public String Voice;
        public void display()
        {
            Console.WriteLine("I am the pet animal");
            Console.WriteLine("I am claver animal");
        }
        class Dog : Animal
        {
            public void getname()
            {
                Console.WriteLine("My Name is " + Name);

            }
            public void  getvoice()
            {
                Console.WriteLine("My Voice is " + Voice);
            }
        }
        class Program
        {

            static void Main(string[] args)
            {


                Dog D1 = new Dog();
                Dog D2 = new Dog();

                D1.Name = "kuku";
                D1.display();

                D2.Voice = "bhau bhau";
                D2.display();

                D1.getname();
                D2.getvoice();

                Console.ReadLine();
            }


        }
    }
}
