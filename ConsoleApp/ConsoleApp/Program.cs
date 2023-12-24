using Domain.Models;
using Infostructure.Services;

var DepartService = new DepartmentService();

while(true)
{
    System.Console.WriteLine("For creating department : list");
    System.Console.WriteLine("For creating department : add");
    System.Console.WriteLine("For creating department : edit");
    System.Console.WriteLine("For creating department : delete");
    System.Console.WriteLine("For creating department : exit");

    string command = System.Console.ReadLine();

    if (command == "list")
    {
        foreach (var item in DepartService.GetDepartments())
        {
            System.Console.WriteLine(item.Id);
            System.Console.WriteLine(item.Name);
            System.Console.WriteLine(item.Description);
            System.Console.WriteLine(item.Manager);
            System.Console.WriteLine();
        }
    }
    else if(command == "add")
    {
     var department1 = new Department();
     department1.Id = Convert.ToInt32(System.Console.ReadLine());
     department1.Name = System.Console.ReadLine();
     department1.Description = System.Console.ReadLine();
     department1.Manager = System.Console.ReadLine();
     DepartService.AddDepartments(department1);
    }
    else if(command == "edit")
    {
     var department1 = new Department();
     department1.Id = Convert.ToInt32(System.Console.ReadLine());
     department1.Name = System.Console.ReadLine();
     department1.Description = System.Console.ReadLine();
     department1.Manager = System.Console.ReadLine();
     System.Console.WriteLine( DepartService.UpdateDepartments(department1) );
    }
    else if(command == "delete")
    {
      int id = Convert.ToInt32(System.Console.ReadLine());
      System.Console.WriteLine(DepartService.DeleteDepartments(id));
    }
    else if(command == "exit")
    {
        break;
    }
}
System.Console.WriteLine(DepartService.CountDepartments());

// Employee ----------------------
var  EmpService = new EmployeeService();

while(true)
{
    System.Console.WriteLine("For creating employee : list");
    System.Console.WriteLine("For creating employee : add");
    System.Console.WriteLine("For creating employee : edit");
    System.Console.WriteLine("For creating employee : delete");
    System.Console.WriteLine("For creating employee : exit");

    string command = System.Console.ReadLine();

    if (command == "list")
    {
        foreach (var item in EmpService.GetEmployees())
        {
            System.Console.WriteLine(item.Id);
            System.Console.WriteLine(item.FirstName);
            System.Console.WriteLine(item.LastName);
            System.Console.WriteLine(item.BirthDate);
            System.Console.WriteLine();
        }
    }
    else if(command == "add")
    {
     var employee1 = new Employee();
     System.Console.Write("Enter employee ID : ");
     employee1.Id = Convert.ToInt32(System.Console.ReadLine());
     System.Console.Write("Enter employee name : ");
     employee1.FirstName = System.Console.ReadLine();
    System.Console.Write("Enter employee surname : ");
     employee1.LastName = System.Console.ReadLine();
      System.Console.Write("Enter employee birthday : ");
     employee1.BirthDate = Convert.ToInt32(System.Console.ReadLine());
     EmpService.AddEmployees(employee1);
    }
    else if(command == "edit")
    {
     var employee1 = new Employee();
     System.Console.Write("Enter employee ID : ");
     employee1.Id = Convert.ToInt32(System.Console.ReadLine());
     System.Console.Write("Enter employee name : ");
     employee1.FirstName = System.Console.ReadLine();
    System.Console.Write("Enter employee surname : ");
     employee1.LastName = System.Console.ReadLine();
      System.Console.Write("Enter employee birthday : ");
     employee1.BirthDate = Convert.ToInt32(System.Console.ReadLine());
     System.Console.WriteLine( EmpService.UpdateEmployees(employee1) );
    }
    else if(command == "delete")
    {
        System.Console.Write("Enter employee ID : ");
      int id = Convert.ToInt32(System.Console.ReadLine());
      System.Console.WriteLine(EmpService.DeleteEmployees(id));
    }
    else if(command == "exit")
    {
        break;
    }
}
System.Console.WriteLine(EmpService.CountEmployees());
