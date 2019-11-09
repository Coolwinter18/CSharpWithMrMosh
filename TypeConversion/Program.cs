using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 3 tipos de Conversiones
             * a) Implicita
             * b) Explcicita (cast)
             * c) usando Clase Convert (.Net) - para tipos no compatibles */
            // Implicita, el int i recibe un numero byte y lo convierte. Siempre se puede hacer si no va a haber perdida de datos.
            byte a = 1;
            int i = a; //la asignacion inversa no va a funcionar... va a dar error de compilacion.

            // Explicita, el byte b recibe un numero int j, hace casteo '(byte)' con posible perdida de dato.
            float j = 2.0f;
            byte b = (byte)j;
            
            // No compatible. 'string' no compatible con 'int'. Usamos la clase 'Convert' o el metodo de int para parsear 's'
            // el metodo Parse esta disponible para todos los tipos para tratar de convertir un string a ese tipo
            string s = "1234";
            int c = Convert.ToInt32(s);
            int d = int.Parse(s);
            //el inverso va a arrojar una excepcion por no poder convertir la cifra y almacenar un int en un byte
            byte g = Convert.ToByte((int)1234); //arroja excepcion de overflow, ya que el 'int' es mas grande de lo que soporta el tipo 'byte'
            
            
            //manejo de Excepciones.
            try
            {
                //coloco el codigo que quiero que se ejecute y controlar por excepciones
                g = Convert.ToByte((int)1234); //codigo de arriba que va a arrojar una excepcion
            }
            catch (Exception)
            {
                /*si el codigo de try arroja una excepcion, entonces va a ejecutar este Scope ('catch')*/

                //throw;
            }
        }
    }
}
