using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeHierarchy
{
    public class Employees
    {


        
        //fields Don't auto-implementso as to validate as requested during set
        string _employeeID; //{get; set;}
        string _ManagerID ; //{ get; set; }
        int _employeesalary; //{ get; set; }

       //Encapsulate the fields by using properties
        public void setEmployeeID(string employeeID)
        {
            this._employeeID = employeeID;
        }


        public string getEmployeeID()
        {
            return this._employeeID;
        }

        public void setManagerID(string ManagerID)
        {
            this._ManagerID = ManagerID;
        }


        public string getmanagerID()
        {
            return this._ManagerID;
        }
        
        
        public void setEmployeeSalary(int salary)
        {
            if (salary <= 0)
            {
                throw new Exception("Salary should be a valid Integer");
            }
            this._employeesalary = salary;
        }
        
        public int getEmployeeSalary() 
        { 
          return this._employeesalary;
        }

        //Constructor
        public Employees(string employeeID,  string ManagerID, int employeesalary)
        {
            this._employeeID = employeeID;
            this._ManagerID = ManagerID;
            this._employeesalary = employeesalary;

        }



        //Provide two Methods: 1-Expects a ManagerID and 2-Does not expect a managerID for the CEO
        public static long salaryBudget(string  ManagerID)
        {
            int totalsalaries = 0;
            try
            {
                //return 123;
                //while ()
                //{
                //}
                return totalsalaries;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static long salaryBudget()
        {

            int totalsalaries = 0;
            try
            {
                //return 123;
                //while ()
                //{
                //}
                return totalsalaries;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //destructor for garbage collection or to clean up resources
        //will be called automatically by the garbage collector
        ~Employees()
        {

        }
}
      

   

   
    }


