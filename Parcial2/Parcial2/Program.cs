public class Program
{
    private static void Main(string[] args)
    {
        // Parcial 2, (Adivina el número)

        //Inicialización código

        {
            do
            {
                Console.Clear();
                Console.WriteLine("¡Bienvenido al juego 'Adivina el número'!");

                int numeroDeJugadores;

                do
                {
                    Console.Write("Introduce el número de jugadores (2-4): ");
                } while (!int.TryParse(Console.ReadLine(), out numeroDeJugadores) || numeroDeJugadores < 2 || numeroDeJugadores > 4);

                int min, max;
                switch (numeroDeJugadores)
                {
                    case 2:
                        min = 0; max = 50;
                        break;

                    case 3:
                        min = 0; max = 100;
                        break;

                    case 4:
                        min = 0; max = 200;
                        break;
                    default:
                        Console.WriteLine($"Número de jugadores inválido");
                        break;




                }


            }



    }
    }
}




            
    





