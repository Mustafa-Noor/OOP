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
                string Choice = MainUI.MainMenu(); // take choice from the Main Menu
                if (Choice == "1")
                {
                    ObjectHandler.GetAdmin().ClearEmployees();
                    ObjectHandler.GetEmployeeDL().RetrieveEmployees(ObjectHandler.GetAdmin());

                    MainUI.ClearScreen();
                    string role = UserUI.TakeRole(); // takes role for sign in
                    UserBL u = UserUI.SignInWindow(role);

                    if (ObjectHandler.GetCustomerDL().FindCustomer(u) != null && role == "customer") // if role is customer
                    {
                        
                        CustomerBL customer = ObjectHandler.GetCustomerDL().FindCustomer(u); // if customer is found
                        if (customer != null)
                        {
                            UserUI.CongratsforSignin();
                            customer.ClearCart();
                            ObjectHandler.GetCartDL().RetrieveCart(customer);  // retrieve their cart 
                            ObjectHandler.GetOrderDL().RetrieveOrdersOfCustomer(customer); // retrieve the orders of customer

                            while (true)
                            {
                                MainUI.ClearScreen();
                                string choice = CustomerUI.CustomerMenu(); // display the customer menu
                                if (choice == "1") // buy an item
                                {
                                    if (ObjectHandler.GetClothesDL().CheckClothes()) // if cloth exist
                                    {
                                        MainUI.ClearScreen();
                                        ClothesUI.DisplayAllClothes(ObjectHandler.GetClothesDL().GetAllClothes()); // displays cloth
                                        int id = ClothesUI.TakeId(); // takes id of cloth
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
                                            CartUI.ItemAlreadyBought(); // shows that item is already bought
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
                                else if (choice == "2") // display cart
                                {
                                    MainUI.ClearScreen();
                                    customer.ClearCart();
                                    ObjectHandler.GetCartDL().RetrieveCart(customer); // loads the cart of customer
                                    if (customer.GetCart().CheckCart())
                                    {
                                        
                                        CartUI.DisplayCart(customer.GetCart().GetCartItems(), customer.GetCart());  // displays the cart

                                    }
                                    else
                                    {
                                        CartUI.CartIsEmpty();
                                    }

                                    MainUI.ReturnForAll();




                                }
                                else if (choice == "3") // delete an item from cart
                                {
                                    MainUI.ClearScreen();
                                    if (customer.GetCart().CheckCart())
                                    {
                                        CartUI.DisplayCart(customer.GetCart().GetCartItems(), customer.GetCart()); // display the cart of customer
                                        int id = ClothesUI.TakeId();
                                        ClothesBL c = customer.GetCart().FindClothFromCart(id); // gets the cart item
                                        if (c != null)
                                        {
                                            int quantity = c.GetQuantity();
                                            ClothesBL shopItem = ObjectHandler.GetClothesDL().FindClothByID(id); // finds the shop item
                                            shopItem.AddQuantity(quantity); // increase the quantity of shop item
                                            ObjectHandler.GetClothesDL().ChangeQuantity(id, shopItem.GetQuantity());
                                            ObjectHandler.GetCartDL().DeleteAnItem(id, customer); // delete item of cart
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
                                else if (choice == "4") // update quantity of cart item
                                {
                                    MainUI.ClearScreen();
                                    if (customer.GetCart().CheckCart())
                                    {
                                        CartUI.DisplayCart(customer.GetCart().GetCartItems(), customer.GetCart()); // display cart
                                        int id = ClothesUI.TakeId();
                                        ClothesBL c = customer.GetCart().FindClothFromCart(id); // find cloth from cart

                                        if (c != null)
                                        {
                                            int currentQuantity = c.GetQuantity();
                                            ClothesBL shopItem = ObjectHandler.GetClothesDL().FindClothByID(id);
                                            shopItem.AddQuantity(currentQuantity);

                                            int quantity = ClothesUI.TakeQuantity();
                                            if (shopItem.IsAvailableToBuy(quantity))
                                            {
                                                // implements functionality to update the quantity of item in cart
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
                                else if (choice == "5") // place order
                                {
                                    MainUI.ClearScreen();
                                    if (customer.GetCart().CheckCart())
                                    {
                                        PaymentMethodBL p = PaymentMethodUI.TakeTypeOfPayment(); // takes the type of payment method for order
                                        MainUI.ClearScreen();
                                        OrderBL order = OrderUI.TakeInputForOrder(customer, new PaymentMethodBL(p.GetPaymentType()));
                                        ObjectHandler.GetOrderDL().AddOrder(new OrderBL(order)); // add order with compostion 
                                        customer.ClearOrders();
                                        ObjectHandler.GetOrderDL().RetrieveOrdersOfCustomer(customer); // loads order of customers
                                        ObjectHandler.GetCartDL().EmptyCart(customer); // empty the cart
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
                                else if (choice == "6") // display orders
                                {


                                    MainUI.ClearScreen();
                                    if (customer.CheckOrders())
                                    {
                                        OrderUI.DisplayOrders(customer.GetOrderList()); // display the orders of customer
                                    }
                                    else
                                    {
                                        OrderUI.NeverPlaced();
                                    }
                                    MainUI.ReturnForAll();

                                }
                                else if (choice == "7") //give review
                                {
                                    MainUI.ClearScreen();
                                    if (ObjectHandler.GetClothesDL().CheckClothes())
                                    {
                                        MainUI.ClearScreen();
                                        ClothesUI.DisplayAllClothes(ObjectHandler.GetClothesDL().GetAllClothes());
                                        int id = ClothesUI.TakeId();
                                        ClothesBL c = ObjectHandler.GetClothesDL().FindClothByID(id); // find cloth to add review for
                                        if(c != null)
                                        {
                                            ReviewBL rev = ReviewUI.TakeReview(c, customer);
                                            ObjectHandler.GetReviewDL().AddReviews(new ReviewBL(rev.GetRating(), rev.GetComment(), rev.GetUsername()), c);
                                            c.ClearReviews();
                                            ObjectHandler.GetReviewDL().RetrieveReviews(c); // adds reviews for cloth
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
                                else if (choice == "8") // it displays the total amount spent
                                {
                                    MainUI.ClearScreen();
                                    CustomerUI.DisplayTotalAmountSpent(customer);
                                    MainUI.ReturnForAll();

                                }
                                else if (choice == "9") // it updates the profile
                                {
                                    MainUI.ClearScreen();
                                    CustomerUI.UpdateProfileInput(customer);
                                    ObjectHandler.GetCustomerDL().UpdateProfile(customer);
                                    UserUI.ProfileUpdateSuccess();
                                    MainUI.ReturnForAll();

                                }
                                else if (choice == "10")
                                {
                                    // closes the customer menu
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
                    else if (ObjectHandler.GetAdmin().FindEmployee(u) != null && role == "employee") // if role is employee
                    {
                        
                        EmployeeBL employee = ObjectHandler.GetAdmin().FindEmployee(u); // find employee
                        if (employee != null)
                        {
                            UserUI.CongratsforSignin(); // if employee exist then congrats
                            while (true)
                            {
                                MainUI.ClearScreen();
                                string choice = EmployeeUI.EmployeeMenu(); // displys the employee menu
                                if (choice == "1") // displays all cloth
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
                                else if (choice == "2") // add an item of cloth
                                {
                                    MainUI.ClearScreen();
                                    ClothesBL c = ClothesUI.TakeInputForClothes(); // takes input for the cloth to be added
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
                                else if (choice == "3") // update an item of cloth
                                {
                                    if (ObjectHandler.GetClothesDL().CheckClothes())
                                    {
                                        MainUI.ClearScreen();
                                        ClothesUI.DisplayAllClothes(ObjectHandler.GetClothesDL().GetAllClothes()); // displays all clothes
                                        int id = ClothesUI.TakeId();
                                        ClothesBL c = ObjectHandler.GetClothesDL().FindClothByID(id); // cloth found
                                        if (c != null)
                                        {
                                            MainUI.ClearScreen();
                                            ClothesBL cloth = ClothesUI.TakeInputForUpdateClothe(c);
                                            if (!ObjectHandler.GetClothesDL().CheckClothExistence(cloth) || !ObjectHandler.GetClothesDL().CheckClothExistenceByQuantity(cloth))
                                            {
                                                c.UpdateCloth(cloth);
                                                ObjectHandler.GetClothesDL().UpdateCloth(c); // updates the cloth
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
                                else if (choice == "4") // delete an item of clothing
                                {
                                    if (ObjectHandler.GetClothesDL().CheckClothes())
                                    {
                                        MainUI.ClearScreen();
                                        ClothesUI.DisplayAllClothes(ObjectHandler.GetClothesDL().GetAllClothes());
                                        int id = ClothesUI.TakeId();
                                        ClothesBL c = ObjectHandler.GetClothesDL().FindClothByID(id); // find cloth from id
                                        if (c != null)
                                        {
                                            MainUI.ClearScreen();
                                            ObjectHandler.GetReviewDL().DeleteReview(c);
                                            if (ObjectHandler.GetClothesDL().DeleteCloth(c)) //delete item 
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
                                else if (choice == "5") // display all customer
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
                                else if (choice == "6") // checks the list of order of customer
                                {
                                    
                                    MainUI.ClearScreen();
                                    if (ObjectHandler.GetCustomerDL().CheckCustomersCount())
                                    {
                                        CustomerUI.DisplayCustomers(ObjectHandler.GetCustomerDL().GetAllCustomers());
                                        string username = CustomerUI.TakeUsername();
                                        CustomerBL cus = ObjectHandler.GetCustomerDL().FindCustomerByUsername(username); // find customer from their username
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
                                else if (choice == "7") //checks reviews of cloth
                                {
                                    if (ObjectHandler.GetClothesDL().CheckClothes())
                                    {
                                        MainUI.ClearScreen();
                                        ClothesUI.DisplayAllClothes(ObjectHandler.GetClothesDL().GetAllClothes());
                                        int id = ClothesUI.TakeId();
                                        ClothesBL c = ObjectHandler.GetClothesDL().FindClothByID(id); // find cloth from their id
                                        if (c != null)
                                        {
                                            c.ClearReviews();
                                            ObjectHandler.GetReviewDL().RetrieveReviews(c); // display reviews
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
                                else if (choice == "8") // updates the profile of an employee
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
                    else if(ObjectHandler.GetAdmin().IsAdmin(u) && role=="admin") // if role is admin
                    {
                        UserUI.CongratsforSignin();
                        while(true)
                        {
                            MainUI.ClearScreen();
                            string choice = AdminUI.AdminMenu(); // displays the admin menu
                            if(choice == "1") // add an employee
                            {
                                MainUI.ClearScreen();
                                EmployeeBL employee = EmployeeUI.TakeInputForEmployee(); 
                                if(ObjectHandler.GetCustomerDL().IsCustomerExists(employee.GetUsername()) || ObjectHandler.GetAdmin().CheckEmployeeExist(employee.GetUsername()))
                                {
                                    UserUI.PrintUserTaken();
                                }
                                else
                                {
                                    ObjectHandler.GetEmployeeDL().AddEmployee(new EmployeeBL(employee)); // compostion for employee addition
                                    ObjectHandler.GetAdmin().ClearEmployees();
                                    ObjectHandler.GetEmployeeDL().RetrieveEmployees(ObjectHandler.GetAdmin());
                                    EmployeeUI.EmployeeAdditionSuccess();
                                }
                                MainUI.ReturnForAll();
                            }
                            else if(choice == "2") // display employees
                            {
                                MainUI.ClearScreen();
                                if (ObjectHandler.GetAdmin().CheckEmployeesCount())
                                {
                                    EmployeeUI.DisplayEmployees(ObjectHandler.GetAdmin().GetAllEmployees()); // displa all of the employees
                                }
                                else
                                {
                                    MainUI.ClearScreen();
                                    EmployeeUI.EmployeesNotFound();
                                }
                                MainUI.ReturnForAll();
                            }
                            else if (choice == "3") // update an employee
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
                            else if (choice == "4") // delete an employee
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
                            else if (choice == "5") // display list of customer
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
                else if (Choice == "2") // Sign up menu for customer
                {
                    ObjectHandler.GetAdmin().ClearEmployees();
                    ObjectHandler.GetEmployeeDL().RetrieveEmployees(ObjectHandler.GetAdmin());

                    MainUI.ClearScreen();
                    CustomerBL cus = CustomerUI.CreateCustomer(); // makes an object of customer
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
                    // terminate the program
                    break;
                }

            }
        }
    }
}
