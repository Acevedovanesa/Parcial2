public class Program
{
    private static void Main(string[] args)
    {
        // Parcial 2, (Adivina el número)

        //Inicialización código

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
}





                

            




            
    





