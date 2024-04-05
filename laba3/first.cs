using laba3;

Company company = new Company();
company.Title = "Пивоварня";
Console.WriteLine(company.Title);

Department department = new Department();
department.Title = "Варщик";
department.Number_of_employees = 1;
Console.WriteLine(department.Title);
Console.WriteLine(department.Number_of_employees);

Employee employee = new Employee();
employee.Full_name = "Бахтеев Максим Александрович";
employee.Position = "Директор";
employee.Salary = 1_000_000;
Console.WriteLine(employee.Full_name);
Console.WriteLine(employee.Position);
Console.WriteLine(employee.Salary);