using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_3_Practica_Evaluativa
{
    class Operaciones
    {
        public void Tareas()
        {
            int opc = 0, opc2 = 0, opc3 = 0; //Declaramos variables auxiliares.
            string id = "", nombretarea = "", descripcion = "", fechainicio = "", fechafin = "", id2 = ""; 
            List<Global> global = new List<Global>(); //Creamos una listo de tipo <Clase> para cada una (global, pendiente, etc.)
            List<Pendiente> pendiente = new List<Pendiente>();
            List<Proceso> proceso = new List<Proceso>();
            List<Finalizado> finalizado = new List<Finalizado>();
            x: //Una marca para volver.
            Console.WriteLine("Enter...");
            Console.ReadKey();
            Console.Clear();
            Console.Write("Seleccione la opción: \n1.-Ver tareas. \n2.-Agregar tarea. \nOpción: "); //Menu.
            opc = Convert.ToInt32(Console.ReadLine());

            //Por medio de ciclos "If" anidados, el usuario elige que tipo de lista quiere observar.
            if (opc == 1) //Usuario elige "Ver tarea".
            {
                Console.Write("1.-Lista global. \n2.-Lista de pendiente. \n3.-Lista de en proceso. \n4.-Lista de finalizado. \n5.-Buscar por 'ID' \nOpción: ");
                opc2 = Convert.ToInt32(Console.ReadLine());
                if (opc2 == 1)
                {
                    foreach (Global item in global) //Imprime todos los elementos con sus atributos.
                    {
                        Console.WriteLine(item);
                        if (item.fechaFin == "0" && item.fechaInicio != "0") 
                        {
                            Console.WriteLine("-    -   PROCESO    -   -");
                        }
                        else if (item.fechaInicio == "0")
                        {
                            Console.WriteLine("-    -   PENDIENTE    -   -");
                        }
                        else if (item.fechaInicio != "0" && item.fechaFin != "0")
                        {
                            Console.WriteLine("-    -   FINALIZADO    -   -");
                        }
                    }
                    goto x; //Va hacia la marca.
                }
                else if (opc2 == 2) //Imprime los elementos de la lista pendiente.
                {
                    foreach (Pendiente item in pendiente)
                    {
                        Console.WriteLine(item);
                    }
                    goto x;
                }
                else if (opc2 == 3) //Imprime los elementos de la lista de en proceso.
                {
                    foreach (Proceso item in proceso)
                    {
                        Console.WriteLine(item);
                    }
                    goto x;
                }
                else if (opc2 == 4) //Imprime los elementos de la lista de finalizado.
                {
                    foreach (Finalizado item in finalizado)
                    {
                        Console.WriteLine(item);
                    }
                    goto x;
                }
                if (opc2 == 5) //Hace una consulta por medio del "ID".
                {
                    Console.Clear();
                    Console.Write("Ingrese el 'ID' de la tarea que desea consultar: ");
                    id2 = Console.ReadLine();

                    var IDT = (from c in global //Utilizamos LINQ para consultar un elemento.
                                   where c.ID == id2
                                   select c).ToList();
                    foreach (var item in IDT) //Imprime el elemento del ID introducido.
                    {
                        Console.WriteLine("* * * * * * * *"); 
                        //Imprimimos los atributos del elemento consultado.
                        Console.WriteLine("ID: " + item.ID + "\nTarea: " + item.Nombre + "\nDescripción: " + item.Descripción + "\nFecha de inicio: " + item.fechaInicio + "\nFecha de finalizado: " + item.fechaFin);

                        if (item.fechaInicio == "0") //Si la fecha de inicio es igual a "0", significa que no está iniciado, por lo tanto pertenece a Pendiente.
                        {
                            Console.WriteLine("-    -   PENDIENTE   -   -");
                            Console.WriteLine("\n¿A qué lista lo quieres mover? \n1.-Lista de en proceso. \n2.-Ninguno (salir).");
                            opc3 = Convert.ToInt32(Console.ReadLine());
                            if (opc3 == 1)
                            {
                                Console.Write("Indica la fecha de inicio: ");
                                proceso.Add(new Proceso() { ID = item.ID, Nombre = item.Nombre, Descripción = item.Descripción, fechaInicio = Console.ReadLine(), fechaFin = item.fechaFin });
                                global.Add(new Global() { ID = item.ID, Nombre = item.Nombre, Descripción = item.Descripción, fechaInicio = Console.ReadLine(), fechaFin = item.fechaFin });
                            }
                            else if (opc3 == 2)
                            {

                            }
                            else
                            {
                                Console.WriteLine("Ingrese una opción válida.");
                            }
                        }
                        else if(fechainicio != "0") //Si la fecha de inicio es distinta a "0", significa que ya tiene una fecha asignada, por lo tanto pertenece a En Proceso.
                        {
                            Console.WriteLine("-    -   PROCESO    -   -");
                            Console.Write("Indica la fecha de fin (o ingrese '0' para salir): ");
                            string fin = Console.ReadLine();
                            if (fin == "0")
                            {

                            }
                            else
                            {
                                finalizado.Add(new Finalizado() { ID = item.ID, Nombre = item.Nombre, Descripción = item.Descripción, fechaInicio = item.fechaInicio, fechaFin = fin });
                                global.Add(new Global() { ID = item.ID, Nombre = item.Nombre, Descripción = item.Descripción, fechaInicio = item.fechaInicio, fechaFin = fin });
                            }
                            
                        }
                        else if (item.fechaFin != "0") //Si la fecha de fin es distinta a "0", significa que la fecha esta asignada, por lo tanto pertenece a Finalizado.
                        {
                            Console.WriteLine("-    -   FINALIZADO   -   -");
                        }
                    }
                    goto x; //Marca.
                }
                else
                {
                    Console.WriteLine("Ingrese una opción válida.");
                    goto x;
                }
            }
            else if (opc == 2) //Usuario elige "Agregar tarea".
            {
                for (int i = 0; i < 1; i++)
                {
                    Console.Clear();
                    Console.WriteLine("* Agregar tarea *");
                    Console.Write("Ingrese el ID de la tarea: "); //Ciclo "For" para captura de los atributos.
                    id = Console.ReadLine();
                    for (int j = 0; j < 1; j++)
                    {
                        Console.Write("Ingrese el nombre de la tarea: ");
                        nombretarea = Console.ReadLine();
                        for (int k = 0; k < 1; k++)
                        {
                            Console.Write("Ingrese una descripción: ");
                            descripcion = Console.ReadLine();
                            for (int l = 0; l < 1; l++)
                            {
                                Console.Write("Ingrese la fecha de inicio (dd/mm/aaaa)\nSi no se va a inciar aún, ingrese '0': ");
                                fechainicio = Console.ReadLine();
                            }
                            if (fechainicio != "0") //Fecha de inicio asignada, da oportunidad de asignar fecha de fin.
                            {
                                for (int m = 0; m < 1; m++)
                                {
                                    Console.Write("Ingrese la fecha de fin (dd/mm/aaaa)\nSi no se va a finalizar aún, ingrese '0': ");
                                    fechafin = Console.ReadLine();
                                }
                            }
                            else //Si la fecha de inicio no esta asignada, fecha de fin tampoco puede ser asignada.
                            {
                                fechafin = "0";
                            }
                            
                        }
                    }
                    if (fechainicio == "0") //Si fecha de inicio es igual a "0" pertenece a Pendiente.
                    {
                        pendiente.Add(new Pendiente() { ID = id, Nombre = nombretarea, Descripción = descripcion, fechaInicio = fechainicio, fechaFin = fechafin });
                        global.Add(new Global() { ID = id, Nombre = nombretarea, Descripción = descripcion, fechaInicio = fechainicio, fechaFin = fechafin });
                    }
                    else if (fechafin != "0") //Si fecha de fin es distinto a "0" significa que la fecha de inicio y fin estan asignadas, por lo tanto pertenece a Finalizado.
                    {
                        finalizado.Add(new Finalizado() { ID = id, Nombre = nombretarea, Descripción = descripcion, fechaInicio = fechainicio, fechaFin = fechafin });
                        global.Add(new Global() { ID = id, Nombre = nombretarea, Descripción = descripcion, fechaInicio = fechainicio, fechaFin = fechafin });
                    }
                    else //Si la fecha de inicio no es 0, y la fecha de fin no esta asignada, pertenece a En Proceso.
                    {
                        proceso.Add(new Proceso() { ID = id, Nombre = nombretarea, Descripción = descripcion, fechaInicio = fechainicio, fechaFin = fechafin });
                        global.Add(new Global() { ID = id, Nombre = nombretarea, Descripción = descripcion, fechaInicio = fechainicio, fechaFin = fechafin });
                    }
                }
                goto x;
            }

            else
            {
                Console.WriteLine("Ingrese una opción válida.");
                goto x;
            }
        }


    }
}
