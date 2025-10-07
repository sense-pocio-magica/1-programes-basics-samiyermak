namespace exercici3;

/* Defineix quatre variables per al nom d’un producte, el seu preu 
i si està en estoc o no. Imprimeix la informació de forma clara. */
class Program
{
    static void Main(string[] args)
    {
        string nom_del_producte = "Galletas María";
        float preu = 1.29f;
        bool enEstoc = true; 
        string textEstoc = enEstoc ? "Sí" : "No";

        Console.WriteLine("Informació del producte");
        Console.WriteLine("Nom: " + nom_del_producte);
        Console.WriteLine("Preu: " + preu + "€");
        Console.WriteLine("Disponibilitat en estoc: " + textEstoc);
    }
}
