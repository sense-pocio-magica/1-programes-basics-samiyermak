namespace exercici12;

/* Fes un programa que a partir de dos números imprimeixi per pantalla la seva suma, la seva resta, 
la seva multiplicació i la seva divisió

Entra el primer número: 3
Entra el segon número: 4

4 + 3 = 7
4 - 3 = 1
4 * 5 = 12
4 / 3 = 1  i en sobra 1


Entra el primer número: 25
Entra el segon número: 5

25 + 5 = 30
25 - 5 = 20
25 * 5 = 125
25 / 5 = 5  i en sobra 0
*/



class Program
{
    static void Main(string[] args)
    {
        Console.Write("Entra el primer número: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Entra el segon número: ");
        int num2 = int.Parse(Console.ReadLine());

        int suma = num1 + num2;
        int resta = num1 - num2;
        int multiplicacio = num1 * num2;
        int divisio = num1 / num2;
        int residu = num1 % num2;

        Console.WriteLine($"{num1} + {num2} = {suma}");
        Console.WriteLine($"{num1} - {num2} = {resta}");
        Console.WriteLine($"{num1} * {num2} = {multiplicacio}");
        Console.WriteLine($"{num1} / {num2} = {divisio} i en sobra {residu}");

    }
}
