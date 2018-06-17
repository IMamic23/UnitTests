using System;
using System.Data.Entity;

namespace TestNinja.Mocking
{
    public class EmployeeController
    {
        private readonly EmployeeContext _db;

        public EmployeeController()
        {
            _db = new EmployeeContext();
        }

        public ActionResult DeleteEmployee(int id)
        {
            var employee = _db.Employees.Find(id);
            _db.Employees.Remove(employee ?? throw new NullReferenceException());
            EmployeeContext.SaveChanges();
            return RedirectToAction("Employees");
        }

        private static ActionResult RedirectToAction(string employees)
        {
            return new RedirectResult();
        }
    }

    public class ActionResult { }
 
    public class RedirectResult : ActionResult { }
    
    public class EmployeeContext
    {
        public DbSet<Employee> Employees { get; set; }

        public static void SaveChanges()
        {
        }
    }

    public abstract class Employee
    {
    }
}