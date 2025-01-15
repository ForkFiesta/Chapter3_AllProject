using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Motorcycle
    {
        public int driverIntensity;

        // New members to represent the name of the driver.
        // Note that if there is no ambiguity, you can use the same name for a member as a parameter.
        public string name;
        public void SetDriverName(string name)
        {
            this.name = name;
        }

        public void PopAWheely()
        {
            for (int i = 0; i <= driverIntensity; i++)
            {
                Console.WriteLine("Yeeeeeee Haaaaaeewww!");
            }
        }

        // Put back the default constructor, which will set all data members to default values.
        public Motorcycle() { }
        public Motorcycle(int intensity)
        {
            driverIntensity = intensity;
        }





    }
}
