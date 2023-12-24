using System.Text.RegularExpressions;
using Domain.Models;
namespace Infostructure.Services;

public class EmployeeService
{
  
  List<Employee> employees = new List<Employee>();

  public List<Employee> GetEmployees()
  {
    return employees;
  }
  public void AddEmployees(Employee employee)
  {
    employees.Add(employee);
  }
  public string UpdateEmployees(Employee _employee )
  {
     foreach (var emp in employees)
        {
            if (emp.Id == _employee.Id)
            {
                emp.FirstName = _employee.FirstName;
                emp.LastName = _employee.LastName;
                emp.BirthDate = _employee.BirthDate;
                return "Employee updated";
            }
        }
        return "Employee not found";
  }
  public string DeleteEmployees(int id )
  {
     foreach (var emp in employees)
        {
            if (emp.Id == id)
            {
                employees.Remove(emp);
                return "Employee deleted";
            }
        }
        return "Employee not found";
  }

  public int CountEmployees()
  {
    int cnt=0;
     foreach (var item in employees)
     {
        cnt ++; 
     }
     return cnt;
     
  }
  
}
