namespace exercici6;

/* Declara una variable per al costat d'un quadrat. Calcula el seu perímetre (suma dels quatre costats) 
i imprimeix-lo. */

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introdueix la longitud del costat del quadrat: ");
        double costat = double.Parse(Console.ReadLine());

        double perimetre = 4 * costat;

        Console.WriteLine($"El perímetre del quadrat és: {perimetre}");

    }
}
