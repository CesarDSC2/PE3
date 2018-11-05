using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_3_Practica_Evaluativa
{
    class Program
    {
        static void Main(string[] args)
        {
            Operaciones obj = new Operaciones(); //Instanciamos un objeto de la clase Operaciones.
            obj.Tareas(); //Mandamos a llamar al metodo "Tareas" por medio de este objeto.
            Console.ReadKey(); //Congelar la pantalla.
        }
    }
}
