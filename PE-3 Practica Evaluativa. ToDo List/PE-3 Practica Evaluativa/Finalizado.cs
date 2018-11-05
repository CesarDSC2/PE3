using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_3_Practica_Evaluativa
{
    class Finalizado
    {
        public string ID { get; set; } //Propiedades de la clase.
        public string Nombre { get; set; }
        public string Descripción { get; set; }
        public string fechaInicio { get; set; }
        public string fechaFin { get; set; }

        public override string ToString() //Modificador de acceso "Override" para imprimir los atributos que han sido asignados a esta clase.
        {
            Console.WriteLine("*    *   *   *   *   *   *   *   *   *");
            return "ID: " + ID + "\nTarea: " + Nombre + "\nDescripción: " + Descripción + "\nFecha de inicio: " + fechaInicio + "\nFecha de finalizado: " + fechaFin;
        }

        public Finalizado()//Constructor de la clase.
        {

        }
    }
}
