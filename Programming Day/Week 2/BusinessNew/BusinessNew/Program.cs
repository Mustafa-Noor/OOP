using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Xml.Linq;
using System.Net.NetworkInformation;
using System.IO;

namespace BusinessNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> UserDetails = new List<User>();
            List<Clothes> ClothesInfo = new List<Clothes>();
            List<CustomerCloth> customerCloths = new List<CustomerCloth>();

           retrieveUsers(UserDetails);
            retrieveClothes(ClothesInfo);

            string op;

            while (true)
            {
                clearScreen();
                Console.WriteLine("----------------Log In Or Sign Up Menu-------------"); // Sub Menu Before Employee Menu or Customer Menu
                Console.WriteLine("1. Sign in");
                Console.WriteLine("2. Sign up");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice.. : ");
                op = Console.ReadLine();
                if(op == "1")
                {
                    clearScreen();
                    string name = "";
                    string password1 = "";
                    signinWindow(ref name, ref password1);
                    string role1 = signinMenu(UserDetails, name);

                    if (role1 == "Employee" || role1 == "employee")
                    {
                        congratsforSignin();

                        string employeechoice;
                        while (true)
                        {
                            clearScreen();
                            Console.WriteLine();
                            Console.WriteLine("----------Employee Menu-----------");
                            employeechoice = employeemenu();
                            if (employeechoice == "1")
                            {
                                clearScreen();
                                Console.WriteLine();
                                Console.WriteLine("-------------------Employee Clothes Items-------------------");
                                Console.WriteLine();
                                displayClothes(ClothesInfo);
                                returnforAll();
                            }
                            else if (employeechoice == "2")
                            {
                                clearScreen();
                                Console.WriteLine();
                                Console.WriteLine("-------------------Addition In Clothing Items-------------------");
                                Console.WriteLine();
                                int number = takeNumberOfClothes();
                                AddItem(ClothesInfo, number);
                                returnforAll();
                                Thread.Sleep(200);
                            }
                            else if (employeechoice == "3")
                            {
                                clearScreen();
                                Console.WriteLine();
                                Console.WriteLine("-------------------Update An Item Of Clothing-------------------");
                                Console.WriteLine();
                                if (ClothesInfo.Count > 0)
                                {
                                    int index = selectItem(ClothesInfo);
                                    if (index > 0 && index <= ClothesInfo.Count)
                                    {
                                        index--;
                                        changeItem(ClothesInfo, index);

                                    }
                                    else
                                    {
                                        Console.WriteLine("Incorrect Input...");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("There are no Clothes Yet...");
                                }

                                returnforAll();
                            }
                            else if (employeechoice == "4")
                            {
                                clearScreen();
                                Console.WriteLine();
                                Console.WriteLine("-------------------Delete An Item Of Clothing-------------------");
                                Console.WriteLine();
                                if (ClothesInfo.Count > 0)
                                {
                                    int index = selectItem(ClothesInfo);
                                    if (index > 0 && index <= ClothesInfo.Count)
                                    {
                                        index--;
                                        ClothesInfo.RemoveAt(index);

                                    }
                                    else
                                    {
                                        Console.WriteLine("Incorrect Input...");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("There are no Clothes Yet...");
                                }

                                returnforAll();

                            }
                            else if (employeechoice == "5")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Incorrect Input.....");
                                Thread.Sleep(200);
                            }
                        }

                    }
                    else if (role1 == "Customer" || role1 == "customer")
                    {

                        congratsforSignin();
                        string customerchoice;
                        while (true)
                        {
                            clearScreen();
                            Console.WriteLine();
                            Console.WriteLine("----------Customer Menu-----------");
                            Console.WriteLine();
                            customerchoice = customermenu();
                            if(customerchoice == "1")
                            {
                                clearScreen();
                                Console.WriteLine();
                                Console.WriteLine("----------Clothes Menu-----------");
                                Console.WriteLine();
                                int index = selectItem(ClothesInfo);
                                index--;
                                Console.WriteLine();
                                if (index >= 0 && index < ClothesInfo.Count)
                                {

                                    if (checkforAlreadyBought(ClothesInfo, customerCloths, index))
                                    {
                                        Console.WriteLine("The item is already Bought....");
                                    }
                                    else
                                    {
                                        BuyClothes(ClothesInfo, customerCloths, index);
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect Input...");
                                }
                                

                                returnforAll();
                                
                            }
                            else if (customerchoice == "2")
                            {
                                clearScreen();
                                Console.WriteLine();
                                Console.WriteLine("----------------------Cart-----------------------");
                                Console.WriteLine();
                                displayCart(customerCloths);
                                returnforAll();

                            }

                            else if (customerchoice == "3")
                            {
                                clearScreen();
                                Console.WriteLine();
                                Console.WriteLine("----------------------Print The Bill-----------------------");
                                Console.WriteLine();
                                printBill(customerCloths);
                                returnforAll();
                            }

                            else if (customerchoice == "4")
                            {
                                clearScreen();
                                Console.WriteLine();
                                Console.WriteLine("----------------------Pay The Bill-----------------------");
                                Console.WriteLine();
                                string answer = take1or0(customerCloths);
                                if(answer == "1")
                                {
                                    payBill(customerCloths, ClothesInfo);
                                    Console.WriteLine("Your bill has been paid....");
                                }

                                returnforAll();

                            }
                            else if(customerchoice == "5")
                            {
                                while( customerCloths.Count > 0)
                                {
                                    // Remove the last object from the list
                                    customerCloths.RemoveAt(customerCloths.Count - 1);
                                }

                                break;
                            }
                            else
                            {
                                Console.WriteLine("Incorrect Input.....");
                                Thread.Sleep(200);
                            }
                        }

                    }
                    else
                    {
                        Console.WriteLine("User Does not Exist...");
                        Thread.Sleep(200);
                    }

                }
                else if (op == "2")
                {
                    clearScreen();
                    string name="";
                    string password1 = "";
                    string role1 = SignUpMenu(UserDetails, ref name, ref password1); //recieves role from signupMenu()
                    if ((role1 == "Employee") || (role1 == "Customer") || (role1 == "employee") || (role1 == "customer"))
                    {
                        /*
                        if (role1 == "Customer" || role1 == "customer")
                        {
                            customer[cusCount] = name;
                            cusCount++;
                            customerArr[cusIndex] = name; //puts name in customerArr
                            cusIndex++;
                        }
                        */
                        if (role1 == "customer")
                        {
                            role1 = "Customer";
                        }
                        else if (role1 == "employee")
                        {
                            role1 = "Employee";
                        }

                        User s = new User(name, password1, role1);
                        UserDetails.Add(s);

                        

                        congratsforSignup();
                    }
                    else if (!(role1 ==""))
                    {
                        Console.WriteLine("Incorrect role...");
                        Thread.Sleep(300);
                    }
                }
                else if ((op == "3"))
                {
                    SaveUsers(UserDetails);
                    SaveClothes(ClothesInfo);
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect Input...");
                    Thread.Sleep(300);
                }
            }
        }

        static void printHeader()
        {

            Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% ");
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% ");
            Console.WriteLine("%%%%%%%%%%%%% #######   #####    #####   ##   ##  ######   #####   ###  ##      ######   #####       ##   ## %%%%%%%%%%%%% ");
            Console.WriteLine("%%%%%%%%%%%%%  ##  ##  ##   ##  ##   ##  ##   ##    ##    ##   ##  #### ##        ##    ##   ##      ##   ## %%%%%%%%%%%%% ");
            Console.WriteLine("%%%%%%%%%%%%%  ##      ##   ##  ##       ##   ##    ##    ##   ##  #######        ##    ##           ##   ## %%%%%%%%%%%%% ");
            Console.WriteLine("%%%%%%%%%%%%%  ####    #######   #####   #######    ##    ##   ##  ## ####        ##     #####       ##   ## %%%%%%%%%%%%% ");
            Console.WriteLine("%%%%%%%%%%%%%  ##      ##   ##       ##  ##   ##    ##    ##   ##  ##  ###        ##         ##      ##   ## %%%%%%%%%%%%% ");
            Console.WriteLine("%%%%%%%%%%%%%  ##      ##   ##  ##   ##  ##   ##    ##    ##   ##  ##   ##        ##    ##   ##      ##   ## %%%%%%%%%%%%% ");
            Console.WriteLine("%%%%%%%%%%%%% ####     ##   ##   #####   ##   ##  ######   #####   ##   ##      ######   #####        #####  %%%%%%%%%%%%% ");
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% ");
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% ");
        }


        static void clearScreen()
        {
            Console.Clear();
            printHeader();
        }

        static void returnforAll() //this is used as a return function for all functions
        {
            Console.Write("Press any key to return...");
            Console.Read();
        }

        static string signinMenu(List<User> UserDetails, string name)
        {
            
            string role1 = "";
            for(int i = 0; i<UserDetails.Count; i++)
            {
                if(name == UserDetails[i].username)
                {
                    role1 = UserDetails[i].role;
                }
            }
            
            return role1; 
        }

        static void signinWindow(ref string name, ref string password1)
        {
            Console.WriteLine();
            Console.WriteLine("--------Sign In----------");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Enter Username: ");
            name = Console.ReadLine();
            if (checkingforspace(name))
            {
                Console.WriteLine("It should nnot contain space.");
                Console.Write("Enter Again: ");
                name = Console.ReadLine();
            }

            Console.Write("Enter Password (6 digits): ");
            password1 = Console.ReadLine();
            password1 = retrictPassword(password1);

        }

        static string SignUpMenu(List<User> UserDetails, ref string name, ref string password1)
        {
            string role1;
            signupWindow(ref name, ref password1);
            if (checkUser(UserDetails, name))
            {
                Console.WriteLine("Username Already taken...");
                Thread.Sleep(200);
                role1 = "";
            }
            else
            {
                role1 = takeRole();
            }

            return role1;

        }

        static void congratsforSignup()
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine();
            Console.WriteLine("You have successfully signed up.");
            Console.Write("Press any key to continue...");
            Console.Read();
        }

        static void congratsforSignin()
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine();
            Console.WriteLine("You have successfully signed in.");
            Console.Write("Press any key to continue...");
            Console.Read();
        }

        static string takeRole()
        {
            
            
                string role1;
                Console.Write("Enter Role (Employee or Customer): ");
               role1 = Console.ReadLine();
            Console.WriteLine();
                return role1;
            
        }

        static void signupWindow(ref string name, ref string password1)
        {
           
            Console.WriteLine();
            Console.WriteLine("--------Sign Up----------");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Enter Username: ");
            name = Console.ReadLine();
            name = signupName(name);
            Console.Write("Enter Password (Must be 6-digits): ");
            password1 = Console.ReadLine();
            password1 = retrictPassword(password1);
            

        }

        static bool checkUser(List<User> UserDetails, string name)
        {
            for (int x = 0; x < UserDetails.Count; x++)
            {
                if (name == UserDetails[x].username)
                {
                    return true;
                }
            }
            return false;
        }

        static string signupName(string name)
        {
            while (checkforEmpty(name) || checkingForcomma(name) || checkingforspace(name))
            {
                if (checkforEmpty(name))
                {
                    while (checkforEmpty(name))
                    {
                        Console.WriteLine("It must not be empty.");
                        Console.Write("Enter again: ");
                        name = Console.ReadLine();
                    }
                }

                if (checkingForcomma(name))
                {
                    while (checkingForcomma(name))
                    {
                        Console.WriteLine("It must not contain a comma.");
                        Console.WriteLine("Enter again: ");
                        name = Console.ReadLine();
                    }
                }

                if (checkingforspace(name))
                {
                    while (checkingforspace(name))
                    {
                        Console.WriteLine("It must not contain a space.");
                        Console.Write("Enter again: ");
                        name = Console.ReadLine();
                    }
                }

            }


            return name;
        }

        // checks for empty spaces
        static bool checkforEmpty(string sen)
        {
            if (sen == "")
            {
                return true;
            }

            return false;
        }

        static bool checkingForcomma(string sen)
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

        static bool checkingforspace(string sen)
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

        static string retrictPassword(string sen)
        {
            while (checkingforspace(sen) || !checkingforlengthofP(sen) || !checkingforInteger(sen))
            {
                if (!checkingforlengthofP(sen) || !checkingforInteger(sen))
                {
                    while (!checkingforlengthofP(sen) || !checkingforInteger(sen))
                    {
                        Console.WriteLine("The password is not according to given criteria.");
                        Console.Write("Enter password again: ");
                        sen = Console.ReadLine();
                    }
                }

                if (checkingforspace(sen))
                {
                    while (checkingforspace(sen))
                    {
                        Console.WriteLine("It should not contain space.");
                        Console.Write("Enter again: ");
                        sen = Console.ReadLine();

                    }
                }
            }

            return sen;
        }

        static bool checkingforlengthofP(string sen)
        {
            if (sen.Length != 6)
            {
                return false;
            }
            return true;
        }

        static bool checkingforInteger(string sen)
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

        static string employeemenu()
        {

            string employeechoice;
            Console.WriteLine();
            Console.WriteLine("Enter one of the following options number...");
            Console.WriteLine("1. \t View List Of Clothes");
            Console.WriteLine("2. \t Add an item of Clothing");
            Console.WriteLine("3. \t Update an item Of Clothing");
            Console.WriteLine("4. \t Delete an item of Clothing");
            Console.WriteLine("5. \t Log out");
            Console.Write("Enter your choice: ");
            employeechoice = Console.ReadLine();
            return employeechoice;
        }

        static int takeNumberOfClothes()
        {
            int number=0; string temp;
            Console.Write("Enter The Number Of Clothes You Want To Add: ");
            temp = Console.ReadLine();
            number = validateInt(temp, number);
            return number;

        }

        static int validateInt(string temp, int number)
        {
            do
            {
                
                if (int.TryParse(temp, out number) && number>=0)
                {
                    return number;
                }
                else
                {
                    Console.Write("Invalid input. Please enter a valid number: ");
                    temp = Console.ReadLine() ;
                }


            } while (!int.TryParse(temp, out number) && number>=0);

            return number;
        }

        static float validateFloat(string temp, float number)
        {
            do
            {

                if (float.TryParse(temp, out number) && number >= 0)
                {
                    return number;
                }
                else
                {
                    Console.Write("Invalid input. Please enter a valid number: ");
                    temp = Console.ReadLine();
                }


            } while (!float.TryParse(temp, out number) && number >= 0);

            return number;
        }

        static void AddItem(List <Clothes> ClothesInfo, int number)
        {
            string name, temp;
            float price1=0;
            int available1=0;

            for(int i=0; i<number; i++)
            {
                Console.Write("Enter " + (i + 1) + " Name: ");
                name = Console.ReadLine();
                name = restrictnewNameforCloth(name);
                Console.Write("Enter " + (i + 1) + " Price: ");
                temp = Console.ReadLine();
                price1 = validateFloat(temp, price1);
                Console.Write("Enter " + (i + 1) + " Quantity: ");
                temp = Console.ReadLine();
                available1 = validateInt(temp, available1);
                Console.WriteLine();

                Clothes c1 = new Clothes(name, price1, available1);
                ClothesInfo.Add(c1);
            }
        }

        static void changeItem(List<Clothes> ClothesInfo, int index)
        {
            string name, temp;
            float price1 = 0;
            int available1 = 0;

            Console.Write("Enter " + (index + 1) + " Name: ");
            name = Console.ReadLine();
            name = restrictnewNameforCloth(name);
            Console.Write("Enter " + (index + 1) + " Price: ");
            temp = Console.ReadLine();
            price1 = validateFloat(temp, price1);
            Console.Write("Enter " + (index + 1) + " Quantity: ");
            temp = Console.ReadLine();
            available1 = validateInt(temp, available1);

            ClothesInfo[index].nameOfCloth = name;
            ClothesInfo[index].price = price1;
            ClothesInfo[index].available = available1;
        }

        static void displayClothes(List <Clothes> ClothesInfo)
        {
            Console.WriteLine("Index \t\t Name \t\t\t Price \t\t\t Available Quantity");
            for (int i = 0; i < ClothesInfo.Count; i++)
            {
                Console.WriteLine((i + 1) + "\t\t" + ClothesInfo[i].nameOfCloth + "\t\t Rs" + ClothesInfo[i].price + "\t\t\t" + ClothesInfo[i].available);
            }
        }

        static string customermenu()
        {
            string customerchoice;
            Console.WriteLine();
            Console.WriteLine("Enter one of the following options number");
            Console.WriteLine("1. \t View List Of Clothes");
            Console.WriteLine("2. \t View Cart");
            Console.WriteLine("3. \t View The Bill");
            Console.WriteLine("4. \t Pay The Bill");
            Console.WriteLine("5. \t Log out");
            Console.Write("Enter your choice: ");
            customerchoice = Console.ReadLine();
            return customerchoice;
        }

        static int selectItem(List <Clothes> ClothesInfo)
        {
            int index = 0;
            string temp;
            displayClothes(ClothesInfo);
            Console.WriteLine();
            Console.Write("Enter their Index: ");
            temp = Console.ReadLine();
            index = validateInt(temp, index);
            return index;

        }

        static string restrictnewNameforCloth(string sen)
        {
            while (checkforEmpty(sen) || checkingForcomma(sen))
            {
                if (checkforEmpty(sen))
                {
                    while (checkforEmpty(sen))
                    {
                        Console.WriteLine("It must not be empty.");
                        Console.Write("Enter again: ");
                        sen = Console.ReadLine();
                        
                    }

                }
                if (checkingForcomma(sen))
                {
                    while (checkingForcomma(sen))
                    {
                        Console.WriteLine("It must not contain a comma.");
                        Console.Write("Enter again: ");
                        sen= Console.ReadLine();
                    }
                }
            }

            return sen;
        }

        static void BuyClothes(List <Clothes> ClothesInfo, List <CustomerCloth> customerCloths, int index)
        {
            int quantity=0;
            string temp;
            Console.Write("Enter the Quantity for {0}: ", ClothesInfo[index].nameOfCloth);
            temp = Console.ReadLine();
            quantity = validateInt(temp, quantity);
            quantity = restrictQuantity(quantity, temp, ClothesInfo, index);
            customerCloths.Add(MakeChanges(quantity, ClothesInfo, index));
        }

        static CustomerCloth MakeChanges(int quantity, List<Clothes> ClothesInfo, int index)
        {
            CustomerCloth customerCloth = new CustomerCloth();
            customerCloth.nameOfCloth = ClothesInfo[index].nameOfCloth;
            customerCloth.price = ClothesInfo[index].price;
            customerCloth.available = quantity;
            return customerCloth;
        }

        static int restrictQuantity(int quantity, string temp, List<Clothes> ClothesInfo,int index)
        {
            if ((quantity > ClothesInfo[index].available || quantity < 0))
            {

                while ((quantity > ClothesInfo[index].available || quantity < 0))
                {
                    Console.WriteLine("Not Possible..");
                    Console.WriteLine("Enter again: ");
                    temp = Console.ReadLine ();
                    quantity = validateInt(temp, quantity);
                }
            }
            return quantity;
        }

        static string take1or0(List<CustomerCloth> customerCloths)
        {
            string answer;
            float total = CalculateTotal(customerCloths);
            Console.WriteLine("Your total is Rs {0} ", total);
            Console.WriteLine("Enter 1 to Pay the Bill or Enter any other key to return.");
            Console.Write("Enter your Choice: ");
            answer = Console.ReadLine();
            return answer;
        }


        static void displayCart(List <CustomerCloth> customerCloths)
        {
            Console.WriteLine("Index \t\t Name \t\t\t Price \t\t\t Quantity");
            for (int i = 0; i < customerCloths.Count; i++)
            {
                Console.WriteLine((i + 1) + "\t\t" + customerCloths[i].nameOfCloth + "\t\t Rs" + customerCloths[i].price + "\t\t\t" + customerCloths[i].available);
            }
        }

        static void printBill(List <CustomerCloth> customerCloths)
        {
            displayCart(customerCloths);
            float total = CalculateTotal(customerCloths);
            Console.WriteLine("\t\t" + "\t\t" +"\t\t\t" + "\t\t" + "Total Amount: Rs " + total);
        }

        static void payBill(List <CustomerCloth> customerCloths, List <Clothes> ClothesInfo)
        {
            for(int i=0; i<customerCloths.Count; i++)
            {
                for(int j=0; j<ClothesInfo.Count; j++)
                {
                    if (customerCloths[i].nameOfCloth == ClothesInfo[j].nameOfCloth)
                    {
                        ClothesInfo[j].available -= customerCloths[i].available;
                    }
                }
            }
        }

        static float CalculateTotal(List <CustomerCloth> customerCloths)
        {
            float total = 0;
            for(int i=0; i<customerCloths.Count; i++)
            {
                total += customerCloths[i].price;
            }

            return total;
        }


        static void SaveUsers(List <User> UserDetails) // it saves in file
        {
            string filepath = "C:\\Users\\musno\\OneDrive\\Desktop\\Semester 2\\Object Oriented Programming\\Week 2\\BusinessNew\\UserFile.txt";
            StreamWriter file = new StreamWriter(filepath, false);
            for (int i = 0; i < UserDetails.Count; i++)
            {
                file.WriteLine(UserDetails[i].username + "," + UserDetails[i].password + "," + UserDetails[i].role);
                file.Flush();

            }
            file.Close();
        }

        static void retrieveUsers(List <User> UserDetails) // it retrieves info from the file
        {
            string name, password1, role1;
            string filepath = "C:\\Users\\musno\\OneDrive\\Desktop\\Semester 2\\Object Oriented Programming\\Week 2\\BusinessNew\\UserFile.txt";
            if (File.Exists(filepath))
            {
                StreamReader file = new StreamReader(filepath);
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    
                    name = parsedata(record, 1);
                    password1 = parsedata(record, 2);
                    role1 = parsedata(record, 3);
                    User s = new User(name, password1, role1);
                    UserDetails.Add(s);

                }
            }
        }

        static bool checkforAlreadyBought(List<Clothes> ClothesInfo, List<CustomerCloth> customerCloths, int index)
        {
            for (int i = 0; i < customerCloths.Count; i++)
            {
                if (ClothesInfo[index].nameOfCloth == customerCloths[i].nameOfCloth)
                {
                    return true;
                }
            }

            return false;
        }

        static void SaveClothes(List<Clothes> ClothesInfo) // it saves in file
        {
            string filepath = "C:\\Users\\musno\\OneDrive\\Desktop\\Semester 2\\Object Oriented Programming\\Week 2\\BusinessNew\\ClothesFile.txt";
            StreamWriter file = new StreamWriter(filepath, false);
            for (int i = 0; i < ClothesInfo.Count; i++)
            {
                file.WriteLine(ClothesInfo[i].nameOfCloth + "," + ClothesInfo[i].price + "," + ClothesInfo[i].available);
                file.Flush();

            }
            file.Close();
        }

        static void retrieveClothes(List<Clothes> ClothesInfo) // it retrieves info from the file
        {
            string name;
            float price1; 
            int available1;
            string filepath = "C:\\Users\\musno\\OneDrive\\Desktop\\Semester 2\\Object Oriented Programming\\Week 2\\BusinessNew\\ClothesFile.txt";
            if (File.Exists(filepath))
            {
                StreamReader file = new StreamReader(filepath);
                string record;
                while ((record = file.ReadLine()) != null)
                {

                    name = parsedata(record, 1);
                    price1 = float.Parse(parsedata(record, 2));
                    available1 = int.Parse(parsedata(record, 3));
                    Clothes c = new Clothes(name, price1, available1);
                    ClothesInfo.Add(c);

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
}
