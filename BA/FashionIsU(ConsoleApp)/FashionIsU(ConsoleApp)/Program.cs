using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FashionIsU.UI;
using FashionIsU;
using FashionIsUlLibrary;

namespace FashionIsU_ConsoleApp_
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

                    if (ObjectHandler.GetUserDL().FindUser(u) != null && role == "customer")
                    {
                        
                        CustomerBL customer = ObjectHandler.GetUserDL().FindUser(u) as CustomerBL;
                        if (customer != null)
                        {
                            UserUI.CongratsforSignin();
                            ObjectHandler.GetCartDL().RetrieveCart(customer);
                            ObjectHandler.GetOrderDL().RetrieveOrdersOfCustomer(customer);

                            while (true)
                            {
                                MainUI.ClearScreen();
                                string choice = CustomerUI.CustomerMenu();
                                if (choice == "1")
                                {
                                    if (ObjectHandler.GetClothesDL().CheckClothes())
                                    {
                                        MainUI.ClearScreen();
                                        ClothesUI.DisplayAllClothes(ObjectHandler.GetClothesDL().GetAllClothes());
                                        int id = ClothesUI.TakeId();
                                        ClothesBL c = ObjectHandler.GetClothesDL().FindClothByID(id);
                                        if (c != null && customer.GetCart().FindClothFromCart(id) == null)
                                        {
                                            int quantity = ClothesUI.TakeQuantity();
                                            if (c.IsAvailableToBuy(quantity))
                                            {
                                                ClothesBL cartItem = new ClothesBL(c);
                                                cartItem.SetQuantity(quantity);
                                                c.DropQuantity(quantity);
                                                ObjectHandler.GetClothesDL().ChangeQuantity(id, c.GetQuantity());
                                                ObjectHandler.GetCartDL().SaveItemInCart(cartItem, customer);
                                                CartUI.AddedToCart();
                                                ObjectHandler.GetCartDL().RetrieveCart(customer);
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
                                            ClothesBL shopItem = ObjectHandler.GetClothesDL().FindClothByID(id);
                                            shopItem.AddQuantity(quantity);
                                            ObjectHandler.GetClothesDL().ChangeQuantity(id, shopItem.GetQuantity());
                                            ObjectHandler.GetCartDL().DeleteAnItem(id, customer);
                                            customer.ClearCart();
                                            ObjectHandler.GetCartDL().RetrieveCart(customer);
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
                                            ClothesBL shopItem = ObjectHandler.GetClothesDL().FindClothByID(id);
                                            shopItem.AddQuantity(currentQuantity);

                                            int quantity = ClothesUI.TakeQuantity();
                                            if (shopItem.IsAvailableToBuy(quantity))
                                            {

                                                ObjectHandler.GetCartDL().UpdateQuantity(id, customer, quantity);
                                                shopItem.DropQuantity(quantity);
                                                ObjectHandler.GetClothesDL().ChangeQuantity(id, shopItem.GetQuantity());
                                                customer.ClearCart();
                                                ObjectHandler.GetCartDL().RetrieveCart(customer);
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
                                        ObjectHandler.GetOrderDL().AddOrder(order);
                                        customer.ClearOrders();
                                        ObjectHandler.GetOrderDL().RetrieveOrdersOfCustomer(customer);
                                        ObjectHandler.GetCartDL().EmptyCart(customer);
                                        customer.ClearCart();
                                        ObjectHandler.GetCartDL().RetrieveCart(customer);
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
                                    if (ObjectHandler.GetClothesDL().CheckClothes())
                                    {
                                        MainUI.ClearScreen();
                                        ClothesUI.DisplayAllClothes(ObjectHandler.GetClothesDL().GetAllClothes());
                                        int id = ClothesUI.TakeId();
                                        ClothesBL c = ObjectHandler.GetClothesDL().FindClothByID(id);
                                        if(c != null)
                                        {
                                            ReviewBL rev = ReviewUI.TakeReview(c, customer);
                                            ObjectHandler.GetReviewDL().AddReviews(new ReviewBL(rev.GetRating(), rev.GetComment(), rev.GetUsername()), c);
                                            c.ClearReviews();
                                            ObjectHandler.GetReviewDL().RetrieveReviews(c);
                                            ReviewUI.ReviewAddedSuccess();
                                        }
                                        else
                                        {
                                            ClothesUI.IncorrectId();
                                            MainUI.ReturnForAll();
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
                                    CustomerUI.DisplayTotalAmountSpent(customer);
                                    MainUI.ReturnForAll();

                                }
                                else if (choice == "9")
                                {
                                    MainUI.ClearScreen();
                                    CustomerUI.UpdateProfileInput(customer);
                                    ObjectHandler.GetUserDL().UpdateProfile(customer);
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
                    else if (ObjectHandler.GetUserDL().FindUser(u) != null && role == "employee")
                    {
                        
                        EmployeeBL employee = ObjectHandler.GetUserDL().FindUser(u) as EmployeeBL;
                        if (employee != null)
                        {
                            UserUI.CongratsforSignin();
                            while (true)
                            {
                                MainUI.ClearScreen();
                                string choice = EmployeeUI.EmployeeMenu();
                                if (choice == "1")
                                {
                                    if (ObjectHandler.GetClothesDL().CheckClothes())
                                    {
                                        MainUI.ClearScreen();
                                        ClothesUI.DisplayAllClothes(ObjectHandler.GetClothesDL().GetAllClothes());
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
                                    if(!ObjectHandler.GetClothesDL().CheckClothExistence(c))
                                    {
                                        ObjectHandler.GetClothesDL().AddClothes(c);
                                    }
                                    else
                                    {
                                        ClothesUI.ClothAlreadyExist();
                                    }
                                    
                                    MainUI.ReturnForAll();
                                }
                                else if (choice == "3")
                                {
                                    if (ObjectHandler.GetClothesDL().CheckClothes())
                                    {
                                        MainUI.ClearScreen();
                                        ClothesUI.DisplayAllClothes(ObjectHandler.GetClothesDL().GetAllClothes());
                                        int id = ClothesUI.TakeId();
                                        ClothesBL c = ObjectHandler.GetClothesDL().FindClothByID(id);
                                        if (c != null)
                                        {
                                            MainUI.ClearScreen();
                                            ClothesBL cloth = ClothesUI.TakeInputForUpdateClothe(c);
                                            if (!ObjectHandler.GetClothesDL().CheckClothExistence(cloth) || !ObjectHandler.GetClothesDL().CheckClothExistenceByQuantity(cloth))
                                            {
                                                c.UpdateCloth(cloth);
                                                ObjectHandler.GetClothesDL().UpdateCloth(c);
                                                ClothesUI.ClothUpdatedSuccessfully();
                                            }
                                            else
                                            {
                                                ClothesUI.ClothAlreadyExist();
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
                                else if (choice == "4")
                                {
                                    if (ObjectHandler.GetClothesDL().CheckClothes())
                                    {
                                        MainUI.ClearScreen();
                                        ClothesUI.DisplayAllClothes(ObjectHandler.GetClothesDL().GetAllClothes());
                                        int id = ClothesUI.TakeId();
                                        ClothesBL c = ObjectHandler.GetClothesDL().FindClothByID(id);
                                        if (c != null)
                                        {
                                            MainUI.ClearScreen();
                                            ObjectHandler.GetReviewDL().DeleteReview(c);
                                            if (ObjectHandler.GetClothesDL().DeleteCloth(c))
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
                                   if (ObjectHandler.GetUserDL().CheckCustomersCount())
                                   {
                                       CustomerUI.DisplayCustomers(ObjectHandler.GetUserDL().GetAllCustomers());
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
                                    if (ObjectHandler.GetUserDL().CheckCustomersCount())
                                    {
                                        CustomerUI.DisplayCustomers(ObjectHandler.GetUserDL().GetAllCustomers());
                                        string username = CustomerUI.TakeUsername();
                                        CustomerBL cus = ObjectHandler.GetUserDL().FindCustomerByUsername(username);
                                        if (cus != null)
                                        {
                                            ObjectHandler.GetOrderDL().RetrieveOrdersOfCustomer(cus);
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
                                    if (ObjectHandler.GetClothesDL().CheckClothes())
                                    {
                                        MainUI.ClearScreen();
                                        ClothesUI.DisplayAllClothes(ObjectHandler.GetClothesDL().GetAllClothes());
                                        int id = ClothesUI.TakeId();
                                        ClothesBL c = ObjectHandler.GetClothesDL().FindClothByID(id);
                                        if (c != null)
                                        {
                                            c.ClearReviews();
                                            ObjectHandler.GetReviewDL().RetrieveReviews(c);
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
                                    ObjectHandler.GetUserDL().UpdateProfile(employee);
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
                    if (ObjectHandler.GetUserDL().IsUserExists(u))
                    {
                        UserUI.PrintUserTaken();
                    }
                    else
                    {
                        if (ObjectHandler.GetUserDL().AddUser(u))
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
