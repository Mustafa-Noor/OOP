using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionIsU
{
    internal class ConsoleValidationUI
    {
        public static string ValidateWordsWithInt(string name) // validation for words which cant have integer
        {
            while (UtilityClass.CheckforEmpty(name) || UtilityClass.CheckingForSpace(name) || UtilityClass.ContainsInteger(name) || UtilityClass.CheckingForcomma(name))
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
                else if(UtilityClass.CheckingForcomma(name))
                {
                    Console.WriteLine("It must not contain comma.");
                }

                // Prompt for input again
                Console.Write("Enter again: ");
                name = Console.ReadLine();
            }


            return name;
        }

        public static string ValidateWords(string name) // validation for words which can contain integer
        {
            while (UtilityClass.CheckforEmpty(name) || UtilityClass.CheckingForSpace(name) || UtilityClass.CheckingForcomma(name))
            {
                if (UtilityClass.CheckforEmpty(name))
                {
                    Console.WriteLine("It must not be empty.");
                }

                else if (UtilityClass.CheckingForSpace(name))
                {
                    Console.WriteLine("It must not contain a space.");
                }

                else if (UtilityClass.CheckingForcomma(name))
                {
                    Console.WriteLine("It must not contain comma.");
                }


                // Prompt for input again
                Console.Write("Enter again: ");
                name = Console.ReadLine();
            }

            return name;



        }

        public static string ValidateGender(string gender) // it validates the gender
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

        public static string ValidatePosition(string position) // it validates the postion
        {
            while (UtilityClass.CheckforEmpty(position) || (position.ToLower() != "manager" && position.ToLower() != "salesman" && position.ToLower() != "supervisor"))
            {
                if (UtilityClass.CheckforEmpty(position))
                {
                    Console.WriteLine("Gender should not be empty.");
                }
                else if (position.ToLower() != "manager" && position.ToLower() != "salesman" && position.ToLower() != "supervisor")
                {
                    Console.WriteLine("Postion should be either Manager, Salesman or Supervisor.");
                }

                // Prompt for input again
                Console.Write("Enter position again: ");
                position = Console.ReadLine();
            }


            return position;
        }

        public static int ValidateInt(string temp, int number) // it validates integer
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

        public static int ValidateRating(string rating) // it validates rating
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

        public static string ValidateContact(string contact) // it validates the contact
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

        public static string RestrictPassword(string password) // it restricts the password 
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

        public static string GetValidRole(string role) // it validates role
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

        public static string ValidateSentences(string sen) // it validates sentences
        {
            while (UtilityClass.CheckforEmpty(sen) || UtilityClass.CheckingForcomma(sen))
            {
                if (UtilityClass.CheckforEmpty(sen) || UtilityClass.CheckingForcomma(sen))
                {
                    while (UtilityClass.CheckforEmpty(sen) || UtilityClass.CheckingForcomma(sen))
                    {
                        Console.WriteLine("It should not be empty or contain comma.");
                        Console.Write("Enter again: ");
                        sen = Console.ReadLine();

                    }
                }


            }

            return sen;
        }

        public static string ValidateEmail(string email) // it validates email
        {
            while (UtilityClass.CheckforEmpty(email) || !UtilityClass.ValidateEmailPattern(email) || UtilityClass.CheckingForcomma(email))
            {
                if (UtilityClass.CheckforEmpty(email))
                {
                    Console.WriteLine("Email should not be empty.");
                }

                else if (!UtilityClass.ValidateEmailPattern(email))
                {
                    Console.WriteLine("Email should be in the proper email format.");
                }
                else if (UtilityClass.CheckingForcomma(email))
                {
                    Console.WriteLine("It must not contain comma.");
                }


                // Prompt for input again
                Console.Write("Enter email again: ");
                email = Console.ReadLine();
            }

            return email;
        }
    }


}
