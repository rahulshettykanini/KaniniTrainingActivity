using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class CustomerInfo
    {
        private int cust_id;
        private string name;
        private int age;
        private string address;

        public CustomerInfo(int cust_id, string name, int age, string address)
        {
            this.Cust_id= cust_id;
            this.Name= name;
            this.Age= age;
            this.Address= address;
        }

        
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Address { get => address; set => address = value; }
        public int Cust_id { get => cust_id; set => cust_id = value; }

        public virtual void Display()
        {
            Console.WriteLine(this.Cust_id);
            Console.WriteLine(this.Name);
            Console.WriteLine(this.Age);
            Console.WriteLine(this.Address);
        }
    }
}
