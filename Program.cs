// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("qual a sua idade:"); 
int idade = Convert.ToInt32(Console.ReadLine());

if (idade >= 18)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("voce é maior de idade ");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("voce e menor de idade ");
}

Console.ResetColor();
Console.WriteLine("obrigadooooo ");
