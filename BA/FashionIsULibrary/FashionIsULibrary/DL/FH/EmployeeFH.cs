using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using FashionIsU;
using FashionIsUlLibrary;

namespace FashionIsU
{
    public class EmployeeFH:IEmployeeDL
    {
        // this is for the singleton functionality
        private static EmployeeFH EmployeeFHInstance; // instance
        private string FilePath = "";
        private EmployeeFH(string FilePath)
        {
            this.FilePath = FilePath;
        }
        public static EmployeeFH GetEmployeeFH(string filePath) // return the instance
        {
            if (EmployeeFHInstance == null)
            {
                EmployeeFHInstance = new EmployeeFH(filePath);
            }
            return EmployeeFHInstance;
        }

        public bool AddEmployee(EmployeeBL employee) // adds an employee in the database
        {
            using (StreamWriter f = new StreamWriter(FilePath, true))
            {
                if (f != null)
                {
                    f.WriteLine(employee.GetUsername() + "," + employee.GetPassword() + "," + employee.GetEmail() + "," + employee.GetFirstName() + "," + employee.GetLastName() + "," + employee.GetPhoneNumber() + "," + employee.GetRole() + "," + employee.GetPosition());
                    f.Flush();
                    return true;
                }
            }
            return false;
        }

        public void RetrieveEmployees(AdminBL admin) // loads the list of employees in the admin
        {
            if (File.Exists(FilePath))
            {
                using (StreamReader f = new StreamReader(FilePath))
                {
                    string record;
                    while ((record = f.ReadLine()) != null)
                    {
                        if (!string.IsNullOrEmpty(record))
                        {
                            string[] splittedRecord = record.Split(',');
                            string username = splittedRecord[0];
                            string password = splittedRecord[1];
                            string email = splittedRecord[2];
                            string fname = splittedRecord[3];
                            string lname = splittedRecord[4];
                            string contact = splittedRecord[5];
                            string role = splittedRecord[6];
                            string position = splittedRecord[7];

                            EmployeeBL emp = new EmployeeBL(username, password, email, fname, lname, contact, role, position);
                            admin.AddEmployee(new EmployeeBL(emp));

                        }

                    }
                }
            }
        }

        public List<EmployeeBL> GetAllEmployees() // return the list of employees
        {
            List <EmployeeBL> Employees = new List <EmployeeBL>();
            if (File.Exists(FilePath))
            {
                using (StreamReader f = new StreamReader(FilePath))
                {
                    string record;
                    while ((record = f.ReadLine()) != null)
                    {
                        if (!string.IsNullOrEmpty(record))
                        {
                            string[] splittedRecord = record.Split(',');
                            string username = splittedRecord[0];
                            string password = splittedRecord[1];
                            string email = splittedRecord[2];
                            string fname = splittedRecord[3];
                            string lname = splittedRecord[4];
                            string phone = splittedRecord[5];
                            string role = splittedRecord[6];
                            string position = splittedRecord[7];

                            EmployeeBL emp = new EmployeeBL(username, password, email, fname, lname, phone, role, position);
                            Employees.Add(emp);
                        }


                    }
                }
            }

            return Employees;
        }

        public bool DeleteEmployee(EmployeeBL employee) // deletes an employee from the database
        {
            bool empDeleted = false;
            List<EmployeeBL> Employees = GetAllEmployees();

            foreach (EmployeeBL stored in Employees)
            {
                if (stored.GetUsername() == employee.GetUsername())
                {
                    Employees.Remove(stored);
                    empDeleted = true;
                    break;
                }
            }

            if (empDeleted)
            {
                File.WriteAllText(FilePath, "");
                foreach (EmployeeBL stored in Employees)
                {
                    AddEmployee(stored);
                }
            }

            return empDeleted;
        }

        public void UpdateProfile(EmployeeBL employee) // update the profile of an employee in the file
        {
            List<EmployeeBL> Employees = GetAllEmployees();
            foreach (EmployeeBL stored in Employees)
            {
                if (stored.GetUsername() == employee.GetUsername())
                {
                    stored.UpdateProfile(employee);
                }
            }

            File.WriteAllText(FilePath, "");
            foreach (EmployeeBL stored in Employees)
            {
                AddEmployee(stored);
            }
        }
    }
}
