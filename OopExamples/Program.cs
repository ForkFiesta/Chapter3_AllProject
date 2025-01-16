using OopExamples;

Employee emp = new Employee("Marvin", 456, 30000);
emp.GiveBonus(1000);
emp.DisplayStats();


// Use the get/set methods to interact with the object
emp.SetName("Marv");
Console.WriteLine($"Employee is named: {emp.GetName()}");
Console.ReadLine();