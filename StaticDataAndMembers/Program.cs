using StaticDataAndMembers;

Console.WriteLine("***** Fun with Static Data *****\n");
SavingsAccount s1 = new SavingsAccount(50);
SavingsAccount s2 = new SavingsAccount(100);
Console.WriteLine("Setting interest rate to 0.08");
SavingsAccount s3 = new SavingsAccount(10000.75);
// Examples of using a static class.
TimeUtilClass.PrintDate();
TimeUtilClass.PrintTime();
Console.ReadLine();