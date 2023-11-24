using hilos;
class Program
{
    static void Main()
    {
        Class1 jugador = new("Antonio");
        Class1 jugador2 = new("David");

        Thread jugadorThread = new Thread(jugador.Run);
        jugadorThread.Start();

        Thread jugador2Thread = new Thread(jugador2.Run);
        jugador2Thread.Start();

        //Console.WriteLine("Nombre del jugador: " + jugador.getNombre());



    }
}
