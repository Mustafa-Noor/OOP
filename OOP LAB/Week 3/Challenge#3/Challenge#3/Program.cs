using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Xml.Linq;
using System.Reflection;

namespace Challenge_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            // object array of user data
            List <Muser> users = new List<Muser>();
            // this function loads the data from the file
            retrieveFile(users);
            while (true)
            {
                // this function clears the screen and prints the header
                clearScreen();
                string choice = menu();// this prints the menu of sign in or sign up
                if (choice == "1")
                {
                    Console.Clear();
                    Muser User = signInWindow(); 

                    if (User != null) 
                    {
                        User = giveUser(users, User);
                        if(User == null)
                        {
                            Console.WriteLine("There exists no such user....");
                        }
                        else if (User.role == "Customer" || User.role == "customer")
                        {
                            Console.WriteLine("Welcome Our Dear Customer.");
                        }
                        else if (User.role == "Employee" || User.role == "employee")
                        {
                            Console.WriteLine("Welcome Our Dear Employee.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("User does not exist...");
                        Thread.Sleep(200);
                    }
                    // this function returns the user to the previous screen
                    returnforAll();

                }
                else if (choice == "2")
                {
                    Console.Clear();
                    Muser User= getDetails(); 
                    if(User!=null)
                    {
                        SaveinFile(User);
                        users.Add(User);
                        Console.WriteLine("Signed in Successfully...");
                    }
                    
                    returnforAll();
                    
                }
                else if (choice == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect Input..");
                    Thread.Sleep(200);
                }
            }
        }

        static Muser giveUser(List<Muser> users,Muser User) // this verifies the usernamwe
        {
            foreach(Muser stored in users)
            {
                if (User.username == stored.username && User.password == stored.password)
                {
                    return stored;
                }
            }

            return null;
        }


        static Muser signInWindow() // it displays the sign in menu and takes the input
        {
            Console.WriteLine("-----------Sign In Menu--------------");
            Console.WriteLine();
            Console.Write("Enter Username: ");
            string username = Console.ReadLine();
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            if(username !=null && password!=null)
            {
                Muser u = new Muser(username, password);
                return u;
            }

            return null;
        }

        static Muser getDetails()   // it displays the sign up menu and takes the details
        {
            
            Console.WriteLine("-----------Sign Up Menu-------------");
            Console.WriteLine();
            Console.Write("Enter Username: ");
           string username = Console.ReadLine();
            Console.Write("Enter Password: ");
           string password = Console.ReadLine();
            Console.Write("Enter your Role (Employee or Customer): ");
           string role = Console.ReadLine();
            Console.WriteLine();

            if (username != null && password != null && role != null)
            {
                Muser user = new Muser(username, password, role);
                return user;
            }
            return null;

        }


        static void returnforAll() //this is used as a return function for all functions
        {
            Console.WriteLine();
            Console.Write("Press any key to return...");
            Console.Read();
        }

        static void clearScreen()
        {
            Console.Clear();
            Console.WriteLine("-----------Sign In Or Sign Up Menu-------------");
            Console.WriteLine();

        }

        static string menu() // this prints the menu
        {
            Console.WriteLine("1. Sign IN");
            Console.WriteLine("2. Sign UP");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your Choice: ");
            string choice = Console.ReadLine();
            return choice;
        }

        static void SaveinFile(Muser User) // it saves in file
        {
            string filepath = "C:\\Users\\musno\\OneDrive\\Documents\\Myfile.txt";
            StreamWriter file = new StreamWriter(filepath, false);
                file.WriteLine(User.username + "," + User.password + "," + User.role);
                file.Flush();
            file.Close();
        }

        static void retrieveFile(List<Muser> users) // it retrieves info from the file
        {
            string filepath = "C:\\Users\\musno\\OneDrive\\Documents\\Myfile.txt";
            if (File.Exists(filepath))
            {
                StreamReader file = new StreamReader(filepath);
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    
                    string username = parsedata(record, 1);
                    string password = parsedata(record, 2);
                   string role = parsedata(record, 3);
                    Muser u = new Muser(username, password, role);
                    users.Add(u);
                }
            }
        }

        static string parsedata(string record, int field) // it is to break section from each line of the file
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item += record[x];
                }
            }
            return item;
        }

    }



    internal class Muser
    {
        public string username;
        public string password;
        public string role;

        public Muser(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public Muser(string username, string password, string role)
        {
            this.username = username;
            this.password = password;
            this.role = role;
        }

        public string giveRole()
        {
            return this.role;
        }
    }
}

