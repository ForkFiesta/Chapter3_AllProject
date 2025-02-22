﻿// Value type arguments are passed by value by default.
static int Add(int x, int y)
{
    int ans = x + y;
    // Caller will not see these changes
    // as you are modifying a copy of the
    // original data.
    x = 10000;
    y = 88888;
    return ans;
}


// Output parameters must be assigned by the called method.
static void AddUsingOutParam(int x, int y, out int ans)
{
    ans = x + y;
}

// Reference type arguments are passed by reference by default.
Console.WriteLine("***** Fun with Methods *****\n");
//// Pass two variables in by value.
//int x = 9, y = 10;
//Console.WriteLine("Before call: X: {0}, Y: {1}", x, y);
//Console.WriteLine("Answer is: {0}", Add(x, y));
//Console.WriteLine("After call: X: {0}, Y: {1}", x, y);
//Console.ReadLine
//int ans;

AddUsingOutParam(90, 90, out int ans);
Console.WriteLine("90 + 90 = {0}", ans);
Console.ReadLine(); 