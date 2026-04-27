internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido a la BarberShop");
        for (int i = 1; i <= 8; i++)
        {
            Console.WriteLine($"Presioe una tecla para registrar esta visita ",i);
            Console.ReadKey();
            Console.WriteLine($" Sello numero {i} marcado");

        }
        Console.WriteLine("Cuponera completa, puede canjear su premio");
        Console.WriteLine("Corte de cabello gratis");
    }

}