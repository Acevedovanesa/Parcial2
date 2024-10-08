using System;

public class Program
{
    private static void Main(string[] args)
    {
        // Parcial 2, (Adivina el número)

        //Inicialización código
        Random random = new Random();
        bool Jugar = true;

        while (Jugar) {

            Console.Clear();
            Console.WriteLine("Bienvenido al juego 'Adivina el número'! ");
            Console.WriteLine("Ingrese el número de jugadores entre 2 y 4");
            int NumJugadores;

            while (int.TryParse(Console.ReadLine(), out NumJugadores) || NumJugadores <2 || NumJugadores >4);
            {
                Console.WriteLine("Por favor ingrese un número válido de jugadores (2-4): ");
            }

            int min, max;

            switch (NumJugadores)
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
                    Console.WriteLine($"Numero de jugadores inválidos");
                    break;
            }

            int NumAleatorio = random.Next(0, NumJugadores + 1);
            int JugadorActual = 1;
            bool Ganador = false;

            while (Ganador)
            {
                Console.WriteLine($"\nTurno del Jugador {JugadorActual}:");
                Console.Write("Introduce el número: ");
                int adivina;

                while (!int.TryParse(Console.ReadLine(), out adivina) || adivina < 0 || adivina > NumJugadores)
                {
                    Console.WriteLine($"Por favor, introduce un número válido entre 0 y {NumJugadores}:");
                }

                if (adivina > NumAleatorio)
                {
                    Console.WriteLine("MENOR");
                }
                else if (adivina < NumJugadores)
                {
                    Console.WriteLine("MAYOR");
                }
                else
                {
                    Console.WriteLine("¡HAS GANADO!");
                    Ganador = true;
                }

                JugadorActual++;
                if (JugadorActual > NumJugadores) JugadorActual = 1;
            }

            Console.WriteLine("\n¿Desean jugar de nuevo? (s/n)");
            string respuesta = Console.ReadLine();
            Console.Clear();
        }

        Console.WriteLine("Gracias por jugar. ¡Hasta la próxima!");


    }
}





    




                

            




            
    





