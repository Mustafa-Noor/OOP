using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FashionIsU
{
    internal class UtilityClass
    {
        private static string connectionString = "Data Source=GREY\\SQLEXPRESS;Initial Catalog=FashionIsU;Integrated Security=True";
        public static string GetConnectionString()
        { return connectionString; }


        

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

        public static bool CheckingforInteger(string sen)
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

        public static bool CheckingPasswordLength(string sen)
        {
            if (sen.Length != 6)
            {
                return false;
            }
            return true;
        }

        public static bool CheckingForSpace(string sen)
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

        public static bool CheckforEmpty(string sen)
        {
            if (sen == "")
            {
                return true;
            }

            return false;
        }

        public static bool ValidateContactPattern(string contact)
        {
            string pattern = @"^\d{4}-\d{7}$"; // Pattern for "XXXX-XXXXXXX" format
            return Regex.IsMatch(contact, pattern);
        }
        public static bool ValidateEmailPattern(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Check if the email matches the pattern
            return Regex.IsMatch(email, pattern);
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


        

        public static bool ValidateRole(string role)
        {
            if (role == "employee" || role == "customer")
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        




    }
}
