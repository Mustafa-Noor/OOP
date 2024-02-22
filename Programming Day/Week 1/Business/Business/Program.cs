using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Threading;
using System.Reflection;

namespace Business
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Credentials
            int range = 30;
            string[] username = new string[range];
            string[] password= new string[range];
            string[] role= new string[range];
            int idx = 0;
            int cusIndex = 0;
            int cardindex=0;

            //Customer Related
            string[] customerArr = new string[range];
            int[,] quantforMen = new int[range,30];
            int[,] quantforWomen= new int[range,30];
            int[] billPaidcount= new int[range];
            int[] totalM= new int[range];
            int[] totalW= new int[range];
            int[] finalTotal= new int[range];
            string[] reviews= new string[range];
            int reviewindex=0;
            string[] customer= new string[range];
            string[] userArea= new string[range];
            int cusCount = 0;
            string[] delivery= new string[range];
            int[] cardno= new int[range];

            //Store Related
            int menq = 0, womenq = 0;
            int areas = 0;
            bool deliveryop = false, delArea = false, billpaid = false;
            string name="", password1="";
            string phoneN = "0423-123456", email = "fashionisu@gmail.com";
            string[] arrM = new string[range];
            int[] priceM= new int[range];
            int[] availableM= new int[range];
            string[] arrW= new string[range];
            int[] priceW= new int[range];
            int[] availableW= new int[range];
            string[] deliveryAreas= new string[range];

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
                
                
                if (op == "1")
                {
                    clearScreen();
                    string role1 = signinMenu(username, password, role, ref cardindex, range, idx, ref reviewindex, cusIndex, customerArr); // recieves role
                    
                    if (role1 == "Employee" || role1 == "employee")
                    {
                        string employeechoice;
                        while (true)
                        {
                            clearScreen();
                            Console.WriteLine();
                            Console.WriteLine("----------Employee Menu-----------");
                            employeechoice = employeemenu();
                            Console.WriteLine();
                            
                            if (employeechoice == "1")
                            {
                                clearScreen();
                                Console.WriteLine();
                                Console.WriteLine("----------Employee Gender Page-----------");
                                string gender = employeeGenderPage();
                                Console.WriteLine();
                                if (gender == "1")
                                {
                                    clearScreen();
                                    Console.WriteLine();
                                    Console.WriteLine("-------------------Employee Male Items-------------------");
                                    employeeMitems(arrM, priceM, availableM, menq);

                                }
                                else if (gender == "2")
                                {
                                    clearScreen();
                                    Console.WriteLine();
                                    Console.WriteLine("-------------------Employee Female Items-------------------");
                                    employeeWitems(arrW, priceW, availableW, womenq);

                                }

                                
                            }
                            

                            if (employeechoice == "2")
                            {
                                clearScreen();
                                Console.WriteLine();
                                Console.WriteLine("----------Employee Gender Page-----------");
                                string gender = employeeGenderPage();
                                Console.WriteLine();
                                if (gender == "1")
                                {
                                    clearScreen();
                                    Console.WriteLine();
                                    Console.WriteLine("-------------------Addition In Male Items-------------------");
                                    addMitem(ref menq, arrM, priceM, availableM);

                                }
                                else if (gender == "2")
                                {
                                    clearScreen();
                                    Console.WriteLine();
                                    Console.WriteLine("-------------------Addition In Female Items-------------------");
                                    addWitem(ref womenq, arrW, priceW, availableW);

                                }

                            }

                            

                            else if (employeechoice == "3")
                            {
                                clearScreen();
                                Console.WriteLine();
                                Console.WriteLine("-------------------Show Reviews-------------------");
                                checkReviews(reviews, customerArr, reviewindex, cusIndex);

                            }

                            else if (employeechoice == "5")
                            {
                                clearScreen();
                                Console.WriteLine();
                                Console.WriteLine("-------------------Change Name-------------------");
                                changeName(menq, womenq, arrM, arrW);

                            }

                            else if (employeechoice == "4")
                            {
                                clearScreen();
                                Console.WriteLine();
                                Console.WriteLine("-------------------Remove Item-------------------");
                                removeItem(ref menq,ref womenq, arrM, arrW, priceM, priceW, availableM, availableW);

                            }

                            else if (employeechoice == "6")
                            {
                                clearScreen();
                                Console.WriteLine();
                                Console.WriteLine("-------------------Our Customers-------------------");
                                seeCustomer(cusIndex, userArea, delivery, customerArr);

                            }

                            
                            else if (employeechoice == "7")
                            {
                                clearScreen();
                                Console.WriteLine();
                                Console.WriteLine("-------------------Change Contact US Information-------------------");
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("Our Contact Number: {0}",phoneN);
                                Console.WriteLine("Our Email Address: {0}", email);
                                Console.WriteLine("------------------------------------");
                                changeInfo(ref phoneN,ref email);

                            }

                            else if (employeechoice == "8")
                            {
                                break;
                            }

                            else
                            {
                                Console.WriteLine("Incorrect Input...");
                            }
                        }
                    }
                    
                    else if (role1 == "Customer" || role1 == "customer")
                    {
                        for (int x = 0; x < menq; x++)
                        {
                            if (quantforMen[cardindex,x] > availableM[x])
                            {
                                quantforMen[cardindex,x] = 0;
                            }
                        }
                        for (int x = 0; x < womenq; x++)
                        {
                            if (quantforWomen[cardindex,x] > availableW[x])
                            {
                                quantforWomen[cardindex,x] = 0;
                            }
                        }
                        
                        string customerchoice;
                        
                        while (true)
                        {
                            clearScreen();
                            Console.WriteLine();
                            Console.WriteLine("----------Customer Menu-----------");
                            customerchoice = customermenu();
                            
                            if (customerchoice == "1")
                            {
                                clearScreen();
                                Console.WriteLine();
                                Console.WriteLine("-------------------Gender Page-------------------");
                                string gender = employeeGenderPage();
                                
                                if (gender == "1")
                                {
                                    clearScreen();
                                    Console.WriteLine();
                                    Console.WriteLine("-------------------Male Items Page-------------------");
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine("Enter your choice: ");
                                    for (int idx1 = 0; idx1 < menq; idx1++)
                                    {   // print men items
                                        if (availableM[idx1] == 0)
                                        {
                                            Console.Write($"{(idx1 + 1).ToString()}. ", -12);
                                            Console.Write($"{arrM[idx1],-25}");
                                            Console.Write($"{" Rs " + priceM[idx1].ToString(),-20}");
                                            Console.Write("\t (Out of Stock)");
                                        }
                                        else
                                        {
                                            Console.Write($"{(idx1 + 1).ToString()}. ", -12);
                                            Console.Write($"{arrM[idx1],-25}");
                                            Console.WriteLine($"{" Rs " + priceM[idx1].ToString(),-20}");

                                        }
                                    }
                                    Console.WriteLine();
                                    printMitems(availableM,ref menq, cardindex, quantforMen);

                                }
                                else if (gender == "2")
                                {
                                    clearScreen();
                                    Console.WriteLine();
                                    Console.WriteLine("-------------------Women Items Page-------------------");
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine("Enter your choice: ");
                                    for (int idx1 = 0; idx1 < womenq; idx1++)
                                    {   // print women items
                                        if (availableW[idx1] == 0)
                                        {
                                            Console.Write($"{(idx1 + 1).ToString()}. ", -12);
                                            Console.Write($"{arrW[idx1],-25}");
                                            Console.Write($"{" Rs " + priceW[idx1].ToString(),-20}");
                                            Console.Write("\t (Out of Stock)");
                                        }
                                        else
                                        {
                                            Console.Write($"{(idx1 + 1).ToString()}. ", -12);
                                            Console.Write($"{arrW[idx1],-25}");
                                            Console.WriteLine($"{" Rs " + priceW[idx1].ToString(),-20}");
                                        }
                                    }
                                    printWitems(availableW, ref womenq, cardindex, quantforWomen);

                                }
                               
                            }
                            
                            
                            
                            else if (customerchoice == "2")
                            {
                                clearScreen();
                                Console.WriteLine();
                                Console.WriteLine("----------------------Cart-----------------------");
                                Console.WriteLine();
                                Console.WriteLine("{0,-25} {1,-20}", "Item", "Quantity");
                                cart(arrM, arrW, menq, womenq, cardindex, quantforMen, quantforWomen);

                            }
                            else if (customerchoice == "3")
                            {
                                clearScreen();
                                Console.WriteLine();
                                Console.WriteLine("----------------------Select Delivery Area-----------------------");
                                Console.WriteLine();
                                for (int idx1 = 0; idx1 < areas; idx1++)
                                {
                                    Console.WriteLine($"{idx1 + 1}. {deliveryAreas[idx1]}");
                                }
                                deliveryArea(areas, deliveryAreas, userArea, ref delArea, cardindex);

                            }
                            
                            else if (customerchoice == "6")
                            {
                                billpaid = false;
                                break;
                            }
                            else if (customerchoice == "4")
                            {
                                clearScreen();
                                Console.WriteLine();
                                Console.WriteLine("----------------------Leave a Review-----------------------");
                                Console.WriteLine();
                                Console.WriteLine();
                                leaveReview(reviews, ref reviewindex, cardindex);

                            }
                            else if (customerchoice == "5")
                            {
                                clearScreen();
                                Console.WriteLine();
                                Console.WriteLine("----------------------Contact Us-----------------------");
                                Console.WriteLine();
                                Console.WriteLine();
                                contactForCustomer(phoneN, email);

                            }

                            

                            else
                            {
                                Console.WriteLine("Incorrect Input..");
                            }
                        
                        }
                        
                    }
                    
                }
                
                else if (op == "2")
                {
                    clearScreen();
                    string role1 = signupMenu(username, ref name, ref password1, range); //recieves role from signupMenu()
                    
                    if ((role1 == "Employee") || (role1 == "Customer") || (role1 == "employee") || (role1 == "customer"))
                    {
                        if (role1 == "Customer" || role1 == "customer")
                        {
                            customer[cusCount] = name;
                            cusCount++;
                        }

                        if (role1 == "customer")
                        {
                            role1 = "Customer";
                        }
                        else if (role1 == "employee")
                        {
                            role1 = "Employee";
                        }
                        role[idx] = role1;
                        username[idx] = name;
                        password[idx] = password1;
                        idx++;

                        if (role1 == "Customer")
                        {
                            customerArr[cusIndex] = name; //puts name in customerArr
                            cusIndex++;
                        }

                        congratsforSignup();
                    }
                    else
                    {
                        Console.WriteLine("Incorrect role...");
                        
                    }
                    
                }
                    

                else if (op == "3")
                {
                    // saving records 
                    break;
                }

                else
                {
                    Console.WriteLine("Incorrect Input...");
                }
            }
        }

        static void printHeader()
        {

            Console.WriteLine( "%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% " );
            Console.WriteLine( "%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% " );
            Console.WriteLine( "%%%%%%%%%%%%% #######   #####    #####   ##   ##  ######   #####   ###  ##      ######   #####       ##   ## %%%%%%%%%%%%% " );
            Console.WriteLine( "%%%%%%%%%%%%%  ##  ##  ##   ##  ##   ##  ##   ##    ##    ##   ##  #### ##        ##    ##   ##      ##   ## %%%%%%%%%%%%% " );
            Console.WriteLine( "%%%%%%%%%%%%%  ##      ##   ##  ##       ##   ##    ##    ##   ##  #######        ##    ##           ##   ## %%%%%%%%%%%%% " );
            Console.WriteLine( "%%%%%%%%%%%%%  ####    #######   #####   #######    ##    ##   ##  ## ####        ##     #####       ##   ## %%%%%%%%%%%%% " );
            Console.WriteLine( "%%%%%%%%%%%%%  ##      ##   ##       ##  ##   ##    ##    ##   ##  ##  ###        ##         ##      ##   ## %%%%%%%%%%%%% " );
            Console.WriteLine( "%%%%%%%%%%%%%  ##      ##   ##  ##   ##  ##   ##    ##    ##   ##  ##   ##        ##    ##   ##      ##   ## %%%%%%%%%%%%% " );
            Console.WriteLine( "%%%%%%%%%%%%% ####     ##   ##   #####   ##   ##  ######   #####   ##   ##      ######   #####        #####  %%%%%%%%%%%%% " );
            Console.WriteLine( "%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% " );
            Console.WriteLine( "%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% " );
        }

        static void contactForCustomer(string phoneN, string email)
        {
            Console.WriteLine("Our Contact Number: ");
            Console.WriteLine("Our Email Address: ");
            Console.WriteLine("------------------------------------");

            returnforAll();
        }

        //prints the customer Menu
        static string customermenu()
        {
            string customerchoice;
            Console.WriteLine();
            Console.WriteLine("Enter one of the following options number");
            Console.WriteLine("1. \t View List Of Clothes");
            Console.WriteLine("2. \t View Cart");
            Console.WriteLine("3. \t Select Delivery Area");
            Console.WriteLine("4. \t Leave a review");
            Console.WriteLine("5. \t Contact Us ");
            Console.WriteLine("6. \t Log out");
            Console.Write("Enter your choice: ");
            customerchoice = Console.ReadLine();
            return customerchoice;
        }

        static string reviews1()
        {
            string review1;
            Console.WriteLine();
            Console.WriteLine( "Leave a review: ");
            review1 = Console.ReadLine();
            return review1;
        }
        // this function accepts the review and adds into reviews array
        static void leaveReview(string[] reviews,ref int reviewindex, int cardindex)
        {
            string review;
            review = reviews1();
            reviews[cardindex] = review;
            reviewindex++;
            Console.WriteLine("Your review has been submitted successfully!");
            returnforAll();
        }

        static string takeDelArea()
        {
            string choice;
           Console.WriteLine( "Select One of the delivery Areas: ");
           Console.WriteLine( "Enter Choice" );
            choice= Console.ReadLine();
            return choice;
        }

        static void deliveryArea(int areas, string[] deliveryAreas, string[] userArea, ref bool delArea, int cardindex)
        {
            string convert = takeDelArea();
            int choice = int.Parse(convert);
            if (choice > 0 && choice <= areas)
            {
                for (int idx = 0; idx < areas; idx++)
                {
                    if (choice == idx + 1)
                    {
                        userArea[cardindex] = deliveryAreas[idx];
                        delArea = true;
                    }
                }
            }
            else
            {
                Console.WriteLine("Incorrect Area...");
                Thread.Sleep(300);
            }
            returnforAll();
        }

        // prints Men items for customers
        static void printMitems(int[] availableM,ref int menq, int cardindex, int[,] quantforMen)
        {
            string convert = takeitem();
            int men = int.Parse(convert);

            if (men > 0 && men <= menq)
            {
                for (int idx = 0; idx < menq; idx++)
                {
                    if (men == idx + 1)
                    {
                        if (availableM[idx] != 0 && quantforMen[cardindex,idx] == 0)
                        {
                            string convert1 = takeQuantityforMen(men, availableM, idx); // variables for validation
                            int quantity = int.Parse(convert1);
                            quantity = restrictQforMen(quantity, availableM, idx, convert1);
                            quantforMen[cardindex, idx] = quantity;
                        }
                        else if (quantforMen[cardindex, idx] != 0)
                        {
                            Console.WriteLine("Already bought.."); // if the items is already bought 
                            Thread.Sleep(300);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Not Possible...");
                            Thread.Sleep(300);
                            break;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Incorrect Input...");
                Thread.Sleep(200);
            }


          
            returnforAll();
        }

        // prints cart for customers
        static void cart(string[] arrM, string[] arrW, int menq, int womenq, int cardindex, int[,] quantforMen, int[,] quantforWomen)
        {
            for (int idx = 0; idx < menq; idx++)
            {
                if (quantforMen[cardindex,idx] != 0 && quantforMen[cardindex,idx] <= 1000)
                {
                    
                    
                        Console.WriteLine($"{arrM[idx],-25} {quantforMen[cardindex, idx],-22}");
                    
                }
            }
            for (int idx = 0; idx < womenq; idx++)
            {
                if (quantforWomen[cardindex,idx] != 0 && quantforWomen[cardindex,idx] <= 1000)
                {
                    
                   
                        Console.WriteLine($"{arrW[idx],-25} {quantforWomen[cardindex, idx],-22}");
                    
                }
            }
            Console.WriteLine();
            returnforAll();
        }

        static string takeQuantityforMen(int men, int[] availableM, int idx)
        {
            string quantity;
            Console.WriteLine("Available pieces: " + availableM[idx]);
            Console.Write("Enter Quantity of " + men + " : ");
            quantity = Console.ReadLine();
            return quantity;
        }

        static int restrictQforMen(int quantity, int[] availableM, int idx, string convert)
        {

            if (quantity > availableM[idx] || quantity < 0 || !checkingforInteger(convert))
            {
                while (quantity > availableM[idx] || quantity < 0 || !checkingforInteger(convert))
                {
                    Console.WriteLine("Not Possible..");
                    Console.Write("Enter again: ");
                    convert = Console.ReadLine();
                    quantity = int.Parse(convert);
                }
            }
            return quantity;
        }

        static string takeitem()
        {
            string item;
            Console.WriteLine( "Enter number: ");
            item = Console.ReadLine();
            return item;
        }

        // print Women items for customers
        static void printWitems(int[] availableW, ref int womenq, int cardindex, int[,] quantforWomen)
        {

            string convert = takeitem(); // variable convert for validation
            int women = int.Parse(convert);

            if (women > 0 && women <= womenq)
            {
                for (int idx = 0; idx < womenq; idx++)
                {
                    if (women == idx + 1)
                    {
                        if (availableW[idx] != 0 && quantforWomen[cardindex,idx] == 0)
                        {
                            string convert1 = takeQuantityforWomen(women, availableW, idx); // variable for validation
                            int quantity = int.Parse(convert1);
                            quantity = restrictQforWomen(quantity, availableW, idx, convert1);
                            quantforWomen[cardindex,idx] = quantity;
                        }
                        else if (quantforWomen[cardindex,idx] != 0)
                        {
                            Console.WriteLine("Already bought.."); // if the items is already bought 
                            Thread.Sleep(300);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Not Possible...");
                            Thread.Sleep(300);
                            break;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine( "Incorrect Input...");
                Thread.Sleep(200);
            }


            returnforAll();
        }

        static int restrictQforWomen(int quantity, int[] availableW, int idx, string convert)
        {

            if (quantity > availableW[idx] || quantity < 0 || !checkingforInteger(convert))
            {
                while (quantity > availableW[idx] || quantity < 0 || !checkingforInteger(convert))
                {
                    Console.WriteLine("Not Possible..");
                    Console.Write("Enter again: ");
                    convert = Console.ReadLine();
                    quantity = int.Parse(convert);
                }
            }
            return quantity;
        }

        static string takeQuantityforWomen(int women, int[] availableW, int idx)
        {
            string quantity;
            Console.WriteLine("Available pieces: " + availableW[idx]);
            Console.Write("Enter Quantity of " + women + " : ");
            quantity = Console.ReadLine();
            return quantity;
        }

        static void employeeMitems(string[] arrM, int[] priceM, int[] availableM, int menq)
        {
            Console.WriteLine($"{"Index"}. {"Name",-25} {"Price",-20} {"Available Articles",-20}");

            for (int idx = 0; idx < menq; idx++)
            {
                string name = arrM[idx];
                string price = "Rs " + priceM[idx].ToString();
                int availableArticles = availableM[idx];

                Console.WriteLine($"{idx + 1}. {name,-25} {price,-20} {availableArticles,-20}");
            }
            returnforAll();
        }

        static void employeeWitems(string[] arrW, int[] priceW, int[] availableW, int womenq)
        {
            Console.WriteLine($"{"Index"}. {"Name",-25} {"Price",-20} {"Available Articles",-20}");

            for (int idx = 0; idx < womenq; idx++)
            {
                string name = arrW[idx];
                string price = "Rs " + priceW[idx].ToString();
                int availableArticles = availableW[idx];

                Console.WriteLine($"{idx + 1}. {name,-25} {price,-20} {availableArticles,-20}");
            }
            returnforAll();
        }
        static string employeeGenderPage()
        {
            string gender;
            Console.WriteLine();
            Console.WriteLine("Enter the gender.");
            Console.WriteLine("1. \t Men");
            Console.WriteLine("2. \t Women");
            Console.WriteLine();
            Console.WriteLine("Press any other key to return.");
            Console.Write("Enter your choice: ");
            gender = Console.ReadLine();
            return gender;
        }

        // it takes input from the employee regarding changes in contact info
        static void setContactInfo(ref string phoneN,ref string email)
        {
            Console.WriteLine("Enter new Contact Number: ");
            phoneN = Console.ReadLine();
            if (checkingForcomma(phoneN))
            {
                while (checkingForcomma(phoneN))
                {
                    Console.WriteLine("It should not contain comma.");
                    Console.Write("Enter again: ");
                    phoneN= Console.ReadLine();
                }

            }
            Console.Write("Enter new Email Address: ");
            email = Console.ReadLine();

            while (checkingforspace(email))
            {
                if (checkingforspace(email)) // validatory restrictions
                {
                    while (checkingforspace(email))
                    {
                        Console.WriteLine("It should not contain spaces. ");
                        Console.Write("Enter again: ");
                        email = Console.ReadLine();
                    }
                }
                
            }
            Console.WriteLine("Info updated.");
        }

        static string takeChoiceForContact()
        {
            string answer;
            Console.WriteLine("Press 1 to change the Contact Information.");
            Console.WriteLine("Enter any other string to return.");
            Console.Write("Enter your choice: ");
            answer = Console.ReadLine();
            return answer;
        }
        static void changeInfo(ref string phoneN,ref string email) // it changes the contact info as taken from the employee
        {
            string answer = takeChoiceForContact();
            if (answer == "1")
            {
                setContactInfo(ref phoneN,ref email);
            }
            else
            {
                Thread.Sleep(300);
            }
            returnforAll();
        }

        static void seeCustomer(int cusIndex, string[] userArea, string[] delivery, string[] customerArr)
        {
            if (cusIndex != 0)
            {
                int counter = 1;
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine( "These are the Customers: ");
                Console.WriteLine();
                Console.WriteLine("{0,-12} {1,-20} {2,-20} {3,-20}", "Index", "Username", "Address", "Method");
                Console.WriteLine();
                showCustomersList(cusIndex, userArea, delivery, customerArr, ref counter);
            }

            else
            {
               Console.WriteLine();
                Console.Write("There are no Customers yet.");
            }

            returnforAll();
        }

        // it shows the list of customers with their details
        static void showCustomersList(int cusIndex, string[] userArea, string[] delivery, string[] customerArr,ref int counter)
        {
            for (int idx = 0; idx < cusIndex; idx++)
            {
                string username = customerArr[idx];
                string area = userArea[idx] != "" ? userArea[idx] : "Not Selected";
                string deliveryMethod = delivery[idx] != "" ? delivery[idx] : "Not Selected";

                Console.WriteLine($"{counter}. {username,-20} {area,-20} {deliveryMethod,-20}");

                counter++;
            }
        }

        static void removeItem(ref int menq, ref int womenq, string[] arrM, string[] arrW, int[] priceM, int[] priceW, int[] availableM, int[] availableW)
        {
            string convert = takeName(menq, womenq, arrM, arrW);
            int remove = int.Parse(convert);
            if (remove > 0 && remove <= menq) // separates men item
            {

                for (int var = remove - 1; var < menq; var++)
                {
                    arrM[var] = arrM[var + 1];
                    priceM[var] = priceM[var + 1];
                    availableM[var] = availableM[var + 1];
                }
                Console.WriteLine("Item Succesfully deleted.");

                menq = menq - 1;
            }
            else if (remove > menq && remove <= (menq + womenq)) // separates women items
            {

                for (int var = remove - 1 - menq; var < womenq; var++)
                {
                    arrW[var] = arrW[var + 1];
                    priceW[var] = priceW[var + 1];
                    availableW[var] = availableW[var + 1];
                }
                Console.WriteLine("Item Succesfully deleted.");
                womenq = womenq - 1;
            }
            else
            {
                Console.WriteLine("Not a correct option.");
                Thread.Sleep(300);
            }
            returnforAll();
        }

        // this function calls other functions and makes the necessary changes regarding name changing
        static void changeName(int menq, int womenq, string[] arrM, string[] arrW)
        {
            string convert = takeName(menq, womenq, arrM, arrW);
            int change = int.Parse(convert);
            if (change > 0 && change <= menq) // seperates men items
            {
                int var = change - 1;
                for (int idx = 0; idx < menq; idx++)
                {
                    if (var == idx)
                    {
                        newNameforMen(idx, var, arrM);
                    }
                }
            }
            else if (change > menq && change <= (menq + womenq)) // seperated women items
            {
                int var = change - 1 - menq;
                for (int idx = 0; idx < womenq; idx++)
                {
                    if (var == idx)
                    {
                        newNameforWomen(idx, var, arrW);
                    }
                }
            }
            else
            {
                Console.WriteLine("Not a correct option.");
                Thread.Sleep(300);
            }

            returnforAll();
        }

        static void newNameforMen(int idx, int var, string[] arrM) // it takes the new name for men
        {
            Console.Write("Enter new name for " + arrM[idx] + ": ");
            arrM[var] = Console.ReadLine();
            Console.WriteLine("Name succesfully changed.");
        }

        static void newNameforWomen(int idx, int var, string[] arrW) //  it takes the new name for women
        {
            Console.WriteLine("Enter new name for " + arrW[idx] + ": ");
            arrW[var] = Console.ReadLine();
            Console.WriteLine("Name succesfully changed.");
        }

        static string takeName(int menq, int womenq, string[] arrM, string[] arrW)
        {
            for (int idx = 0; idx < menq; idx++)
            {
                Console.WriteLine($"Item no: {idx + 1}. {arrM[idx]}"); //print amen items
            }
            for (int idx = 0; idx < womenq; idx++)
            {
                Console.WriteLine($"Item no: {idx + 1+menq}. {arrW[idx]}");// print women items
            }
            Console.WriteLine("Select the item ...");
            Console.WriteLine();
            string change;
            Console.Write("Enter item no. : ");
            change= Console.ReadLine();
            return change;
        }

        static void addWitem(ref int womenq, string[] arrW, int[] priceW, int[] availableW)
        {
            int number = takeNumToAdd();
            string name;
            int price;
            int available;
            int counter = 1;
            int a = womenq;
            womenq = number + womenq;
            for (int idx = a; idx < womenq; idx++)
            {
                name = takeNametoAdd(counter);
                string convertprice = takePricetoAdd();
                price = int.Parse(convertprice);
                  //these are for validation
                string convertstock = takeQStockToAdd();
                available = int.Parse(convertstock);
                Console.WriteLine();
                Console.WriteLine();

                arrW[idx] = name;
                priceW[idx] = price;            // these are the addition in arrays
                availableW[idx] = available;
                counter++;
            }

            returnforAll();
        }

        // this function shows reviews to the employeer and is called in check reviews function
        static void showreviews(string[] reviews, string[] customerArr,ref int counter, int cusIndex)
        {
            for (int idx = 0; idx <= cusIndex; idx++)
            {
                if (reviews[idx] != "")
                {
                    Console.WriteLine(counter + ". Review by " + customerArr[idx] + ": ");
                    Console.WriteLine("\t" + reviews[idx]);
                    Console.WriteLine();
                    counter++;
                }
            }
        }
        // these fucntion shows reviews or tells that none exist
        static void checkReviews(string[] reviews, string[] customerArr, int reviewindex, int cusIndex)
        {
            int counter = 1;
            if (reviewindex != 0)
            {
                showreviews(reviews, customerArr,ref counter, cusIndex);
            }

            else
            {
                Console.WriteLine() ;
                Console.WriteLine( "There are no reviews yet.");
            }

            returnforAll();
        }


        static void addMitem(ref int menq, string[] arrM, int[] priceM, int[] availableM)
        {
            int number = takeNumToAdd();
            string name;
            int price;
            int available;
            int counter = 1;

            int a = menq;
            menq = number + menq;

            for (int idx = a; idx < menq; idx++)
            {
                name = takeNametoAdd(counter);
                string convertprice = takePricetoAdd();
                price = int.Parse(convertprice);
                 //these are for validation
                string convertstock = takeQStockToAdd();
                available = int.Parse(convertstock);
                Console.WriteLine();
                Console.WriteLine();
                arrM[idx] = name;
                priceM[idx] = price;        // these are the addition in arrays
                availableM[idx] = available;
                counter++;
            }

            returnforAll();
        }

        static void returnforAll() //this is used as a return function for all functions
        {
            Console.WriteLine("Press any key to return...");
            Console.Read();
        }

        // it validates the quantity
        static int makeQStockAccordingtoCriteria(int available, string convertstock)
        {
            if (!(available >= 0) || !checkingforInteger(convertstock))
            {

                while (!(available > 0) || !checkingforInteger(convertstock))
                {
                    Console.WriteLine("Not according to criteria.");
                    Console.Write("Enter quantity again: ");
                    convertstock= Console.ReadLine();
                    available = int.Parse(convertstock);
                }
            }
            return available;
        }

        // it takes quantity for the added item
        static string takeQStockToAdd()
        {
            string available;
            Console.WriteLine("Enter its quantity : ");
            available=Console.ReadLine();
            return available;
        }

        static int makePriceAccordingToCriteria(int price, string convertprice)
        {
            if (!(price > 0) || !checkingforInteger(convertprice))
            {
                while (!(price >= 0) || !checkingforInteger(convertprice))
                {
                    Console.WriteLine("Not according to criteria.");
                    Console.Write("Enter price again: ");
                    convertprice=Console.ReadLine();
                    price = int.Parse(convertprice);
                }
            }
            return price;
        }

        static string takePricetoAdd()
        {
            string price;
            Console.WriteLine("Enter its price : ");
            price= Console.ReadLine();
            return price;
        }

        static string takeNametoAdd(int counter)
        {
            string name;
            Console.Write("Enter the name of the " + counter + " article: ");
            name = Console.ReadLine();
            return name;
        }
        static int takeNumToAdd()
        {
            string convert;
            Console.Write("Enter the number of articles to add (Must not be greater than 5): ");
            convert= Console.ReadLine();
            int number = int.Parse(convert);
            if (number > 5 || number <= 0)
            {
                while (number > 5 || number <= 0)            // this loop is for validation
                {
                    Console.WriteLine("Not Possible..");
                    Console.Write("Enter again: ");
                    convert = Console.ReadLine(); 
                    number = int.Parse(convert);
                }
            }

            return number;
        }

        static string signinMenu(string[] username, string[] password, string[] role,ref int cardindex, int range, int idx,ref int reviewindex, int cusIndex, string[] customerArr)
        {
            string name="";
            string password1="";
            string role1="";
            int index;
            signinWindow(ref name, ref password1);
            if (checkUser(name, username, range))
            {
                index = usernameInd(name, idx, username);
                cardindex = findCustomerIndex(name, cusIndex, customerArr);
                reviewindex = index;
                if (password1 == password[index])
                {
                    role1 = role[index];
                    congratsforSignin();
                }
                else
                {
                    Console.WriteLine( "User Not Found.");
                    Thread.Sleep(300);
                }
            }
            else
            {
                Console.WriteLine("User does not exist.");
                Thread.Sleep(300);
            }

            return role1;
        }

                
        static string employeemenu()
        {

            string employeechoice;
            Console.WriteLine();
            Console.WriteLine("Enter one of the following options number...");
            Console.WriteLine("1. \t View List Of Clothes");
            Console.WriteLine("2. \t Add an item of Clothing");
            Console.WriteLine("3. \t Check Reviews");
            Console.WriteLine("4. \t Delete an item of Clothing");
            Console.WriteLine("5. \t Change Name of an Item");
            Console.WriteLine("6. \t See Current Customers");
            Console.WriteLine("7. \t Change Contact Us Information");
            Console.WriteLine("8. \t Log out");
            Console.Write("Enter your choice: ");
            employeechoice= Console.ReadLine();
            return employeechoice;
        }
        
        static void congratsforSignup()
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine();
            Console.WriteLine("You have successfully signed up.");
            Console.WriteLine("Press any key to continue...");
            Console.Read();
        }

        static void congratsforSignin()
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine();
            Console.WriteLine("You have successfully signed in.");
            Console.WriteLine("Press any key to continue...");
            Console.Read();
        }

        // finds the customer index from their name
        static int findCustomerIndex(string name, int cusIndex, string[] customerArr)
        {
            for (int x = 0; x < cusIndex; x++)
            {
                if (name == customerArr[x])
                {
                    return x;
                }
            }

            return -1;
        }

        // finds the user index from their name
        static int usernameInd(string name, int idx, string[] username)
        {
            for (int x = 0; x < idx; x++)
            {
                if (name == username[x])
                {
                    return x;
                }
            }
            return -1;
        }

        // verifies if the user exist or not
        static bool checkUser(string name, string[] username, int range)
        {
            for (int x = 0; x < range; x++)
            {
                if (name == username[x])
                {
                    return true;
                }
            }
            return false;
        }

        static void signinWindow(ref string name, ref string password1)
        {
            Console.WriteLine();
            Console.WriteLine("--------Sign In----------");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Enter Username: ");
            name = Console.ReadLine();
            if(checkingforspace(name))
            {
                Console.WriteLine("It should nnot contain space.");
                Console.Write("Enter Again: ");
                name = Console.ReadLine();
            }

            Console.Write("Enter Password (6 digits): ");
            password1 = Console.ReadLine();
            password1 = retrictPassword(password1);
            
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
                        sen= Console.ReadLine();
                        
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
            for (int x = 0; x<sen.Length; x++)
            {
                if (sen[x] < '0' || sen[x] > '9')
                {
                    return false;
                }
            }

            return true;
        }

        static string signupMenu(string[] username,ref string name,ref string password1, int range)
        {
            string role1;
            signupWindow(ref name, ref password1);
            if (checkUser(name, username, range))
            {
                Console.WriteLine("Username Already Taken..");
                Thread.Sleep(300);
                clearScreen();
                role1 = "";
            }
            else
            {
                role1 = takeRole();
            }

            return role1;
        }

        static string takeRole()
        {
            string role1;
            Console.Write("Enter Role (Employee or Customer): ");
            role1=Console.ReadLine();
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

        static string signupName(string name)
        {
            while (checkforEmpty(name) || checkingForcomma(name) || checkingforspace(name))
            {
                if (checkforEmpty(name))
                {
                    while (checkforEmpty(name))
                    {
                        Console.WriteLine("It must not be empty." );
                        Console.Write("Enter again: ");
                        name= Console.ReadLine();
                    }
                }

                if (checkingForcomma(name))
                {
                    while (checkingForcomma(name))
                    {
                        Console.WriteLine("It must not contain a comma.");
                        Console.WriteLine("Enter again: ");
                        name=Console.ReadLine(); 
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
            for (int x = 0; x<sen.Length; x++)
            {
                if (sen[x] == ',')
                {
                    return true;
                }
            }
            return false;
        }

        static void clearScreen()
        {
            Console.Clear();
            printHeader();
        }




    }



}



