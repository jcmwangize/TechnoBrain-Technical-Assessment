using System;
using System.IO;
using EmployeeHierarchy;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string filepath = @"C:\JosephChege_TechAssessment\EmployeesFile.csv";
                StreamReader csvfileReader = new StreamReader(filepath);
                Console.WriteLine(csvfileReader.ReadToEnd());
                csvfileReader.Close();
            }
            catch (FileNotFoundException Ex)
            {
                Console.WriteLine("File {0} not found", Ex.FileName);
            }

            catch (Exception Ex)
            {
                Console.WriteLine( "General Error {0}",Ex.Message);
            }
            //Console.WriteLine("Test ABCD!");
            Employees E1 = new Employees("Joseph_Chege", "Collins", 123456);
        }
    }




    /*class Employees
    {    //Encapsulate the fields by using properties
        //fields Don't auto-implementso as to validate as requested during set
        string _employeeID; //{get; set;}
        string _ManagerID ; //{ get; set; }
        int _employeesalary; //{ get; set; }

       
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
            try
            {
                return 123;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static long salaryBudget()
        {
          
            try
            {
                return 123;
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
      */










}
