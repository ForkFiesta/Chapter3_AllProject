using EmployeeApp;

Employee emp = new Employee("Marvin", 45, 123,1000,"111-11-1111",EmployeePayTypeEnum.Salaried);
Console.WriteLine(emp.Pay);
emp.GiveBonus(100);
Console.WriteLine(emp.Pay);

