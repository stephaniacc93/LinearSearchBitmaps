using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearchBitmaps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantos numeros de bits quieres?");
            int numeroBits = int.Parse(Console.ReadLine());
            List<Byte> bites = new List<Byte>();

            for (int i = 0; i < numeroBits; i++)
            {
                Console.WriteLine("Escribe el numero para el espacio {0}", i + 1);
                Byte byteo = byte.Parse(Console.ReadLine());
                bites.Add(byteo);
            }

            Console.WriteLine("Que numero deseas encontrar?");
            Byte e = byte.Parse(Console.ReadLine());
            Byte [] abyte = bites.ToArray();
            int contador = 1;
            foreach (var b in abyte)
            {
                if (b == e)
                {
                    Console.WriteLine("El espacio de memoria en el que se encontro es el {0}", contador);
                }
                contador++;
            }
            Console.ReadLine();
        }
    }
}
