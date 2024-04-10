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
            ICartDL cartDL = new CartFH();
            IClothesDL clothesDL = new ClothesFH();
            IOrderDL orderDL = new OrderFH();
            IReviewDL reviewDL = new ReviewDB();
            IUserDL userDL = new UserFH();

            while (true)
            {
                MainUI.ClearScreen();
                string Choice = MainUI.MainMenu();
                if (Choice == "1")
                {
                    MainUI.ClearScreen();
                    string role = UserUI.TakeRole();
                    UserBL u = UserUI.SignInWindow(role);

                    if (userDL.FindUser(u) != null && role == "customer")
                    {
                        
                        CustomerBL customer = userDL.FindUser(u) as CustomerBL;
                        if (customer != null)
                        {
                            UserUI.CongratsforSignin();
                            cartDL.RetrieveCart(customer);
                            orderDL.RetrieveOrdersOfCustomer(customer);

                            while (true)
                            {
                                MainUI.ClearScreen();
                                string choice = CustomerUI.CustomerMenu();
                                if (choice == "1")
                                {
                                    if (clothesDL.CheckClothes())
                                    {
                                        MainUI.ClearScreen();
                                        ClothesUI.DisplayAllClothes(clothesDL.GetAllClothes());
                                        int id = ClothesUI.TakeId();
                                        ClothesBL c = clothesDL.FindClothByID(id);
                                        if (c != null && customer.GetCart().FindClothFromCart(id) == null)
                                        {
                                            int quantity = ClothesUI.TakeQuantity();
                                            if (c.IsAvailableToBuy(quantity))
                                            {
                                                ClothesBL cartItem = new ClothesBL(c);
                                                cartItem.SetQuantity(quantity);
                                                c.DropQuantity(quantity);
                                                clothesDL.ChangeQuantity(id, c.GetQuantity());
                                                cartDL.SaveItemInCart(cartItem, customer);
                                                CartUI.AddedToCart();
                                                cartDL.RetrieveCart(customer);
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
                                            ClothesBL shopItem = clothesDL.FindClothByID(id);
                                            shopItem.AddQuantity(quantity);
                                            clothesDL.ChangeQuantity(id, shopItem.GetQuantity());
                                            cartDL.DeleteAnItem(id, customer);
                                            customer.ClearCart();
                                            cartDL.RetrieveCart(customer);
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
                                            ClothesBL shopItem = clothesDL.FindClothByID(id);
                                            shopItem.AddQuantity(currentQuantity);

                                            int quantity = ClothesUI.TakeQuantity();
                                            if (shopItem.IsAvailableToBuy(quantity))
                                            {

                                                cartDL.UpdateQuantity(id, customer, quantity);
                                                shopItem.DropQuantity(quantity);
                                                clothesDL.ChangeQuantity(id, shopItem.GetQuantity());
                                                customer.ClearCart();
                                                cartDL.RetrieveCart(customer);
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
                                        orderDL.AddOrder(order);
                                        customer.ClearOrders();
                                        orderDL.RetrieveOrdersOfCustomer(customer);
                                        cartDL.EmptyCart(customer);
                                        customer.ClearCart();
                                        cartDL.RetrieveCart(customer);
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
                                    if (clothesDL.CheckClothes())
                                    {
                                        MainUI.ClearScreen();
                                        ClothesUI.DisplayAllClothes(clothesDL.GetAllClothes());
                                        int id = ClothesUI.TakeId();
                                        ClothesBL c = clothesDL.FindClothByID(id);
                                        if(c != null)
                                        {
                                            ReviewBL rev = ReviewUI.TakeReview(c, customer);
                                            reviewDL.AddReviews(new ReviewBL(rev.GetRating(), rev.GetComment(), rev.GetUsername()), c);
                                            c.ClearReviews();
                                            reviewDL.RetrieveReviews(c);
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
                                    userDL.UpdateProfile(customer);
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
                    else if (userDL.FindUser(u) != null && role == "employee")
                    {
                        
                        EmployeeBL employee = userDL.FindUser(u) as EmployeeBL;
                        if (employee != null)
                        {
                            UserUI.CongratsforSignin();
                            while (true)
                            {
                                MainUI.ClearScreen();
                                string choice = EmployeeUI.EmployeeMenu();
                                if (choice == "1")
                                {
                                    if (clothesDL.CheckClothes())
                                    {
                                        MainUI.ClearScreen();
                                        ClothesUI.DisplayAllClothes(clothesDL.GetAllClothes());
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
                                    if(!clothesDL.CheckClothExistence(c))
                                    {
                                        clothesDL.AddClothes(c);
                                    }
                                    else
                                    {
                                        ClothesUI.ClothAlreadyExist();
                                    }
                                    
                                    MainUI.ReturnForAll();
                                }
                                else if (choice == "3")
                                {
                                    if (clothesDL.CheckClothes())
                                    {
                                        MainUI.ClearScreen();
                                        ClothesUI.DisplayAllClothes(clothesDL.GetAllClothes());
                                        int id = ClothesUI.TakeId();
                                        ClothesBL c = clothesDL.FindClothByID(id);
                                        if (c != null)
                                        {
                                            MainUI.ClearScreen();
                                            ClothesBL cloth = ClothesUI.TakeInputForUpdateClothe(c);
                                            if (!clothesDL.CheckClothExistence(cloth) || !clothesDL.CheckClothExistenceByQuantity(cloth))
                                            {
                                                c.UpdateCloth(cloth);
                                                clothesDL.UpdateCloth(c);
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
                                    if (clothesDL.CheckClothes())
                                    {
                                        MainUI.ClearScreen();
                                        ClothesUI.DisplayAllClothes(clothesDL.GetAllClothes());
                                        int id = ClothesUI.TakeId();
                                        ClothesBL c = clothesDL.FindClothByID(id);
                                        if (c != null)
                                        {
                                            MainUI.ClearScreen();
                                            if (clothesDL.DeleteCloth(c))
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
                                   if (userDL.CheckCustomersCount())
                                   {
                                       CustomerUI.DisplayCustomers(userDL.GetAllCustomers());
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
                                    if (userDL.CheckCustomersCount())
                                    {
                                        CustomerUI.DisplayCustomers(userDL.GetAllCustomers());
                                        string username = CustomerUI.TakeUsername();
                                        CustomerBL cus = userDL.FindCustomerByUsername(username);
                                        if (cus != null)
                                        {
                                            orderDL.RetrieveOrdersOfCustomer(cus);
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
                                    if (clothesDL.CheckClothes())
                                    {
                                        MainUI.ClearScreen();
                                        ClothesUI.DisplayAllClothes(clothesDL.GetAllClothes());
                                        int id = ClothesUI.TakeId();
                                        ClothesBL c = clothesDL.FindClothByID(id);
                                        if (c != null)
                                        {
                                            c.ClearReviews();
                                            reviewDL.RetrieveReviews(c);
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
                                    userDL.UpdateProfile(employee);
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
                    if (userDL.IsUserExists(u))
                    {
                        UserUI.PrintUserTaken();
                    }
                    else
                    {
                        if (userDL.AddUser(u))
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
