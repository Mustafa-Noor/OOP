using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FashionIsU.UI;

namespace FashionIsU
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=GREY\\SQLEXPRESS;Initial Catalog=FashionIsU;Integrated Security=True";

            while (true) 
            {
                ConsoleUtility.ClearScreen();
                string Choice = MainUI.MainMenu();
                if (Choice == "1")
                {
                   ConsoleUtility.ClearScreen();
                   UserBL u =  UserUI.SignInWindow();
                    if (UserDL.FindUser(u) != null)
                    {
                        UserBL user = UserDL.FindUser(u);
                        if (user.GetRole() == "Customer" && (CustomerDL.FindCustomer(user) != null))
                        {
                            CustomerBL customer = CustomerDL.FindCustomer(user);
                            while(true)
                            {
                                ConsoleUtility.ClearScreen();
                                string choice = CustomerUI.CustomerMenu();
                                if(choice == "1")
                                {
                                        if (ClothesDL.CheckClothes())
                                        {
                                            ConsoleUtility.ClearScreen();
                                            ClothesUI.DisplayAllClothes();
                                            int id = ClothesUI.TakeId();
                                            ClothesBL c = ClothesDL.FindClothByID(id);
                                            if(c!=null && customer.GetCart().FindClothFromCart(id)==null)
                                            {
                                                int quantity = ClothesUI.TakeQuantity();
                                                if(c.IsAvailableToBuy(quantity))
                                                {
                                                    ClothesBL cartItem = new ClothesBL(c);
                                                    cartItem.SetQuantity(quantity);
                                                    c.DropQuantity(quantity);
                                                    customer.GetCart().AddIntoCart(cartItem);
                                                    CartUI.AddedToCart();
                                                }
                                                else
                                                {
                                                    ClothesUI.NotPossible();
                                                }
                                            }
                                            else if (customer.GetCart().FindClothFromCart(id) != null)
                                            {
                                                CartUI.ItemAlreadyBought();
                                            }
                                            else
                                            {
                                                 ClothesUI.IncorrectId();
                                            }
                                        }
                                        else
                                        {
                                            ConsoleUtility.ClearScreen();
                                            ClothesUI.NoClothesFound();
                                        }
                                        ConsoleUtility.ReturnForAll();
                                }
                                else if (choice == "2")
                                {
                                        ConsoleUtility.ClearScreen();
                                        if(customer.GetCart().CheckCart())
                                        {
                                             CartUI.DisplayCart(customer.GetCart().GetCartItems(), customer.GetCart());

                                        }
                                        else
                                        {
                                            CartUI.CartIsEmpty();
                                        }

                                        ConsoleUtility.ReturnForAll();

                                    
                                        

                                }
                                else if (choice == "3")
                                {
                                    ConsoleUtility.ClearScreen();
                                    if (customer.GetCart().CheckCart())
                                    {
                                        CartUI.DisplayCart(customer.GetCart().GetCartItems(), customer.GetCart());
                                        int id = ClothesUI.TakeId();
                                        ClothesBL c = customer.GetCart().FindClothFromCart(id);
                                        if(c!=null)
                                        {
                                            int quantity = c.GetQuantity();
                                            ClothesBL shopItem = ClothesDL.FindClothByID(id);
                                            shopItem.AddQuantity(quantity);

                                            if(customer.GetCart().DelItem(c))
                                            {
                                                CartUI.CartItemDel();
                                            }

                                        }
                                        else
                                        {
                                            
                                            ClothesUI.NoClothesFound();
                                        }

                                    }
                                    else
                                    {
                                        CartUI.CartIsEmpty();
                                    }

                                    ConsoleUtility.ReturnForAll();
                                }
                                else if (choice == "4")
                                {
                                    ConsoleUtility.ClearScreen();
                                    if (customer.GetCart().CheckCart())
                                    {
                                        CartUI.DisplayCart(customer.GetCart().GetCartItems(), customer.GetCart());
                                        int id = ClothesUI.TakeId();
                                        ClothesBL c = customer.GetCart().FindClothFromCart(id);

                                        if (c != null)
                                        {
                                            int currentQuantity = c.GetQuantity();
                                            ClothesBL shopItem = ClothesDL.FindClothByID(id);
                                            shopItem.AddQuantity(currentQuantity);

                                            int quantity = ClothesUI.TakeQuantity();
                                            if (shopItem.IsAvailableToBuy(quantity))
                                            {
                                                c.SetQuantity(quantity);
                                                shopItem.DropQuantity(quantity);
                                                CartUI.CartItemUpdated();
                                            }
                                            else
                                            {
                                                ClothesUI.NotPossible();
                                            }



                                        }
                                        else
                                        {

                                            ClothesUI.NoClothesFound();
                                        }

                                    }
                                    else
                                    {
                                        CartUI.CartIsEmpty();
                                    }
                                    ConsoleUtility.ReturnForAll();
                                }
                                else if (choice == "5")
                                {
                                    ConsoleUtility.ClearScreen();
                                    if(customer.GetCart().CheckCart())
                                    {
                                        PaymentMethodBL p = PaymentMethodUI.TakeTypeOfPayment();
                                        ConsoleUtility.ClearScreen();
                                        OrderBL order = OrderUI.TakeInputForOrder(customer, p);
                                        OrderDL.AddOrder(order);
                                        customer.AddOrderCustomer(order);
                                        customer.ClearCart();
                                        OrderUI.OrderSuccessful();
                                        
                                    }
                                    else
                                    {
                                        CartUI.CartIsEmpty();
                                    }

                                    ConsoleUtility.ReturnForAll();

                                }
                                else if (choice == "6")
                                {
                                    ConsoleUtility.ClearScreen();
                                    if(customer.CheckOrders())
                                    {
                                        OrderUI.DisplayOrders(customer.GetOrderList());
                                    }
                                    else
                                    {
                                        OrderUI.NeverPlaced();
                                    }
                                    ConsoleUtility.ReturnForAll();

                                }
                                else if (choice == "7")
                                {
                                    ConsoleUtility.ClearScreen();
                                    if(ClothesDL.CheckClothes())
                                    {
                                        ConsoleUtility.ClearScreen();
                                        ClothesUI.DisplayAllClothes();
                                        int id = ClothesUI.TakeId();
                                        ClothesBL c = ClothesDL.FindClothByID(id);
                                        ReviewBL rev = ReviewUI.TakeReview(c, customer);
                                        ReviewDL.AddReviews(rev);
                                        c.AddReview(rev);
                                        ReviewUI.ReviewAddedSuccess();
                                    }
                                    else
                                    {
                                        ConsoleUtility.ClearScreen();
                                        ClothesUI.NoClothesFound();
                                    }
                                    ConsoleUtility.ReturnForAll();
                                }
                                else if (choice == "8")
                                {
                                    ConsoleUtility.ClearScreen();
                                    CustomerUI.DisplayTotalAmountSpent(customer);
                                    ConsoleUtility.ReturnForAll();

                                }
                                else if (choice == "9")
                                {
                                    ConsoleUtility.ClearScreen();
                                    CustomerUI.UpdateProfileInput(customer);
                                    CustomerUI.ProfileUpdateSuccess();
                                    ConsoleUtility.ReturnForAll();

                                }
                                else if (choice == "10")
                                {
                                    break;
                                }
                            }
                            
                        }
                        else if (user.GetRole() == "Employee")
                        {
                            if (EmployeeDL.FindEmployee(user) != null)
                            {
                                while (true)
                                {
                                    ConsoleUtility.ClearScreen();
                                    string choice = EmployeeUI.EmployeeMenu();
                                    if (choice == "1")
                                    {
                                        if (ClothesDL.CheckClothes())
                                        {
                                            ConsoleUtility.ClearScreen();
                                            ClothesUI.DisplayAllClothes();
                                        }
                                        else
                                        {
                                            ConsoleUtility.ClearScreen();
                                            ClothesUI.NoClothesFound();
                                        }
                                        ConsoleUtility.ReturnForAll();
                                    }
                                    else if (choice == "2")
                                    {
                                        ConsoleUtility.ClearScreen();
                                        ClothesBL c = ClothesUI.TakeInputForClothes();
                                        ClothesDL.AddClothes(c);
                                        ConsoleUtility.ReturnForAll();
                                    }
                                    else if (choice == "3")
                                    {
                                        if (ClothesDL.CheckClothes())
                                        {
                                            ConsoleUtility.ClearScreen();
                                            ClothesUI.DisplayAllClothes();
                                            int id = ClothesUI.TakeId();
                                            ClothesBL c = ClothesDL.FindClothByID(id);
                                            if(c != null)
                                            {
                                                ConsoleUtility.ClearScreen();
                                                ClothesUI.TakeInputForUpdateClothe(c);
                                                ClothesUI.ClothUpdatedSuccessfully();
                                            }
                                            else
                                            {
                                                ClothesUI.IncorrectId();
                                            }
                                        }
                                        else
                                        {
                                            ConsoleUtility.ClearScreen();
                                            ClothesUI.NoClothesFound();
                                        }
                                        ConsoleUtility.ReturnForAll();
                                    }
                                    else if (choice == "4")
                                    {
                                        if (ClothesDL.CheckClothes())
                                        {
                                            ConsoleUtility.ClearScreen();
                                            ClothesUI.DisplayAllClothes();
                                            int id = ClothesUI.TakeId();
                                            ClothesBL c = ClothesDL.FindClothByID(id);
                                            if (c != null)
                                            {
                                                ConsoleUtility.ClearScreen();
                                                ClothesDL.DeleteCloth(c);
                                                ClothesUI.ClothDeletedSuccessfully();
                                            }
                                            else
                                            {
                                                ClothesUI.IncorrectId();
                                            }
                                        }
                                        else
                                        {
                                            ConsoleUtility.ClearScreen();
                                            ClothesUI.NoClothesFound();
                                        }
                                        ConsoleUtility.ReturnForAll();
                                    }
                                    else if(choice == "5")
                                    {
                                        if(CustomerDL.CheckCustomers())
                                        {
                                            CustomerUI.DisplayCustomers();
                                        }
                                        else
                                        {
                                            ConsoleUtility.ClearScreen();
                                            CustomerUI.NoCustomers();
                                        }
                                        ConsoleUtility.ReturnForAll();
                                    }
                                    else if (choice == "9")
                                    {
                                        break;
                                    }

                                }
                            }
                            else
                            {
                                EmployeeUI.EmployeeNotFound();
                            }

                        }
                        else if (user is EmployeeBL)
                        {
                            Console.WriteLine("Employee it is ");
                        }
                        else
                        {
                            UserUI.PrintUserNotFound();
                        }
                        ConsoleUtility.ReturnForAll();
                    }
                    else
                    {
                        UserUI.PrintUserNotFound();
                        ConsoleUtility.ReturnForAll();
                    }

                }
                else if (Choice == "2")
                {
                    ConsoleUtility.ClearScreen();
                    UserBL u = UserUI.SignUpWindowforUser();
                    if (UserDL.IsUserExists(u))
                    {
                        UserUI.PrintUserTaken();
                    }
                    else
                    {
                        string role = u.GetRole();
                        if (role == "Customer" || role == "customer")
                        {
                            CustomerBL c = CustomerUI.TakeInfoCustomer(u);
                            CustomerDL.AddCustomer(c);
                            UserDL.AddUser(u);
                            UserUI.CongratsforSignup();

                        }
                        else if (role == "Employee" || role == "employee")
                        {
                            EmployeeBL emp = EmployeeUI.TakeInfoForEmployee(u);
                            EmployeeDL.AddEmployee(emp);
                            UserDL.AddUser(u);
                            UserUI.CongratsforSignup();


                        }
                        else if (role == "Admin" || role == "admin")
                        {
                            AdminBL a = AdminUI.TakeInfoAdmin(u);
                            AdminDL.AddAdmin(a);
                            UserDL.AddUser(u);
                            UserUI.CongratsforSignup();
                        }
                        else
                        {
                            UserUI.IncorrectRole();

                        }

                        ConsoleUtility.ReturnForAll();
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
