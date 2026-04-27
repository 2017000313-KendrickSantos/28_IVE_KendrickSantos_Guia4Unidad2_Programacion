internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("vascula del mercado");
        Double peso_manzana = 0;
        Double peso_acumulado = 0;
        int cantidad_manzanas = 0;
        const double peso_maximo = 1000;
        while (peso_acumulado < peso_maximo)
        {   

            Console.WriteLine("Faltan {0} gramos para llegar al kilo", peso_maximo-peso_acumulado); 
            Console.WriteLine("Ingrese el peso de la manzana en gramos (100-300)");
            string entrada = Console.ReadLine();
            if (double.TryParse(entrada, out peso_manzana))
                {
                if (peso_manzana >= 100 && peso_manzana <= 300)
                {
                    cantidad_manzanas = cantidad_manzanas + 1;
                    peso_acumulado += peso_manzana;
                    Console.WriteLine("Cantidad de manzanas: " + cantidad_manzanas);
                    Console.WriteLine("Peso actual: " + peso_acumulado + " gramos");
                }
                else
                {
                    Console.WriteLine("El peso de la manzana debe ser entre 100 y 300 gramos.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
            }
        }
        Console.WriteLine("La vascula se ha llenado con " + cantidad_manzanas + " manzanas y un peso total de " + peso_acumulado + " gramos.");
    }
}