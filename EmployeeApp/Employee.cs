using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Employee
    {
        // Field data.
        private string _empName = string.Empty;
        private int _empID;
        private float _currPay;
        private int _empAge;
        private string _empSSN = string.Empty;
        private EmployeePayTypeEnum _payType;
        private DateTime _hireDate;


        // Properties
        // 

        public DateTime HireDate
        {
            get { return _hireDate; }
            set { _hireDate = value; }
        }
        public EmployeePayTypeEnum PayType
        {
            get { return _payType; }
            set { _payType = value; }
        }
        public string SocialSecurityNumber
        {
            get { return _empSSN; }
            private set { _empSSN = value; }
        }

        public int Age
        {
            get { return _empAge; }
            set { _empAge = value; }
        }
        public string Name
        {
            get { return _empName; }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Error! Name length exceeds 15 characters!");
                else
                    _empName = value;
            }
        }
        public int ID
        {
            get { return _empID; }
            set { _empID = value; }
        }
        public float Pay
        {
            get { return _currPay; }
            set { _currPay = value; }
        }

        // Constructors.
        public Employee() { }
        public Employee(string name, int id, float pay, string empSsn)
            : this(name, 0, id, pay, empSsn, EmployeePayTypeEnum.Salaried) { }
        public Employee(string name, int age, int id, float pay, string empSsn, EmployeePayTypeEnum payType  )
        {
            Name = name;
            Age = age;
            ID = id;
            Pay = pay;
            SocialSecurityNumber = empSsn;
            PayType = payType;
        }

        

        // Methods.
        public void GiveBonus(float amount)
        {
            //PENDING: ADD SWITCH STATEMENT TO HANDLE DIFFERENT PAY TYPES - page 215 on pdf
            Pay = this switch
            {
                {Age: >= 18, PayType: EmployeePayTypeEnum.Commission, HireDate.Year: > 2020 }
                => Pay += .10F * amount,
                {Age: >= 18, PayType: EmployeePayTypeEnum.Hourly, HireDate.Year: > 2020 }
                => Pay += 40F * amount / 2080F,
                {Age: >= 18, PayType: EmployeePayTypeEnum.Salaried, HireDate.Year: > 2020}
                => Pay += amount,
               _ => Pay += 0
                
            };
        }
        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", _empName);
            Console.WriteLine("ID: {0}", _empID);
            Console.WriteLine("Age: {0}", _empAge);
            Console.WriteLine("Pay: {0}", _currPay);
        }
    }
}
