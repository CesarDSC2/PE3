using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Operaciones
    {
        Stack<int> pila1 = new Stack<int>(); //Se crean 3 pilas (1 para cada torre).
        Stack<int> pila2 = new Stack<int>();
        Stack<int> pila3 = new Stack<int>();
        public int n;
        public Operaciones(int n) //Constructor que asigna la cantidad de discos a esta clase.
        {
            this.n = n;
        }
        public void Discos() //Procedimiento que genera los discos dependiendo de la elección del usuario.
        {
            for (int i = 1; i <= n; i++)
            {
                pila1.Push(i);
            }
        }

        public void Resolver() //Por medio de este método llamamos a Desplegar y a Mover.
        {
            Desplegar();
            Mover(n, pila1, pila2, pila3);
        }

        public void Mover(int n, Stack<int> pila1, Stack<int> pila2, Stack<int> pila3) //Algoritmo tipo recursivo para resolver.
        {
            if (n == 1)
            {
                pila2.Push(pila1.Pop());
                Desplegar();
                return;
            }
            else
            {
                Mover(n - 1, pila1, pila3, pila2);

                pila2.Push(pila1.Pop());
                Desplegar();
                Mover(n - 1, pila3, pila2, pila1);
            }
        }

        public void Desplegar()
        {
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("-    -   -   -   -   -   -   -");
            Stack<int>[] PilasJuntas = new Stack<int>[] { pila1, pila3, pila2 }; 
            for (int i = 0; i < 3; i++) 
            {
                foreach (var item in PilasJuntas[i])
                {
                    Console.Write(item + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-    -   -   -   -   -   -   -");
        }
    }
}