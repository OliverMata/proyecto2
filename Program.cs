using System;

namespace proyecto2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crea un programa que escriba en pantalla los números del 1 al 10, usando "do..while".
            int x=0;
            do
            {
                x=x+1;
                Console.Write("{0} - ", x);
                Console.ReadKey();

            } while (x<10);
            
        }
    }
}
