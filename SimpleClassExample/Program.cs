using SimpleClassExample;

Console.WriteLine("***** Fun with Class Types *****\n");

// Allocate and configure a Car object.
bool inDanger;
Car myCar = new Car("Terry", 10, out inDanger);
Motorcycle myBike = new Motorcycle(5);
//myCar.petName = "Henry";
//myCar.currSpeed = 10;

// Speed up the car a few times and print out the new state.
for (int i = 0; i <= 20; i++)
{
    myCar.SpeedUp(5);
    myCar.PrintState();
    Console.WriteLine("Is the car in danger? {0}", myCar.IsInDanger());
}

// Now make my Motorcycle known to the world.
myBike.driverIntensity = 10;
myBike.PopAWheely();

Console.ReadLine();