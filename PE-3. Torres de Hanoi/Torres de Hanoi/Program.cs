using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Ingrese numero de discos: "); //ingresamos numero de discos
            n = int.Parse(Console.ReadLine());

            Console.Clear();

            Operaciones obj = new Operaciones(n); //Instanciamos un objeto de la clase Operaciones y mandamos un párametro que es el número de discos.
            obj.Discos(); //Se llama el método Discos.
            obj.Resolver();  //Se llama al método Resolver.

            Console.ReadKey();
        }
    }
}
