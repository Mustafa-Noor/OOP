using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FashionIsU;
using FashionIsU.UI;

namespace FashionIsU
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            while (true)
            {
                ConsoleUtility.ClearScreen();
                string Choice = MainUI.MainMenu();
                if (Choice == "1")
                {
                    ConsoleUtility.ClearScreen();
                    string role = UserUI.TakeRole();
                    UserBL u = UserUI.SignInWindow(role);

                    if (UserDL.FindUser(u) != null && role == "customer")
                    {
                        CustomerBL customer = UserDL.FindUser(u) as CustomerBL;
                        if (customer != null)
                        {
                            CartDL.RetrieveCart(customer);
                            customer.SetOrderList(OrderDL.RetrieveOrdersOfCustomer(customer));
                            while (true)
                            {
                                ConsoleUtility.ClearScreen();
                                string choice = CustomerUI.CustomerMenu();
                                if (choice == "1")
                                {
                                    if (ClothesDL.CheckClothes())
                                    {
                                        ConsoleUtility.ClearScreen();
                                        ClothesUI.DisplayAllClothes();
                                        int id = ClothesUI.TakeId();
                                        ClothesBL c = ClothesDL.FindClothByID(id);
                                        if (c != null && customer.GetCart().FindClothFromCart(id) == null)
                                        {
                                            int quantity = ClothesUI.TakeQuantity();
                                            if (c.IsAvailableToBuy(quantity))
                                            {
                                                ClothesBL cartItem = new ClothesBL(c);
                                                cartItem.SetQuantity(quantity);
                                                c.DropQuantity(quantity);
                                                ClothesDL.ChangeQuantity(id, c.GetQuantity());
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
                                    if (customer.GetCart().CheckCart())
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
                                        if (c != null)
                                        {
                                            int quantity = c.GetQuantity();
                                            ClothesBL shopItem = ClothesDL.FindClothByID(id);
                                            shopItem.AddQuantity(quantity);
                                            ClothesDL.ChangeQuantity(id, shopItem.GetQuantity());

                                            if (customer.GetCart().DelItem(c))
                                            {
                                                CartDL.DeleteAnItem(id, customer);
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
                                                CartDL.UpdateQuantity(id, customer, quantity);
                                                shopItem.DropQuantity(quantity);
                                                ClothesDL.ChangeQuantity(id, shopItem.GetQuantity());
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
                                    if (customer.GetCart().CheckCart())
                                    {
                                        PaymentMethodBL p = PaymentMethodUI.TakeTypeOfPayment();
                                        ConsoleUtility.ClearScreen();
                                        OrderBL order = OrderUI.TakeInputForOrder(customer, p);
                                        OrderDL.AddOrder(order);
                                        customer.AddOrderCustomer(order);
                                        customer.ClearCart();
                                        CartDL.EmptyCart(customer);
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
                                    customer.SetOrderList(OrderDL.RetrieveOrdersOfCustomer(customer));

                                    ConsoleUtility.ClearScreen();
                                    if (customer.CheckOrders())
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
                                    if (ClothesDL.CheckClothes())
                                    {
                                        ConsoleUtility.ClearScreen();
                                        ClothesUI.DisplayAllClothes();
                                        int id = ClothesUI.TakeId();
                                        ClothesBL c = ClothesDL.FindClothByID(id);
                                        ReviewBL rev = ReviewUI.TakeReview(c, customer);
                                        ReviewDL.AddReviews(rev,c);
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
                                    UserDL.UpdateProfile(customer);
                                    UserUI.ProfileUpdateSuccess();
                                    ConsoleUtility.ReturnForAll();

                                }
                                else if (choice == "10")
                                {
                                    CartDL.SaveCart(customer.GetCart(), customer);
                                    break;
                                }
                            }
                        }
                        else
                        {
                            CustomerUI.CustomerNotFound();
                            ConsoleUtility.ReturnForAll();
                        }
                    }
                    else if (UserDL.FindUser(u) != null && role == "employee")
                    {
                        EmployeeBL employee = UserDL.FindUser(u) as EmployeeBL;
                        if (employee != null)
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
                                        if (c != null)
                                        {
                                            ConsoleUtility.ClearScreen();
                                            ClothesUI.TakeInputForUpdateClothe(c);
                                            ClothesDL.UpdateCloth(c);
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
                                            if (ClothesDL.DeleteCloth(c))
                                            {
                                                ClothesUI.ClothDeletedSuccessfully();
                                            }
                                            
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
                                else if (choice == "5")
                                {
                                    ConsoleUtility.ClearScreen();
                                    if (UserDL.CheckCustomersCount())
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
                                else if (choice == "6")
                                {
                                    ConsoleUtility.ClearScreen();
                                    if (UserDL.CheckCustomersCount())
                                    {
                                        CustomerUI.DisplayCustomers();
                                        string username = CustomerUI.TakeUsername();
                                        CustomerBL cus = UserDL.FindCustomerByUsername(username);
                                        if (cus != null)
                                        {
                                            cus.SetOrderList(OrderDL.RetrieveOrdersOfCustomer(cus));
                                            OrderUI.DisplayOrders(cus.GetOrderList());
                                        }
                                        else
                                        {
                                            CustomerUI.CustomerNotFound();
                                        }

                                    }
                                    else
                                    {
                                        ConsoleUtility.ClearScreen();
                                        CustomerUI.NoCustomers();
                                    }
                                    ConsoleUtility.ReturnForAll();
                                }
                                else if (choice == "7")
                                {
                                    if (ClothesDL.CheckClothes())
                                    {
                                        ConsoleUtility.ClearScreen();
                                        ClothesUI.DisplayAllClothes();
                                        int id = ClothesUI.TakeId();
                                        ClothesBL c = ClothesDL.FindClothByID(id);
                                        if (c != null)
                                        {
                                            c.SetReviews(ReviewDL.RetrieveReviews(id));
                                            ConsoleUtility.ClearScreen();
                                            ReviewUI.DisplayReview(c);
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
                                else if (choice == "8")
                                {
                                    ConsoleUtility.ClearScreen();
                                   EmployeeUI.UpdateProfileInput(employee);
                                    UserDL.UpdateProfile(employee);
                                    UserUI.ProfileUpdateSuccess();
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
                            ConsoleUtility.ReturnForAll();
                        }
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
                    string role = UserUI.TakeRole();
                    UserBL u = UserUI.CreateUser(role);
                    if (UserDL.IsUserExists(u))
                    {
                        UserUI.PrintUserTaken();
                    }
                    else
                    {
                        if(UserDL.AddUser(u))
                        {
                            UserUI.CongratsforSignup();
                        }

                    }

                    ConsoleUtility.ReturnForAll();


                }
                else if (Choice == "3")
                {
                    break;
                }

            }
        }
    }
}
