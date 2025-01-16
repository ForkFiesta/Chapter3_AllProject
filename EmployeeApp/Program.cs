using EmployeeApp;

Employee emp = new Employee("Marvin", 456, 30000);
emp.GiveBonus(1000);
emp.DisplayStats();

// Use the get/set methods to interact with the object.
emp.Name = "Marv";
Console.WriteLine("Employee is named: {0}", emp.Name);
emp.Age++;
Console.WriteLine("{0} is {1} years old.", emp.Name, emp.Age);
Console.ReadLine();


