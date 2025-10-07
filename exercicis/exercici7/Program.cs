namespace exercici7;

/* Defineix tres variables amb tres notes numèriques. 
Calcula la mitjana i mostra el resultat per pantalla. */ 

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introdueix la primera nota: ");
        double nota1 = double.Parse(Console.ReadLine());

        Console.Write("Introdueix la segona nota: ");
        double nota2 = double.Parse(Console.ReadLine());

        Console.Write("Introdueix la tercera nota: ");
        double nota3 = double.Parse(Console.ReadLine());

        double mitjana = (nota1 + nota2 + nota3) / 3;

        Console.WriteLine($"La mitjana de les notes és: {mitjana}");

    }
}
