// Note we are explicitly returning an int, rather than void.

// Display a simple message on the console.
Console.WriteLine("***** My First C# App *****");
Console.WriteLine("Hello World!");
Console.WriteLine();
// Process any incoming args.
for (int i = 0; i < args.Length; i++)
{
    Console.WriteLine("Arg: {0}", args[i]);
}


Console.ReadLine();
// Return an arbitrary error code.
return 0;