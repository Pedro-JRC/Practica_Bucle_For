namespace Dividendos_3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // VARIABLES
            string cantidadDigita = string.Empty;
            int cantidadNumeros = 0;
            string numerosDigita = string.Empty;
            int numeros = 0;
            int divide3 = 0;
            int divide5 = 0;
            int divisibles3 = 0;
            int divisibles5 = 0;


            //SOLICITA LA CANTIDAD DE NUMEROS A DIGITAR
            Console.WriteLine("Por favor indique cuantos numeros se digitaran");
            cantidadDigita = Console.ReadLine();

            try
            {
                // VALIDACIONES
                if (int.TryParse(cantidadDigita, out cantidadNumeros) && cantidadNumeros > 0)
                {   
                    // BUCLE QUE SOLICITA LOS NUMEROS
                    for (int i = 1; i <= cantidadNumeros; i++)
                    {
                        // SOLICITA LOS NUMEROS
                        Console.WriteLine($"Favor digite el numero: {i}");
                        numerosDigita = Console.ReadLine();

                        // VALIDACIONES
                        if (int.TryParse(numerosDigita, out numeros) && numeros > 0)
                        {
                            // DIVIDE EL NUMERO ENTRE 3 Y 5
                            divide3 = numeros % 3;
                            divide5 = numeros % 5;
                        }
                        else
                        {
                            Console.WriteLine("Favor digite un valor valido");
                        }

                        // CONDICIONES QUE EVALUAN SI EL NUMERO ES DIVISIBLE POR 3 O 5
                        if (divide3 == 0)
                        {
                            divisibles3++;
                        }
                        if (divide5 == 0)
                        {
                            divisibles5++;
                        }
                         
                    }
                }
                else
                {
                    Console.WriteLine("ERROR: Favor digite un valor valido");
                }

                // MUESTRA CUANTOS NUMEROS SON DIVIBLES POR 3 Y CUANTOS POR 5
                Console.WriteLine($"Hay un total de {divisibles3} numeros divisibles por 3 y {divisibles5} divisibles por 5");
            }
            catch
            {
                Console.WriteLine("ERROR: Favor digite un valor valido");
            }

        }
    }
}
