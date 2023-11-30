using hilos;
class Program
{
    static void Main()
    {
        Class1 jugador = new();
        

        Thread jugadorThread = new Thread(jugador.Run);
        jugadorThread.Start();

    }
}
