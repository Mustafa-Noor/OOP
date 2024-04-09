using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionIsU
{
    internal class ConsoleValidation
    {
        public static string ValidateWordsWithInt(string name)
        {
            while (UtilityClass.CheckforEmpty(name) || UtilityClass.CheckingForSpace(name) || UtilityClass.ContainsInteger(name))
            {
                if (UtilityClass.CheckforEmpty(name))
                {
                    Console.WriteLine("It must not be empty.");
                }
                else if (UtilityClass.ContainsInteger(name))
                {
                    Console.WriteLine("It must not contain integers.");
                }
                else if (UtilityClass.CheckingForSpace(name))
                {
                    Console.WriteLine("It must not contain spaces.");
                }

                // Prompt for input again
                Console.Write("Enter again: ");
                name = Console.ReadLine();
            }


            return name;
        }

        public static string ValidateWords(string name)
        {
            while (UtilityClass.CheckforEmpty(name) || UtilityClass.CheckingForSpace(name))
            {
                if (UtilityClass.CheckforEmpty(name))
                {
                    Console.WriteLine("It must not be empty.");
                }

                if (UtilityClass.CheckingForSpace(name))
                {
                    Console.WriteLine("It must not contain a space.");
                }

                // Prompt for input again
                Console.Write("Enter again: ");
                name = Console.ReadLine();
            }

            return name;



        }

        public static string ValidateGender(string gender)
        {
            while (UtilityClass.CheckforEmpty(gender) || (gender.ToLower() != "male" && gender.ToLower() != "female"))
            {
                if (UtilityClass.CheckforEmpty(gender))
                {
                    Console.WriteLine("Gender should not be empty.");
                }
                else if (gender.ToLower() != "male" && gender.ToLower() != "female")
                {
                    Console.WriteLine("Gender should be either Male or Female.");
                }

                // Prompt for input again
                Console.Write("Enter gender again: ");
                gender = Console.ReadLine();
            }


            return gender;
        }

        public static int ValidateInt(string temp, int number)
        {
            do
            {

                if (int.TryParse(temp, out number) && number >= 0)
                {
                    return number;
                }
                else
                {
                    Console.Write("Invalid input. Please enter a valid number: ");
                    temp = Console.ReadLine();
                }


            } while (!int.TryParse(temp, out number) && number >= 0);

            return number;
        }

        public static int ValidateRating(string rating)
        {


            while (true)
            {

                // Check if the input is not a number or not in the range 1-5
                if (!UtilityClass.ValidateRatingString(rating))
                {
                    Console.WriteLine("Invalid rating.");
                    Console.Write("Enter again: ");
                    rating = Console.ReadLine();
                }
                else
                {
                    break; // Exit the loop if the rating is valid
                }
            }

            return int.Parse(rating);
        }

        public static string ValidateContact(string contact)
        {
            while (UtilityClass.CheckforEmpty(contact) || !UtilityClass.ValidateContactPattern(contact))
            {
                if (UtilityClass.CheckforEmpty(contact))
                {
                    Console.WriteLine("Contact number should not be empty.");
                }

                if (!UtilityClass.ValidateContactPattern(contact))
                {
                    Console.WriteLine("Contact number should be in the format (XXXX-XXXXXXX).");
                }

                // Prompt for input again
                Console.Write("Enter contact number again: ");
                contact = Console.ReadLine();
            }

            return contact;
        }

        public static string RestrictPassword(string password)
        {
            while (UtilityClass.CheckforEmpty(password) || UtilityClass.CheckingForSpace(password) || !UtilityClass.CheckingPasswordLength(password) || !UtilityClass.CheckingforInteger(password))
            {
                if (!UtilityClass.CheckingPasswordLength(password) || !UtilityClass.CheckingforInteger(password))
                {
                    Console.WriteLine("The password is not according to given criteria.");
                }

                if (UtilityClass.CheckingForSpace(password))
                {
                    Console.WriteLine("Password should not contain spaces.");
                }

                if (UtilityClass.CheckforEmpty(password))
                {
                    Console.WriteLine("Password should not be empty.");
                }

                // Prompt for input again
                Console.Write("Enter password again: ");
                password = Console.ReadLine();
            }

            return password;


        }

        public static string GetValidRole(string role)
        {
            string lowerCaseRole = role.ToLower();
            while (!UtilityClass.ValidateRole(lowerCaseRole))
            {
                lowerCaseRole = role.ToLower();
                if (!UtilityClass.ValidateRole(lowerCaseRole))
                {
                    Console.WriteLine("Invalid role. Role must be either 'employee' or 'customer'.");
                    Console.Write("Enter Again: ");
                    role = Console.ReadLine();
                }


            }

            return lowerCaseRole;
        }

        public static string ValidateSentences(string sen)
        {
            while (UtilityClass.CheckforEmpty(sen))
            {
                if (UtilityClass.CheckforEmpty(sen))
                {
                    while (UtilityClass.CheckforEmpty(sen))
                    {
                        Console.WriteLine("It should not be empty.");
                        Console.Write("Enter again: ");
                        sen = Console.ReadLine();

                    }
                }


            }

            return sen;
        }

        public static string ValidateEmail(string email)
        {
            while (UtilityClass.CheckforEmpty(email) || !UtilityClass.ValidateEmailPattern(email))
            {
                if (UtilityClass.CheckforEmpty(email))
                {
                    Console.WriteLine("Email should not be empty.");
                }

                if (!UtilityClass.ValidateEmailPattern(email))
                {
                    Console.WriteLine("Email should be in the proper email format.");
                }

                // Prompt for input again
                Console.Write("Enter email again: ");
                email = Console.ReadLine();
            }

            return email;
        }
    }


}
