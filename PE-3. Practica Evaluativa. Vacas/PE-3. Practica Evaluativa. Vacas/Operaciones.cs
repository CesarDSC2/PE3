using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_3.Practica_Evaluativa.Vacas
{
    class Operaciones
    {
        public void Vacas()
        {
            y: //Marca.
            Console.Clear();
            int opc = 0;
            Console.WriteLine("1.-Jugar. \n2.-Ver respuesta.");  
            Console.Write("Opción: ");
            opc = Convert.ToInt32(Console.ReadLine());
            List<string> lista1 = new List<string>(); //Creamos una lista tipo string de los elementos que aún no cruzan el puente.
            lista1.Add("Mazie"); //Añadimos elementos a la lista.
            lista1.Add("Daisy");
            lista1.Add("Crazy");
            lista1.Add("Lazy");
            List<string> lista2 = new List<string>(); //Creamos una segunda lista en donde se encuentran los elementos que ya cruzaron el puente.

            switch (opc) //Menu.
            {
                case 1: //Elige jugar.
                    int suma = 0;
                    string opc3 = "", opc1 = "", opc2 = "";                    

                    x:
                    Console.Clear();
                    Console.WriteLine("Supongamos que Bob tiene cuatro vacas que quiere cruzar por un puente, pero solo un yugo, que puede sostener \nhasta dos vacas, lado a lado, atadas al yugo.El yugo es demasiado pesado para que lo lleve a través del puente, \npero puede atar(y desatar) vacas a él en muy poco tiempo.De sus cuatro vacas, Mazie puede cruzar el puente en 2 minutos,Daisy puede cruzarlo en 4 minutos, Crazy puede cruzarlo en 10 minutos y Lazy puede cruzar en 20 minutos.\nPor supuesto, cuando dos vacas están atadas al yugo, deben ir a la velocidad de la vaca más lenta.\nDescribe cómo Bob puede conseguir que todas sus vacas crucen el puente en 34 minutos.");
                    Console.WriteLine("-    -   -   -   -   -   -   -   -   -   -");
                    //Tiempo transcurrido.
                    Console.WriteLine("\t\t\t\t\tTiempo: " + suma);
                    Console.WriteLine();
                    //Imprime los elementos.
                    foreach (var item in lista1)
                    {
                        Console.WriteLine("'{0}'", item);

                    }
                    Console.Write("\nIngresa el nombre de la primer vaca que va a cruzar: "); //Aqui el usuario ingresa que vaca quiere cruzar primero.
                    opc1 = Console.ReadLine();
                    Console.Write("\nIngresa nombre de la segunda vaca que va a cruzar: "); //Aqui el usuario ingresa que vaca quiere cruzar despues.
                    opc2 = Console.ReadLine();

                    if (opc1 == "Mazie" || opc1 == "Daisy" && opc2 == "Daisy" || opc2 == "Mazie") //Por medio de ciclos "if" dependiendo de la opción del usuario
                        //añadir o eliminar elementos a las listas.
                    {
                        lista1.Remove("Mazie");
                        lista1.Remove("Daisy");
                        lista2.Add("Mazie");
                        lista2.Add("Daisy");
                        Console.Clear();
                        Console.WriteLine("Ya cruzaron el puente:");
                        foreach (var item in lista2)
                        {
                            Console.Write(item + " ; ");
                        }
                        suma += 4;
                        Console.WriteLine("Han pasado: " + suma + " minutos");
                    }
                    else if (opc1 == "Mazie" || opc1 == "Crazy" && opc2 == "Crazy" || opc2 == "Mazie")
                    {
                        lista1.Remove("Mazie");
                        lista1.Remove("Crazy");
                        lista2.Add("Mazie");
                        lista2.Add("Crazy");
                        Console.Clear();
                        Console.WriteLine("Ya cruzaron el puente:");
                        foreach (var item in lista2)
                        {
                            Console.Write(item + " ; ");
                        }
                        suma += 10;
                        Console.WriteLine();
                        Console.WriteLine("Han pasado: " + suma + " minutos");
                    }
                    else if (opc1 == "Mazie" || opc1 == "Lazy" && opc2 == "Lazy" || opc2 == "Mazie")
                    {
                        lista1.Remove("Mazie");
                        lista1.Remove("Lazy");
                        lista2.Add("Mazie");
                        lista2.Add("Lazy");
                        Console.Clear();
                        Console.WriteLine("Ya cruzaron el puente:");
                        foreach (var item in lista2)
                        {

                            Console.Write(item + " - ");
                        }
                        suma += 20;
                        Console.WriteLine("Han pasado: " + suma + " minutos");
                    }
                    else if (opc1 == "Daisy" || opc1 == "Crazy" && opc2 == "Crazy" || opc2 == "Daisy")
                    {
                        lista1.Remove("Daisy");
                        lista1.Remove("Crazy");
                        lista2.Add("Daisy");
                        lista2.Add("Crazy");
                        Console.Clear();
                        Console.WriteLine("Ya cruzaron el puente:");
                        foreach (var item in lista2)
                        {

                            Console.Write(item + " - ");
                        }
                        suma += 10;
                        Console.WriteLine("Han pasado: " + suma + " minutos");
                    }
                    else if (opc1 == "Daisy" || opc1 == "Lazy" && opc2 == "Lazy" || opc2 == "Daisy")
                    {
                        lista1.Remove("Daisy");
                        lista1.Remove("Lazy");
                        lista2.Add("Daisy");
                        lista2.Add("Lazy");
                        Console.Clear();
                        Console.WriteLine("Ya cruzaron el puente:");
                        foreach (var item in lista2)
                        {

                            Console.Write(item + " - ");
                        }
                        suma += 20;
                        Console.WriteLine("\nHan pasado: " + suma + " minutos");
                    }
                    else if (opc1 == "Crazy" || opc1 == "Lazy" && opc2 == "Lazy" || opc2 == "Crazy")
                    {
                        lista1.Remove("Crazy");
                        lista1.Remove("Lazy");
                        lista2.Add("Crazy");
                        lista2.Add("Lazy");
                        Console.Clear();
                        Console.WriteLine("Ya cruzaron el puente:");
                        foreach (var item in lista2)
                        {

                            Console.Write(item + " - ");
                        }
                        suma += 20;
                        Console.WriteLine("\nHan pasado: " + suma + " minutos");
                    }
                    else 
                    {
                        Console.WriteLine("Respeta mayúsculas y minúsculas. \nIntentalo de nuevo.");
                        goto x; //Regresa a la marca.
                    }

                    if (suma == 34 && lista1.Count < 1) //Cuando la suma es igual a 34 y ya no hay elementos en la lista 1 (sin cruzar el puente) se gana el juego.
                    {
                        Console.WriteLine("Lo has hecho correctamente, felicicidades !");
                    }
                    else if (suma < 34) //Mientras la suma sea menor a 34 (minutos) aún puedes mover vacas.
                    {
                        Console.WriteLine("\n~ Tienes que regresar una vaca con el yugo ~");
                        Console.WriteLine("¿Qué vaca quieres regresar?: ");
                        //Imprime las opciones al usuario disponibles (las vacas que ya cruzaron).
                        foreach (var item in lista2)
                        {
                            Console.WriteLine("{0}", item);

                        }
                        Console.Write("Opción: ");
                        opc3 = Console.ReadLine();
                        if (opc3 == "Mazie") //Por medio de ciclos "if" dependiendo de la opción del usuario
                        //añadir o eliminar elementos a las listas.
                        {
                            lista2.Remove("Mazie");
                            lista1.Add("Mazie");
                            suma += 2;
                            Console.WriteLine("Han pasado: " + suma + " minutos");
                        }
                        else if (opc3 == "Daisy")
                        {
                            lista2.Remove("Daisy");
                            lista1.Add("Daisy");
                            suma += 4;
                            Console.WriteLine("Han pasado: " + suma + " minutos");
                        }
                        else if (opc3 == "Crazy")
                        {
                            lista2.Remove("Crazy");
                            lista1.Add("Crazy");
                            suma += 10;
                            Console.WriteLine("Han pasado: " + suma + " minutos");
                        }
                        else if (opc3 == "Lazy")
                        {
                            lista2.Remove("Lazy");
                            lista1.Add("Lazy");
                            suma += 20;
                            Console.WriteLine("Han pasado: " + suma + " minutos");
                        }
                        if (suma > 34)
                        {
                            Console.WriteLine("Has perdido, te has excedido a {0}", suma);
                        }
                        else
                        {
                            goto x;
                        }

                    }
                    else //Si la suma no es igual o no es menor a 34, significa que ya se ha excedido el tiempo límite.
                    {
                        Console.WriteLine("Te has excedido del límite de tiempo.");
                    }
                    break;
                case 2: //Despliega la manera en que se resuelve el acertijo.
                    Console.Clear();
                    int suma2 = 0;                                                                   
                    Console.WriteLine("-    -   TIEMPO: {0}    -   -", suma2); //Suma el tiempo transcurrido.
                    foreach (var item in lista1) //Despliega los elementos que hay en la lista 1 (antes de cruzar el puente).
                    {
                        Console.WriteLine(item);
                    }
                    Console.Write("\nEnter..");
                    Console.ReadKey();
                    Console.Clear();
                    lista1.Remove("Mazie"); //Remueve y añade elementos a la lista 1 y 2.
                    lista1.Remove("Daisy");
                    lista2.Add("Mazie");
                    lista2.Add("Daisy");
                    suma2 += 4; //Se suma el valor de la vaca más lenta.
                    Console.WriteLine("-    -   TIEMPO: {0}    -   -", suma2);
                    foreach (var item in lista1) //Despliega elementos de la lista 1.
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("-    -   -   -   - >");
                    foreach (var item in lista2) //Despliega elementos de la lista 2.
                    {
                        
                        Console.WriteLine(item);
                    }
                    Console.Write("\nEnter..");
                    Console.ReadKey();//Por medio de Console.ReadKey() el usuario va interactuando con el programa, a medida que presiona una tecla, el programa se
                    //va resolviendo.
                    Console.Clear();
                    lista2.Remove("Mazie");
                    lista1.Add("Mazie");
                    suma2 += 2;
                    Console.WriteLine("-    -   TIEMPO: {0}    -   -", suma2);
                    foreach (var item in lista1)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("-    -   -   -   - >");
                    foreach (var item in lista2)
                    {

                        Console.WriteLine(item);
                    }
                    Console.Write("\nEnter..");
                    Console.ReadKey();
                    Console.Clear();
                    lista1.Remove("Crazy");
                    lista1.Remove("Lazy");
                    lista2.Add("Crazy");
                    lista2.Add("Lazy");
                    suma2 += 20;
                    Console.WriteLine("-    -   TIEMPO: {0}    -   -", suma2);
                    foreach (var item in lista1)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("-    -   -   -   - >");
                    foreach (var item in lista2)
                    {

                        Console.WriteLine(item);
                    }
                    Console.Write("\nEnter..");
                    Console.ReadKey();
                    Console.Clear();
                    lista2.Remove("Daisy");
                    lista1.Add("Daisy");
                    suma2 += 4;
                    Console.WriteLine("-    -   TIEMPO: {0}    -   -", suma2);
                    foreach (var item in lista1)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("-    -   -   -   - >");
                    foreach (var item in lista2)
                    {

                        Console.WriteLine(item);
                    }
                    Console.WriteLine("\nEnter..");
                    Console.ReadKey();
                    Console.Clear();
                    lista1.Remove("Mazie");
                    lista1.Remove("Daisy");
                    lista2.Add("Mazie");
                    lista2.Add("Daisy");
                    suma2 += 4;
                    Console.Write("-    -   TIEMPO: {0}    -   -", suma2);
                    foreach (var item in lista1)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("-    -   -   -   - >");
                    foreach (var item in lista2)
                    {

                        Console.WriteLine(item);
                    }
                    Console.Write("\nFin del juego..");
                    Console.ReadKey();
                    Console.Clear();

                    goto y;
                    break;
                default:
                    Console.WriteLine("Ingrese una opción válida.");
                    break;
            }
        }
    }
}
