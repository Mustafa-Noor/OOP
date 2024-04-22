using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FashionIsU.UI;
using FashionIsU;
using FashionIsUlLibrary;
using FashionIsU_ConsoleApp_.UI;

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
                    ObjectHandler.GetAdmin().ClearEmployees();
                    ObjectHandler.GetEmployeeDL().RetrieveEmployees(ObjectHandler.GetAdmin());

                    MainUI.ClearScreen();
                    string role = UserUI.TakeRole();
                    UserBL u = UserUI.SignInWindow(role);

                    if (ObjectHandler.GetCustomerDL().FindCustomer(u) != null && role == "customer")
                    {
                        
                        CustomerBL customer = ObjectHandler.GetCustomerDL().FindCustomer(u);
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
                                    ObjectHandler.GetCustomerDL().UpdateProfile(customer);
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
                    else if (ObjectHandler.GetAdmin().FindEmployee(u) != null && role == "employee")
                    {
                        
                        EmployeeBL employee = ObjectHandler.GetAdmin().FindEmployee(u);
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
                                   if (ObjectHandler.GetCustomerDL().CheckCustomersCount())
                                   {
                                       CustomerUI.DisplayCustomers(ObjectHandler.GetCustomerDL().GetAllCustomers());
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
                                    if (ObjectHandler.GetCustomerDL().CheckCustomersCount())
                                    {
                                        CustomerUI.DisplayCustomers(ObjectHandler.GetCustomerDL().GetAllCustomers());
                                        string username = CustomerUI.TakeUsername();
                                        CustomerBL cus = ObjectHandler.GetCustomerDL().FindCustomerByUsername(username);
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
                                    ObjectHandler.GetEmployeeDL().UpdateProfile(employee);
                                    ObjectHandler.GetAdmin().ClearEmployees();
                                    ObjectHandler.GetEmployeeDL().RetrieveEmployees(ObjectHandler.GetAdmin());
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
                    else if(ObjectHandler.GetAdmin().IsAdmin(u) && role=="admin")
                    {
                        UserUI.CongratsforSignin();
                        while(true)
                        {
                            MainUI.ClearScreen();
                            string choice = AdminUI.AdminMenu();
                            if(choice == "1")
                            {
                                MainUI.ClearScreen();
                                EmployeeBL employee = EmployeeUI.TakeInputForEmployee();
                                if(ObjectHandler.GetCustomerDL().IsCustomerExists(employee.GetUsername()) || ObjectHandler.GetAdmin().CheckEmployeeExist(employee.GetUsername()))
                                {
                                    UserUI.PrintUserTaken();
                                }
                                else
                                {
                                    ObjectHandler.GetEmployeeDL().AddEmployee(new EmployeeBL(employee));
                                    ObjectHandler.GetAdmin().ClearEmployees();
                                    ObjectHandler.GetEmployeeDL().RetrieveEmployees(ObjectHandler.GetAdmin());
                                    EmployeeUI.EmployeeAdditionSuccess();
                                }
                                MainUI.ReturnForAll();
                            }
                            else if(choice == "2")
                            {
                                MainUI.ClearScreen();
                                if (ObjectHandler.GetAdmin().CheckEmployeesCount())
                                {
                                    EmployeeUI.DisplayEmployees(ObjectHandler.GetAdmin().GetAllEmployees());
                                }
                                else
                                {
                                    MainUI.ClearScreen();
                                    EmployeeUI.EmployeesNotFound();
                                }
                                MainUI.ReturnForAll();
                            }
                            else if (choice == "3")
                            {
                                MainUI.ClearScreen();
                                if (ObjectHandler.GetAdmin().CheckEmployeesCount())
                                {
                                    EmployeeUI.DisplayEmployees(ObjectHandler.GetAdmin().GetAllEmployees());
                                    string username = EmployeeUI.TakeUsernameOfEmployee();
                                    EmployeeBL emp = ObjectHandler.GetAdmin().FindEmployee(username);
                                    if(emp != null)
                                    {
                                        MainUI.ClearScreen();
                                        EmployeeUI.UpdateEmployeeInput(emp);
                                        ObjectHandler.GetEmployeeDL().UpdateProfile(emp);
                                        ObjectHandler.GetAdmin().ClearEmployees();
                                        ObjectHandler.GetEmployeeDL().RetrieveEmployees(ObjectHandler.GetAdmin());
                                        EmployeeUI.EmployeeUpdateSuccess();
                                    }
                                    else
                                    {
                                        EmployeeUI.EmployeeNotFound();

                                    }
                                    MainUI.ReturnForAll();
                                }
                                else
                                {
                                    MainUI.ClearScreen();
                                    EmployeeUI.EmployeesNotFound();
                                }
                                MainUI.ReturnForAll();
                            }
                            else if (choice == "4")
                            {
                                MainUI.ClearScreen();
                                if (ObjectHandler.GetAdmin().CheckEmployeesCount())
                                {
                                    EmployeeUI.DisplayEmployees(ObjectHandler.GetAdmin().GetAllEmployees());
                                    string username = EmployeeUI.TakeUsernameOfEmployee();
                                    EmployeeBL emp = ObjectHandler.GetAdmin().FindEmployee(username);
                                    if (emp != null)
                                    {
                                        ObjectHandler.GetEmployeeDL().DeleteEmployee(emp);
                                        ObjectHandler.GetAdmin().ClearEmployees();
                                        ObjectHandler.GetEmployeeDL().RetrieveEmployees(ObjectHandler.GetAdmin());
                                        EmployeeUI.EmployeeDeleteSuccess();
                                    }
                                    else
                                    {
                                        EmployeeUI.EmployeeNotFound();
                                    }

                                }
                                else
                                {
                                    MainUI.ClearScreen();
                                    EmployeeUI.EmployeesNotFound();
                                }
                                MainUI.ReturnForAll();
                            }
                            else if (choice == "5")
                            {
                                MainUI.ClearScreen();
                                if (ObjectHandler.GetCustomerDL().CheckCustomersCount())
                                {
                                    CustomerUI.DisplayCustomers(ObjectHandler.GetCustomerDL().GetAllCustomers());
                                }
                                else
                                {
                                    MainUI.ClearScreen();
                                    CustomerUI.NoCustomers();
                                }
                                MainUI.ReturnForAll();
                            }
                            else if(choice == "6")
                            {
                                break;
                            }
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
                    ObjectHandler.GetAdmin().ClearEmployees();
                    ObjectHandler.GetEmployeeDL().RetrieveEmployees(ObjectHandler.GetAdmin());

                    MainUI.ClearScreen();
                    CustomerBL cus = CustomerUI.CreateCustomer();
                    if (ObjectHandler.GetCustomerDL().IsCustomerExists(cus.GetUsername()) || ObjectHandler.GetAdmin().CheckEmployeeExist(cus.GetUsername()))
                    {
                        UserUI.PrintUserTaken();
                    }
                    else
                    {
                        if (ObjectHandler.GetCustomerDL().AddCustomer(cus))
                        {
                            CustomerUI.CongratsforSignup();
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
