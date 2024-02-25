using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge_1;

namespace Challenge_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ProductsPath = "Product.txt";
            string UserPath = "User.txt";
            string CustomerPath = "Customer.txt";

            ProductDL.ReadProducts(ProductsPath);
            UserDL.ReadUsers(UserPath);
            CustomerDL.ReadCustomers(CustomerPath);


            while (true)
            {

                ConsoleUtility.ClearScreen();
                string Choice = MainUI.MainMenu();
                if(Choice == "1")
                {
                    ConsoleUtility.ClearScreen();
                    UserBL u = UserUI.SigninWindow();
                    string Role = UserDL.GiveUserRole(u);
                    if(Role == "Admin")
                    {
                        while (true)
                        {
                            ConsoleUtility.ClearScreen();
                            string op = AdminUI.AdminMenu();
                            if (op == "1")
                            {
                                ProductBL p = ProductUI.TakeInputForProduct();
                                ProductDL.AddProduct(p);
                                ProductDL.StoreProducts(ProductsPath, p);
                                ConsoleUtility.ReturnForAll();

                            }
                            else if (op == "2")
                            {
                                ProductUI.DisplayProductInformation();
                                ConsoleUtility.ReturnForAll();
                            }
                            else if(op == "3")
                            {
                                ProductBL p = ProductDL.HighestPriceProduct();
                                ProductUI.DisplayProduct(p);
                                ConsoleUtility.ReturnForAll();

                            }
                            else if (op == "4")
                            {
                                ProductUI.DisplayTax();
                                ConsoleUtility.ReturnForAll();
                            }
                            else if (op == "5")
                            {
                                ProductUI.DisplayToBeOrdered();
                                ConsoleUtility.ReturnForAll();
                            }
                            else if (op == "6")
                            {
                                CustomerUI.DisplayCustomerInformation();
                                ConsoleUtility.ReturnForAll();
                            }
                            else if (op == "7")
                            {
                                break;
                            }
                        }
                    }
                    else if(Role == "Customer")
                    {
                        CustomerBL c = CustomerDL.FindCustomer(u); 
                        while (true)
                        {
                            ConsoleUtility.ClearScreen();
                            string op = CustomerUI.CustomerMenu();
                            if (op == "1")
                            {
                                ProductUI.DisplayProductInformation();
                                ConsoleUtility.ReturnForAll();
                            }
                            else if (op == "2")
                            {
                                ConsoleUtility.ClearScreen();
                                string Name = ProductUI.TakeName();
                                ProductBL p = ProductDL.FindProduct(Name);
                                if (p != null)
                                {
                                    int Quantity = ProductUI.TakeQuantity();
                                    if (p.IsAvailableToBuy(Quantity))
                                    {
                                        ProductBL bought = new ProductBL(p);
                                        bought.SetQuantity(Quantity);
                                        p.DropQuantity(Quantity);
                                        c.AddBoughtItem(bought);
                                    }
                                    else
                                    {
                                        CustomerUI.NotPossible();
                                    }
                                }
                                else
                                {
                                    ProductUI.ProductNotFound();
                                }

                                ConsoleUtility.ReturnForAll();

                            }

                            else if (op == "3")
                            {
                                CustomerUI.GenerateInvoice(c);
                                ConsoleUtility.ReturnForAll();

                            }
                            else if ((op == "4"))
                            {
                                CustomerUI.ViewProfile(c);
                                ConsoleUtility.ReturnForAll();
                            }
                            else if (op == "5")
                            {
                                CustomerDL.StoreCustomer(CustomerPath, c);
                                break;
                            }
                        }
                    }
                    else
                    {
                        UserUI.PrintUserNotFound(); 
                    }
                }
                else if(Choice == "2")
                {
                    ConsoleUtility.ClearScreen();
                    UserBL nUser = UserUI.SignupWindow();
                    if(UserDL.IsUserExists(nUser))
                    {
                        UserUI.PrintUserTaken();
                    }
                    else
                    {
                        if(UserDL.AddUser(nUser))
                        {
                            UserDL.StoreUser(UserPath,nUser);
                            CustomerDL.AddCustomers(nUser);
                            UserUI.CongratsforSignup();
                        }
                        else
                        {
                            UserUI.IncorrectRole();
                        }
                        
                    }


                }
                else if (Choice == "3")
                {
                     
                    break;
                }
                
                
            }
        }
    }
}
