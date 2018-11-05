using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_3.Practica_Evaluativa.Vacas
{
    class Program
    {
        static void Main(string[] args)
        {
            Operaciones obj = new Operaciones(); //Instanciamos un objeto de la clase Operaciones.
            obj.Vacas(); //Llamamos al método Vacas por medio del objeto.
            Console.ReadKey(); //Congela la pantalla.
        }
    }
}
