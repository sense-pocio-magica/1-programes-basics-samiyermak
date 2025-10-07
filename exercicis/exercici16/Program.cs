namespace exercici16;

/* Ningú entén res del nou sistema d’avaluació. Necessitem un programa que calculi la part que és més senzilla: 
a partir de la mitjana de les notes les pràctiques i la nota de l’examen ens calculi la nota final

Nota de pràctiques: 8
Nota de l’examen: 9
La nota final és 8.7 o sigui un 8

Nota de pràctiques: 10
Nota de l’examen: 5
La nota final és 6.5 o sigui un 7 
*/

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introdueix la nota de pràctiques: ");
        int practiques = int.Parse(Console.ReadLine());

        Console.Write("Introdueix la nota de l'examen: ");
        int examen = int.Parse(Console.ReadLine());

        double notaFinal = (practiques + examen) / 2.0;
        int decimals = (int)(notaFinal * 10) % 10;
        int notaArrodonida = (int)notaFinal;
        if (decimals >= 5)
        {
            notaArrodonida += 1;
        }

        Console.WriteLine($"{notaFinal} {notaArrodonida}");

    }
}
