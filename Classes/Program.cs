using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        class Person
        {
            public string Name;

            //metodo de Instancia - se accede desde un objeto en particular
            public void Introduce(string to)
            {
                Console.WriteLine("Hi {0}, my name is {1}",to,this.Name);
            }
            //metodo de Clase - Se accede desde la clase
            public static Person Parse(string str)
            {
                var person = new Person();
                person.Name = str;
                return person;
                
            }
        }
        static void Main(string[] args)
        {
            // Clases. 
            //2 maneras iguales de instanciar objetos de la clase Person
            Person person1 = new Person();
            var person2 = new Person();
            //asignacion de atributos
            person1.Name = "Eduardo";
            //metodo de instancia
            person1.Introduce("Mosh");
            //metodo de clase
            var p = Person.Parse("Eduardo");
            //metodo de instancia
            p.Introduce("Mosh");
        }
        
    }
}
