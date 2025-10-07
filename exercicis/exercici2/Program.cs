namespace exercici2;

/* Declara variables per emmagatzemar l’adreça d’una persona: 
carrer, número, codi postal i població. Imprimeix el resultat 
en una sola línia */

class Program
{
    static void Main(string[] args)
    {
        string carrer = "Carrer Cristofor Colom";
        string numero = "37";
        string codi_postal = "17480";
        string poblacio = "Roses";

        Console.WriteLine($"{carrer}, {numero}, {codi_postal}, {poblacio}");
    }
}
