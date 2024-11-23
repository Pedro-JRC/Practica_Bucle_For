using System;

namespace Suma_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // VARIABLES
            int cantNumeros = 10;
            int valorNumeros = 0;
            string numeroDigita = string.Empty;
            int numeros = 0;
            int suma = 0;

            try
            {
                    // BUCLE PARA SOLICITAR LOS NUMEROS
                    for (valorNumeros = 1; valorNumeros <= cantNumeros; valorNumeros++)
                    {
                        // SOLICITA LOS NUMEROS
                        Console.WriteLine($"Favor ingrese el numero {valorNumeros}");
                        numeroDigita = Console.ReadLine();

                        // VALIDACIONES
                        if (int.TryParse(numeroDigita, out numeros) && numeros > 0)
                        {
                            
                        }
                        else
                        {
                            // MENSAJE DE ERROR EN CASO SE INSTRODUZCAN VALORES INVALIDOS
                            Console.WriteLine("ERROR: Favor ingrese valores validos");
                            return;
                        }
                        if (valorNumeros >= 6)
                        {
                            // SUMA LOS 5 ULTIMOS NUMEROS
                            suma += numeros;
                        }
                    }

                    // MUESTRA LA SUMA DE LOS ULTIMOS 5 NUMEROS
                    Console.WriteLine($"La suma de los ultimos 5 numeros es: {suma}");
            }
            catch
            {
                // MENSAJE DE ERROR EN CASO SE INSTRODUZCAN VALORES INVALIDOS
                Console.WriteLine("ERROR: Favor ingrese valores validos");
            }
        }
    }
}
