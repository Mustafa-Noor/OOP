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
                MainUI.ClearScreen();
                string Choice = MainUI.MainMenu();
                if (Choice == "1")
                {
                    MainUI.ClearScreen();
                    string role = UserUI.TakeRole();
                    UserBL u = UserUI.SignInWindow(role);

                    if (UserDL.FindUser(u) != null && role == "customer")
                    {
                        UserUI.CongratsforSignin();
                        CustomerBL customer = UserDL.FindUser(u) as CustomerBL;
                        if (customer != null)
                        {
                            CartDL.RetrieveCart(customer);
                            OrderDL.RetrieveOrdersOfCustomer(customer);

                            while (true)
                            {
                                MainUI.ClearScreen();
                                string choice = CustomerUI.CustomerMenu();
                                if (choice == "1")
                                {
                                    if (ClothesDL.CheckClothes())
                                    {
                                        MainUI.ClearScreen();
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
                                                CartDL.SaveItemInCart(cartItem, customer);
                                                CartUI.AddedToCart();
                                                CartDL.RetrieveCart(customer);
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
                                        MainUI.ClearScreen();
                                        ClothesUI.NoClothesFound();
                                    }
                                    MainUI.ReturnForAll();
                                }
                                else if (choice == "2")
                                {
                                    MainUI.ClearScreen();
                                    if (customer.GetCart().CheckCart())
                                    {
                                        CartUI.DisplayCart(customer.GetCart().GetCartItems(), customer.GetCart());

                                    }
                                    else
                                    {
                                        CartUI.CartIsEmpty();
                                    }

                                    MainUI.ReturnForAll();




                                }
                                else if (choice == "3")
                                {
                                    MainUI.ClearScreen();
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
                                            CartDL.DeleteAnItem(id, customer);
                                            customer.ClearCart();
                                            CartDL.RetrieveCart(customer);
                                            CartUI.CartItemDel();
                                            

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

                                    MainUI.ReturnForAll();
                                }
                                else if (choice == "4")
                                {
                                    MainUI.ClearScreen();
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
                                                
                                                CartDL.UpdateQuantity(id, customer, quantity);
                                                shopItem.DropQuantity(quantity);
                                                ClothesDL.ChangeQuantity(id, shopItem.GetQuantity());
                                                customer.ClearCart();
                                                CartDL.RetrieveCart(customer);
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
                                    MainUI.ReturnForAll();
                                }
                                else if (choice == "5")
                                {
                                    MainUI.ClearScreen();
                                    if (customer.GetCart().CheckCart())
                                    {
                                        PaymentMethodBL p = PaymentMethodUI.TakeTypeOfPayment();
                                        MainUI.ClearScreen();
                                        OrderBL order = OrderUI.TakeInputForOrder(customer, new PaymentMethodBL(p.GetPaymentType()));
                                        OrderDL.AddOrder(order);
                                        customer.ClearOrders();
                                        OrderDL.RetrieveOrdersOfCustomer(customer);
                                        CartDL.EmptyCart(customer);
                                        CartDL.RetrieveCart(customer);
                                        OrderUI.OrderSuccessful();

                                    }
                                    else
                                    {
                                        CartUI.CartIsEmpty();
                                    }

                                    MainUI.ReturnForAll();

                                }
                                else if (choice == "6")
                                {
                                    

                                    MainUI.ClearScreen();
                                    if (customer.CheckOrders())
                                    {
                                        OrderUI.DisplayOrders(customer.GetOrderList());
                                    }
                                    else
                                    {
                                        OrderUI.NeverPlaced();
                                    }
                                    MainUI.ReturnForAll();

                                }
                                else if (choice == "7")
                                {
                                    MainUI.ClearScreen();
                                    if (ClothesDL.CheckClothes())
                                    {
                                        MainUI.ClearScreen();
                                        ClothesUI.DisplayAllClothes();
                                        int id = ClothesUI.TakeId();
                                        ClothesBL c = ClothesDL.FindClothByID(id);
                                        ReviewBL rev = ReviewUI.TakeReview(c, customer);
                                        ReviewDL.AddReviews(new ReviewBL(rev.GetRating(), rev.GetComment(), rev.GetUsername()),c);
                                        c.ClearReviews();
                                        ReviewDL.RetrieveReviews(c);
                                        ReviewUI.ReviewAddedSuccess();
                                    }
                                    else
                                    {
                                        MainUI.ClearScreen();
                                        ClothesUI.NoClothesFound();
                                    }
                                    MainUI.ReturnForAll();
                                }
                                else if (choice == "8")
                                {
                                    MainUI.ClearScreen();
                                    CustomerUI.DisplayTotalAmountSpent(customer);
                                    MainUI.ReturnForAll();

                                }
                                else if (choice == "9")
                                {
                                    MainUI.ClearScreen();
                                    CustomerUI.UpdateProfileInput(customer);
                                    UserDL.UpdateProfile(customer);
                                    UserUI.ProfileUpdateSuccess();
                                    MainUI.ReturnForAll();

                                }
                                else if (choice == "10")
                                {
                                    
                                    break;
                                }
                            }
                        }
                        else
                        {
                            CustomerUI.CustomerNotFound();
                            MainUI.ReturnForAll();
                        }
                    }
                    else if (UserDL.FindUser(u) != null && role == "employee")
                    {
                        UserUI.CongratsforSignin();
                        EmployeeBL employee = UserDL.FindUser(u) as EmployeeBL;
                        if (employee != null)
                        {
                            
                            while (true)
                            {
                                MainUI.ClearScreen();
                                string choice = EmployeeUI.EmployeeMenu();
                                if (choice == "1")
                                {
                                    if (ClothesDL.CheckClothes())
                                    {
                                        MainUI.ClearScreen();
                                        ClothesUI.DisplayAllClothes();
                                    }
                                    else
                                    {
                                        MainUI.ClearScreen();
                                        ClothesUI.NoClothesFound();
                                    }
                                    MainUI.ReturnForAll();
                                }
                                else if (choice == "2")
                                {
                                    MainUI.ClearScreen();
                                    ClothesBL c = ClothesUI.TakeInputForClothes();
                                    ClothesDL.AddClothes(c);
                                    MainUI.ReturnForAll();
                                }
                                else if (choice == "3")
                                {
                                    if (ClothesDL.CheckClothes())
                                    {
                                        MainUI.ClearScreen();
                                        ClothesUI.DisplayAllClothes();
                                        int id = ClothesUI.TakeId();
                                        ClothesBL c = ClothesDL.FindClothByID(id);
                                        if (c != null)
                                        {
                                            MainUI.ClearScreen();
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
                                        MainUI.ClearScreen();
                                        ClothesUI.NoClothesFound();
                                    }
                                    MainUI.ReturnForAll();
                                }
                                else if (choice == "4")
                                {
                                    if (ClothesDL.CheckClothes())
                                    {
                                        MainUI.ClearScreen();
                                        ClothesUI.DisplayAllClothes();
                                        int id = ClothesUI.TakeId();
                                        ClothesBL c = ClothesDL.FindClothByID(id);
                                        if (c != null)
                                        {
                                            MainUI.ClearScreen();
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
                                        MainUI.ClearScreen();
                                        ClothesUI.NoClothesFound();
                                    }
                                    MainUI.ReturnForAll();
                                }
                                else if (choice == "5")
                                {
                                    MainUI.ClearScreen();
                                    if (UserDL.CheckCustomersCount())
                                    {
                                        CustomerUI.DisplayCustomers();
                                    }
                                    else
                                    {
                                        MainUI.ClearScreen();
                                        CustomerUI.NoCustomers();
                                    }
                                    MainUI.ReturnForAll();
                                }
                                else if (choice == "6")
                                {
                                    MainUI.ClearScreen();
                                    if (UserDL.CheckCustomersCount())
                                    {
                                        CustomerUI.DisplayCustomers();
                                        string username = CustomerUI.TakeUsername();
                                        CustomerBL cus = UserDL.FindCustomerByUsername(username);
                                        if (cus != null)
                                        {
                                            OrderDL.RetrieveOrdersOfCustomer(cus);
                                            OrderUI.DisplayOrders(cus.GetOrderList());
                                        }
                                        else
                                        {
                                            CustomerUI.CustomerNotFound();
                                        }

                                    }
                                    else
                                    {
                                        MainUI.ClearScreen();
                                        CustomerUI.NoCustomers();
                                    }
                                    MainUI.ReturnForAll();
                                }
                                else if (choice == "7")
                                {
                                    if (ClothesDL.CheckClothes())
                                    {
                                        MainUI.ClearScreen();
                                        ClothesUI.DisplayAllClothes();
                                        int id = ClothesUI.TakeId();
                                        ClothesBL c = ClothesDL.FindClothByID(id);
                                        if (c != null)
                                        {
                                            c.ClearReviews();
                                            ReviewDL.RetrieveReviews(c);
                                            MainUI.ClearScreen();
                                            ReviewUI.DisplayReview(c);
                                        }
                                        else
                                        {
                                            ClothesUI.IncorrectId();
                                        }
                                    }
                                    else
                                    {
                                        MainUI.ClearScreen();
                                        ClothesUI.NoClothesFound();
                                    }
                                    MainUI.ReturnForAll();
                                }
                                else if (choice == "8")
                                {
                                    MainUI.ClearScreen();
                                   EmployeeUI.UpdateProfileInput(employee);
                                    UserDL.UpdateProfile(employee);
                                    UserUI.ProfileUpdateSuccess();
                                    MainUI.ReturnForAll();
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
                            MainUI.ReturnForAll();
                        }
                    }
                    else
                    {
                        UserUI.PrintUserNotFound();
                        MainUI.ReturnForAll();
                    }
                }
                else if (Choice == "2")
                {
                    MainUI.ClearScreen();
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

                    MainUI.ReturnForAll();


                }
                else if (Choice == "3")
                {
                    break;
                }

            }
        }
    }
}
