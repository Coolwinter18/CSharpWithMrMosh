using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operaciones Aritmeticas
            /*
             * a+b
             * a*b
             * a/b
             * a%b (modulo)*/
            //Contadores 
            //Postfix Increment
            int a = 1;
            int b = a++;
            //Resultado a= 2 y b = 1 --> 'a++' primero asigna a 'b' y luego se incrementa

            //Prefix Incremento
            a = 1;
            b = ++a;
            //Resultado a= 2 y b= 2 --> '++a' primero incrementa y luego asigna a 'b'

            //Comparadores
            /* ==   'Igual'
             * !=   'Distinto'
             * >    'Mayor'
             * >=   'Mayor o Igual'
             * <    'Menor'
             * <=   'Menor o Igual'
             * */
            //Operaciones de Asignacion
            /*
             * =   Asignacion
             * +=  Asignacion de suma, 'a+=3' o 'a = a + 3'
             * -=  Asignacion de resta, 'a-=3' o 'a= a - 3'
             * *=  Asignacion de Multiplicacion 'a*=3' o 'a = a * 3'
             * /=  Asignacion de Division 'a/=3' o 'a = a / 3'
             * */
            /*Operaciones Logicas
             * &&   'And'   a && b
             * ||   'Or'    a || b    
             * !    'Not'   !a
             Operaciones Bit a Bit
             * &    'And'   a & b
             * |    'Or'    a | b
             */

            //Codigo de Ejemplo - uso doble letra porque ya estan definidos arriba los nombres en otros codigos de ejemplo.
            var aa = 1;
            var bb = 2;
            var cc = 3;
            Console.WriteLine( aa + bb);
            Console.WriteLine(aa / bb);//division entera
            Console.WriteLine((float)a/(float)b);//division real.
            Console.WriteLine(aa + bb * cc ); // respeta el orden matematico exponente, producto, division y suma/resta.
            Console.WriteLine(aa < cc && bb < cc); //ejemplo de comparacion



        }
    }
}
