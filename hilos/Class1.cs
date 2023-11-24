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
            this.nombre = "";
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

            int i = 0;
            while ( i <= 5)
            {
                
                Console.WriteLine($"{nombre} Estan en el hilo alvvv.");

                Thread.Sleep(1000);
                i++;
            }
        }
    }
}
