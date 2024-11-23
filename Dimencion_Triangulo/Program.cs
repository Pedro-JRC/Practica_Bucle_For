namespace Dimencion_Triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // VARIABLES
            string trianguloDigita = string.Empty;
            int cantTriangulos = 0;
            string baseDigita = string.Empty;
            double baseTriangulo = 0.0;
            string alturaDigita = string.Empty;
            double alturaTriangulo = 0.0;
            double area = 0.0;
            double limiteArea = 10.5;
            int areaExcedente = 0;
            int areaNoExcedente = 0;

            try
            {
                // SOLICITA AL USUARIO LA CANTIDAD DE TRIANGULOS
                Console.WriteLine("Favor indique la cantidad de triangulos a los cuales se les va a calcular el area.");
                trianguloDigita = Console.ReadLine();

                // ESPACIO
                Console.WriteLine();

                // VALIDACIONES
                if (int.TryParse(trianguloDigita, out cantTriangulos) && cantTriangulos > 0)
                {
                    // BUCLE PARA SOLICITAR X CANTIDAD DE VECES BASE Y ALTURA DE CADA TRIANGULO
                    for (int i = 1; i <= cantTriangulos; i++)
                    {
                        // SOLICITA LA BASE Y ALTURA DEL TRIANGULO
                        Console.WriteLine($"Favor ingrese la base y altura del triangulo: {i}.");

                        // SOLICITA LA BASE
                        Console.Write("Base: ");
                        baseDigita = Console.ReadLine();

                        // VALIDACIONES
                        if (double.TryParse(baseDigita, out baseTriangulo) && baseTriangulo > 0)
                        {
                            // SOLICITA LA ALTURA
                            Console.Write("Altura: ");
                            alturaDigita = Console.ReadLine();
                        }
                        else
                        {
                            // MENSAJE DE ERROR EN CASO SE DIGITEN DATOS INVALIDOS
                            Console.WriteLine("ERROR: Favor ingrese valores validos");
                            return;

                        }

                        // VALIDACIONES
                        if (double.TryParse(alturaDigita, out alturaTriangulo) && alturaTriangulo > 0)
                        {
                            // CALCULA EL AREA
                            area = (baseTriangulo * alturaTriangulo) / 2;
                        }
                        else
                        {
                            // MENSAJE DE ERROR EN CASO SE DIGITEN DATOS INVALIDOS
                            Console.WriteLine("ERROR: Favor ingrese valores validos");
                            return;
                            
                        }

                        // MUESTRA EL AREA
                        Console.WriteLine($"Area del triangulo {i}: {area}");

                        // ESPACIO
                        Console.WriteLine();

                        // CONDICION PARA CALCULAR CUANTOS EXCEDEN EL LIMITE Y CUANTOS NO
                        if (area > limiteArea)
                        {
                            areaExcedente++;
                        }
                        else
                        {
                            areaNoExcedente++;
                        }                     
                    }

                    // MUESTRA CUANTOS TRIANGULOS EXCEDIERON EL LIMITE Y CUANTOS NO
                    Console.WriteLine($"Limite del area {limiteArea}.");
                    Console.WriteLine($"Triangulos que excedieron el limite {areaExcedente}, triangulos que no se excedieron {areaNoExcedente}.");
                }
                else
                {
                    // MENSAJE DE ERROR EN CASO SE DIGITEN DATOS INVALIDOS
                    Console.WriteLine("ERROR: Favor ingrese valores validos");
                }
            }
            catch
            {
                Console.WriteLine("ERROR: Favor ingrese valores validos");
            }
            
        }

    }
}
