using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FashionIsU.UI
{
    internal class ConsoleUtility
    {
        public static void ClearScreen()
        {
            
            Console.Clear();
            MainUI.PrintHeader();
        }

        public static void ReturnForAll() //this is used as a return function for all functions
        {
            Console.Write("Press any key to return...");
            Console.Read();
        }


        public static string ValidateWordsWithInt(string name)
        {
            while (CheckforEmpty(name) || CheckingForSpace(name) || ContainsInteger(name))
            {
                if (CheckforEmpty(name))
                {
                    Console.WriteLine("It must not be empty.");
                }
                else if (ContainsInteger(name))
                {
                    Console.WriteLine("It must not contain integers.");
                }
                else if (CheckingForSpace(name))
                {
                    Console.WriteLine("It must not contain spaces.");
                }

                // Prompt for input again
                Console.Write("Enter again: ");
                name = Console.ReadLine();
            }


            return name;
        }

        public static bool ContainsInteger(string input)
        {
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }

        public static string ValidateWords(string name)
        {
            while (CheckforEmpty(name) || CheckingForSpace(name))
            {
                if (CheckforEmpty(name))
                {
                    Console.WriteLine("It must not be empty.");
                }

                if (CheckingForSpace(name))
                {
                    Console.WriteLine("It must not contain a space.");
                }

                // Prompt for input again
                Console.Write("Enter again: ");
                name = Console.ReadLine();
            }

            return name;


           
        }

        public static string RestrictPassword(string password)
        {
            while (CheckforEmpty(password) || CheckingForSpace(password) || !CheckingPasswordLength(password) || !CheckingforInteger(password))
            {
                if (!CheckingPasswordLength(password) || !CheckingforInteger(password))
                {
                    Console.WriteLine("The password is not according to given criteria.");
                }

                if (CheckingForSpace(password))
                {
                    Console.WriteLine("Password should not contain spaces.");
                }

                if (CheckforEmpty(password))
                {
                    Console.WriteLine("Password should not be empty.");
                }

                // Prompt for input again
                Console.Write("Enter password again: ");
                password = Console.ReadLine();
            }

            return password;

            
        }

        public static string ValidateContact(string contact)
        {
            while (CheckforEmpty(contact) || !ValidateContactPattern(contact))
            {
                if (CheckforEmpty(contact))
                {
                    Console.WriteLine("Contact number should not be empty.");
                }

                if (!ValidateContactPattern(contact))
                {
                    Console.WriteLine("Contact number should be in the format (XXXX-XXXXXXX).");
                }

                // Prompt for input again
                Console.Write("Enter contact number again: ");
                contact = Console.ReadLine();
            }

            return contact;
        }


        public static string ValidateGender(string gender)
        {
            while (CheckforEmpty(gender) || (gender.ToLower() != "male" && gender.ToLower() != "female"))
            {
                if (CheckforEmpty(gender))
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

        public static string ValidateEmail(string email)
        {
            while (CheckforEmpty(email) || !ValidateEmailPattern(email))
            {
                if (CheckforEmpty(email))
                {
                    Console.WriteLine("Email should not be empty.");
                }

                if (!ValidateEmailPattern(email))
                {
                    Console.WriteLine("Email should be in the proper email format.");
                }

                // Prompt for input again
                Console.Write("Enter email again: ");
                email = Console.ReadLine();
            }

            return email;
        }


        public static string ValidateSentences(string sen)
        {
            while (CheckforEmpty(sen))
            {
                if (CheckforEmpty(sen))
                {
                    while (CheckforEmpty(sen))
                    {
                        Console.WriteLine("It should not be empty.");
                        Console.Write("Enter again: ");
                        sen = Console.ReadLine();

                    }
                }

                
            }

            return sen;
        }

        public static bool CheckIDExist(string temp)
        {
            if(ClothesDL.FindClothByID(int.Parse(temp)) != null)
            {
                return true;
            }
            return false;
        }

        public static int ValidateId(string temp)
        {
            int id;
            temp = ValidateSentences(temp);
            while (CheckIDExist(temp) || !CheckingforInteger(temp))
            {
                if (CheckIDExist(temp))
                {
                    Console.WriteLine("ID is already assigned.");
                }

                if (!CheckingforInteger(temp))
                {
                    Console.WriteLine("ID must be an integer.");
                }

                // Prompt for input again
                Console.Write("Enter ID again: ");
                temp = Console.ReadLine();
            }

            // Parse the input after validation
            id = int.Parse(temp);

            return id;
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

        static bool CheckingforInteger(string sen)
        {
            for (int x = 0; x < sen.Length; x++)
            {
                if (sen[x] < '0' || sen[x] > '9')
                {
                    return false;
                }
            }

            return true;
        }

        static bool CheckingPasswordLength(string sen)
        {
            if (sen.Length != 6)
            {
                return false;
            }
            return true;
        }

        static bool CheckingForSpace(string sen)
        {
            for (int x = 0; x < sen.Length; x++)
            {
                if (sen[x] == ' ')
                {
                    return true;
                }
            }
            return false;
        }

        static bool CheckforEmpty(string sen)
        {
            if (sen == "")
            {
                return true;
            }

            return false;
        }

        static bool ValidateContactPattern(string contact)
        {
            string pattern = @"^\d{4}-\d{7}$"; // Pattern for "XXXX-XXXXXXX" format
            return Regex.IsMatch(contact, pattern);
        }
        static bool ValidateEmailPattern(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Check if the email matches the pattern
            return Regex.IsMatch(email, pattern);
        }


        public static string ValidatePin(string pin)
        {
            while (!ValidateFourDigitPin(pin))
            {
                Console.WriteLine("Invalid PIN format. Please enter a four-digit PIN composed of digits (0-9).");
                Console.Write("Enter PIN again: ");
                pin = Console.ReadLine();
            }

            return pin;
        }

        public static bool ValidateFourDigitPin(string pin)
        {
            // Check if the PIN is exactly four characters long
            if (pin.Length != 4)
            {
                return false;
            }

            // Check if each character in the PIN is a digit
            foreach (char c in pin)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }

            // If all conditions pass, return true
            return true;
        }

        public static bool ValidateRatingString(string ratingString)
        {
            // Check if the input is a number
            if (!int.TryParse(ratingString, out int rating))
            {
                return false;
            }

            // Check if the number is in the range 1-5
            return rating >= 1 && rating <= 5;
        }


        public static int ValidateRating(string rating)
        {
            

            while (true)
            {
                
                

                // Check if the input is not a number or not in the range 1-5
                if (!ValidateRatingString(rating))
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



    }
}
