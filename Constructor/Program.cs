using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Customer
    {
        //atributos
        public int Id;
        public string Name;
        //constructores
        public Customer() //constructor
        {

        }
        public Customer(string name) //otro constructor
        {
            this.Name = name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer("John");

        }
    }
}
