using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopExamples
{
    public class Employee
    {
        private string _empName;
        private int _empId;
        private float _currPay;

        // Constructors
        public Employee() { }
        public Employee(string name, int id, float pay)
        {
            _empName = name;
            _empId = id;
            _currPay = pay;
        }

        // Methods

        // Properties
        public string Name
        {
            get { return _empName; }
            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine("Error! Name must be less than 16 characters!");
                }
                else
                {
                    _empName = value;
                }
            }
        }


        public void GiveBonus(float amount)
        {
            _currPay += amount;
        }
        public void DisplayStats()
        {
            Console.WriteLine($"Name: {_empName}");
            Console.WriteLine($"ID: {_empId}");
            Console.WriteLine($"Pay: {_currPay}");
        }

    }
}
