using Domain.Models;
namespace Infostructure.Services;

public class DepartmentService
{
  
  List<Department> departments = new List<Department>();

  public List<Department> GetDepartments()
  {
    return departments;
  }
  public void AddDepartments(Department employee)
  {
    departments.Add(employee);
  }
  public string UpdateDepartments(Department _department )
  {
     foreach (var depart in departments)
        {
            if (depart.Id == _department.Id)
            {
                depart.Name = _department.Name;
                depart.Description = _department.Description;
                depart.Manager = _department.Manager;
                return "Department updated";
            }
        }
        return "Department not found";
  }
  public string DeleteDepartments(int id )
  {
     foreach (var depart in departments)
        {
            if (depart.Id == id)
            {
                departments.Remove(depart);
                return "Department deleted";
            }
        }
        return "Department not found";
  }

  public int CountDepartments()
  {
    int cnt=0;
     foreach (var item in departments)
     {
        cnt ++; 
     }
     return cnt;
     
  }
  
}

