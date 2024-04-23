using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FashionIsU
{
    public class UtilityClass
    {
        private static string ConnectionString = "Data Source=GREY\\SQLEXPRESS;Initial Catalog=FashionIsU;Integrated Security=True";

        private static string UserFilePath = "C:\\Users\\musno\\OneDrive\\Desktop\\Semester 2\\Object Oriented Programming\\BA\\FashionIsULibrary\\FashionIsULibrary\\Files\\Users.txt";
        private static string ClothesFilePath = "C:\\Users\\musno\\OneDrive\\Desktop\\Semester 2\\Object Oriented Programming\\BA\\FashionIsULibrary\\FashionIsULibrary\\Files\\Clothes.txt";
        private static string CartsFilePath = "C:\\Users\\musno\\OneDrive\\Desktop\\Semester 2\\Object Oriented Programming\\BA\\FashionIsULibrary\\FashionIsULibrary\\Files\\Carts.txt";
        private static string OrdersFilePath = "C:\\Users\\musno\\OneDrive\\Desktop\\Semester 2\\Object Oriented Programming\\BA\\FashionIsULibrary\\FashionIsULibrary\\Files\\Orders.txt";
        private static string OrderItemsFilePath = "C:\\Users\\musno\\OneDrive\\Desktop\\Semester 2\\Object Oriented Programming\\BA\\FashionIsULibrary\\FashionIsULibrary\\Files\\OrderItems.txt";
        private static string ReviewsFilePath = "C:\\Users\\musno\\OneDrive\\Desktop\\Semester 2\\Object Oriented Programming\\BA\\FashionIsULibrary\\FashionIsULibrary\\Files\\Reviews.txt";
        private static string CustomerFilePath = "C:\\Users\\musno\\OneDrive\\Desktop\\Semester 2\\Object Oriented Programming\\BA\\FashionIsULibrary\\FashionIsULibrary\\Files\\Customers.txt";
        private static string EmployeeFilePath = "C:\\Users\\musno\\OneDrive\\Desktop\\Semester 2\\Object Oriented Programming\\BA\\FashionIsULibrary\\FashionIsULibrary\\Files\\Employees.txt";

        // getter of all file path
        public static string GetCustomerFilePath()
        { return CustomerFilePath; }
        public static string GetEmployeeFilePath()
        { return EmployeeFilePath; }
        public static string GetUserFilePath()
        { return UserFilePath;}

        public static string GetClothesFilePath() 
        {  return ClothesFilePath; }

        public static string GetCartsFilePath()
        {  return CartsFilePath;}

        public static string GetOrdersFilePath() 
        {  return OrdersFilePath;}
        public static string GetOrderItemsFilePath()
        {  return OrderItemsFilePath;}
        public static string GetReviewsFilePath()
        { return ReviewsFilePath;}

        // getter of connection string of database
        public static string GetConnectionString()
        { return ConnectionString; }


        // these are for validations

        public static bool ContainsInteger(string input) // checks the existence of an integer
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

        public static bool CheckingforInteger(string sen) // return true if it contains integer
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

        public static bool CheckingPasswordLength(string sen) // checks the length of password
        {
            if (sen.Length != 6)
            {
                return false;
            }
            return true;
        }

        public static bool CheckingForSpace(string sen) // checks for space in the string
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

        public static bool CheckforEmpty(string sen) // check the empty string
        {
            if (sen == "")
            {
                return true;
            }

            return false;
        }

        public static bool ValidateContactPattern(string contact) // checks the contact no pattern
        {
            string pattern = @"^\d{4}-\d{7}$"; // Pattern for "XXXX-XXXXXXX" format
            return Regex.IsMatch(contact, pattern);
        }
        public static bool ValidateEmailPattern(string email) // checks the email pattern
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Check if the email matches the pattern
            return Regex.IsMatch(email, pattern);
        }


        


        public static bool ValidateRatingString(string ratingString) // checks the rating
        {
            // Check if the input is a number
            if (!int.TryParse(ratingString, out int rating))
            {
                return false;
            }

            // Check if the number is in the range 1-5
            return rating >= 1 && rating <= 5;
        }


        

        public static bool ValidateRole(string role) // validates the role
        {
            if (role == "employee" || role == "customer" || role == "admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckingForcomma(string sen) // checks for comma due to file handling
        {
            for (int x = 0; x < sen.Length; x++)
            {
                if (sen[x] == ',')
                {
                    return true;
                }
            }
            return false;
        }







    }
}
