internal class program
{
    private static void Main(string[] args)
    {
        float num1, num2, soma;

        Console.Write("Digite um numero: ");
        num1 = float.Parse(Console.ReadLine());
        Console.Write("Digite outro numero: ");
        num2 = float.Parse(Console.ReadLine());

        soma = num1 + num2;

        Console.WriteLine($"A soma entre os 2 numero é: {soma}");

    }
}








