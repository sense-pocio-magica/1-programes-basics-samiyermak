namespace exercici8;

/* Assigna un nombre total de minuts a una variable. 
Calcula quantes hores senceres i minuts restants són i imprimeix el resultat. */

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introdueix el nombre total de minuts: ");
        int totalMinuts = int.Parse(Console.ReadLine());

        int hores = totalMinuts / 60;
        int minutsRestants = totalMinuts % 60;

        Console.WriteLine($"{totalMinuts} minuts són {hores} hores i {minutsRestants} minuts.");


    }
}
