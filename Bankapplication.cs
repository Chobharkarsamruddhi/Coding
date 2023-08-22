using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
namespace BankAcountapp
{

    
        
    
    internal class Program
    {
        static void Main(string[] args)
        {
            string Firstname;
            string Lastname;
            string gender;
            string email;
           
            string Mstatus;


            Console.WriteLine("Enter the first Name");
            Firstname = Console.ReadLine();
            


            Console.WriteLine("Enter the Lastname");
            Lastname = Console.ReadLine();
           


            Console.WriteLine("Enter the gender");
            Console.WriteLine("F - Female");
            Console.WriteLine("M - Male");

            switch (Console.ReadLine())
            {
                case "F":
                    Console.WriteLine("Gender is Female");
                    break;
                case "M":
                    Console.writeLine("Gender is Male");

            }

            


            Console.WriteLine("Enter the email");
            email = Console.ReadLine();
         


            

            Console.WriteLine("Enter the marride status");
            Console.WriteLine("A  -    unmarride");
            Console.WriteLine("B  -    marride ");
            Console.WriteLine("C -    seprated");
            Console.WriteLine("D -    divorsed");

            switch (Console.ReadLine())
            {
                case "A":
                    Console.WriteLine("Marride status is :unmarride" );
                    break;
                case "B":
                    Console.WriteLine("Marride status is :marride");
                    break;
                case "C":
                    Console.WriteLine("Marride status is seprated");
                    break;
                case "D":
                    Console.WriteLine("Marride status is divorsed");
                    break;

            }
            if Mstatus = Marride;
            then SpouseNam = Console.readline();

            if Mstatus = (sepreted ||Divorse)
                then ("Do you have childran?(y/n)":)
           
            
            Mstatus = Console.ReadLine();

            Console.ReadLine();
              


        }
    }
}
