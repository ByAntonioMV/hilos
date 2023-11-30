using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace hilos
{
    public class Class1
    {
        
        private String nombre;
        
        public Class1(String nombre)
        {
            this.nombre = nombre;
        }
        public Class1()
        {
            this.nombre = "Antonio";
       
        }
        public void SetNombre(String nombre)
        {
            this.nombre = nombre;
        }
        public String getNombre()
        {
            return this.nombre;
        }
        public void Run()
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 4);


            if (numeroAleatorio  == 1)
            {
                Console.WriteLine("Antonio es el delantero");
               
                int n1 = random.Next(1, 3);
               
                if (n1 == 1)
                {
                    Console.WriteLine("Se la paso a ");
                }
                else if (n1 == 2)
                {
                    Console.WriteLine("Cometio falta");
                }
                else if (n1 == 3)
                {
                    Console.WriteLine("Goolll");
                }
            }
            else if (numeroAleatorio == 2)
            {
                Console.WriteLine("David es el Medio");
                int n1 = random.Next(1, 3);

                if (n1 == 1)
                {
                    Console.WriteLine("Se la paso a ");
                }
                else if (n1 == 2)
                {
                    Console.WriteLine("Cometio falta");
                }
                else if (n1 == 3)
                {
                    Console.WriteLine("Goolll");
                }

            }
            else if (numeroAleatorio == 3)
            {
                Console.WriteLine("Brayan es el Defensa");
                int n1 = random.Next(1, 3);

                if (n1 == 1)
                {
                    Console.WriteLine("Se la paso a ");
                }
                else if (n1 == 2)
                {
                    Console.WriteLine("Cometio falta");
                }
                else if (n1 == 3)
                {
                    Console.WriteLine("Goolll");
                }
            }
            else if (numeroAleatorio == 4)
            {
                Console.WriteLine("Eliseo es el Portero");
                int n1 = random.Next(1, 3);

                if (n1 == 1)
                {
                    Console.WriteLine("Se la paso a ");
                }
                else if (n1 == 2)
                {
                    Console.WriteLine("Cometio falta");
                }
                else if (n1 == 3)
                {
                    Console.WriteLine("Goolll");
                }
            }
        }
    }
}
