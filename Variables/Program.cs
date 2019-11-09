using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Explicaciones de 
            /*
             * Si el tipo comienza con Mayuscula (ej: String) es un tipo que pertenece a .Net Framework
             * Si el tipo comienza con minuscula (ej: string) es un tipo que pertenece a C#
             */
            String unString = "Este string pertenece a .NET";
            string otroString = "Este String pertenece a C#";

            /*
             * __Convension de Nombres__
             * Camel Case: firstName
             *  _Primer paralabra minuscula,el resto de las palabras con mayusculas
             * Pascal Case: FirstName
             *  _Todas las palabras con mayusculas
             * Hungarian Notation: StrFirstName
             *  _tipo de variable y todas con mayusculas (str= tipo string)
            */

            /*
             * Reglas para definir tipos que no son double.
             * tipo float se le pone una 'f' al final del numero o sino el compilador solo reconoce el tipo double
             */
            float number5 = 1.2f;
            double number2 = 1.2;
            /*
             * tipo decimal se le pone una 'm' al final del numero o sino el compiladora solo reconoce el tipo double
             */
            decimal number3 = 1.2m;
            double number4 = number2;
            /*
             * Overflow - Cuando la variable supera su valor maximo*/
            byte aNumber = 255; // su valor maximo
            aNumber++; // 0
            //le sumo 1 y vuelvo a 0 por overflow.
            /*
             * para controlar el ovrflow, usamos la sentencia 'checked' a la porcion de codigo que queremos controlar el overflow*/
            checked
            {
                byte aNumber2 = 255;
                aNumber++; //va a lanzar una excepcion por overflow gracias al checked
            }
            //Casi nunca se usa.
            
            
            /*
             * Scope - Variables Globales y Locales.
             * Una variable global puede acceder en su mismo entorno o Scope y sus entornos Hijos.*/
            {
                byte a = 1;
                {
                    byte b = 2;
                    {
                        byte c = 3;
                    }
                }
            }
            /* el Scope donde se encuentra 'a' puede acceder a 'a' 'b' y 'c'
             * el Scope donde se encuentra 'b' puede acceder a 'b' y 'c'
             * el Scope donde se encuentra 'c' solo puede acceder a 'c'
             * si desde el Scope donde se encuentra 'b' o 'c' intento acceder a 'a', va a haber error de compilacion*/

            //Ejemplos de Codigo
            byte numero = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Mosh";
            bool isWorking = false;
            Console.WriteLine(numero);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            //tipos implicitos tipo 'var' detecta el tipo en funcion del contenido.
            var numeroVar = 2; //los numeros enteros los detecta como int... no byte ni otros.
            var countVar = 10;
            var totalPriceVar = 20.95f;
            var characterVar = 'A';
            var firstNameVar = "Mosh";
            var isWorkingVar = false;
            Console.WriteLine(numeroVar);
            Console.WriteLine(countVar);
            Console.WriteLine(totalPriceVar);
            Console.WriteLine(characterVar);
            Console.WriteLine(firstNameVar);
            Console.WriteLine(isWorkingVar);
            //sobre valores maximos y minimos
            Console.WriteLine("{ 0}{ 1}",byte.MinValue,byte.MaxValue);
            Console.WriteLine("{ 0}{ 1}",float.MinValue,float.MaxValue);
            //sobre constantes 
            const float Pi = 3.14f;
            //Pi = 1; 
            //instruccion no permitida... no puede asignarse algo a una constante.


        }
    }
}
