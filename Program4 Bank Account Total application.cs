using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Persnoal_family_bankrelated
{
    using System;

    namespace BankAccountApp
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Bank Account Application");

                // Personal Information
                Console.Write("Enter First Name: ");
                string firstName = Console.ReadLine();

                Console.Write("Enter Last Name: ");
                string lastName = Console.ReadLine();

                Console.Write("Enter Gender (M/F/O): ");
                char gender = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                Console.Write("Enter Email: ");
                string email = Console.ReadLine();

                Console.Write("Enter Date of Birth (YYYY-MM-DD): ");
                DateTime dob = DateTime.Parse(Console.ReadLine());

                Console.Write("Enter Marital Status (Married/Unmarried/Separated/Divorced): ");
                string maritalStatus = Console.ReadLine();

                string spouseName = string.Empty;
                if (maritalStatus.Equals("Married", StringComparison.OrdinalIgnoreCase)
                    || maritalStatus.Equals("Separated", StringComparison.OrdinalIgnoreCase)
                    || maritalStatus.Equals("Divorced", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("Enter Spouse Name: ");
                    spouseName = Console.ReadLine();
                }

                Console.Write("Do you have any children? (Yes/No): ");
                bool hasChildren = Console.ReadLine().Equals("Yes", StringComparison.OrdinalIgnoreCase);

                int childrenCount = 0;
                string[] childrenNames = null;
                if (hasChildren)
                {
                    Console.Write("Enter the number of children: ");
                    childrenCount = int.Parse(Console.ReadLine());
                    childrenNames = new string[childrenCount];

                    for (int i = 0; i < childrenCount; i++)
                    {
                        Console.Write($"Enter name of child {i + 1}: ");
                        childrenNames[i] = Console.ReadLine();
                    }
                }

                // Bank Related Information
                Console.Write("Enter Account Type (SA/CA): ");
                string accountType = Console.ReadLine();

                Console.Write("Enter Permanent Address: ");
                string permanentAddress = Console.ReadLine();

                Console.Write("Is Communication Address same as Permanent? (Yes/No): ");
                string communicationAddress = Console.ReadLine();
                if (!communicationAddress.Equals("Yes", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("Enter Communication Address: ");
                    communicationAddress = Console.ReadLine();
                }

                Console.Write("Do you require a Credit Card? (Yes/No): ");
                bool requireCC = Console.ReadLine().Equals("Yes", StringComparison.OrdinalIgnoreCase);

                string ccType = "None";
                if (requireCC)
                {
                    Console.Write("Enter Salary Bracket: ");
                    string salaryBracket = Console.ReadLine();

                    if (salaryBracket.Equals("Low", StringComparison.OrdinalIgnoreCase))
                        ccType = "Silver";
                    else if (salaryBracket.Equals("Medium", StringComparison.OrdinalIgnoreCase))
                        ccType = "Gold";
                    else if (salaryBracket.Equals("High", StringComparison.OrdinalIgnoreCase))
                        ccType = "Platinum";
                    else
                        Console.WriteLine("Credit Card not applicable for the specified salary bracket.");
                }

                // Display gathered information
                Console.WriteLine("\nGathered Information:");
                Console.WriteLine($"Name: {firstName} {lastName}");
                Console.WriteLine($"Gender: {gender}");
                Console.WriteLine($"Email: {email}");
                Console.WriteLine($"Date of Birth: {dob:yyyy-MM-dd}");
                Console.WriteLine($"Marital Status: {maritalStatus}");
                if (!string.IsNullOrEmpty(spouseName))
                    Console.WriteLine($"Spouse Name: {spouseName}");
                if (hasChildren)
                {
                    Console.WriteLine($"Children Count: {childrenCount}");
                    for (int i = 0; i < childrenCount; i++)
                    {
                        Console.WriteLine($"Child {i + 1} Name: {childrenNames[i]}");
                    }
                }
                Console.WriteLine($"Account Type: {accountType}");
                Console.WriteLine($"Permanent Address: {permanentAddress}");
                Console.WriteLine($"Communication Address: {communicationAddress}");
                if (requireCC)
                    Console.WriteLine($"Credit Card Type: {ccType}");
                Console.ReadLine();
            }
        }
    }

}
