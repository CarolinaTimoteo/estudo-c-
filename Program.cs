// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite o nome da fruta para saber a cor");
string fruta = Console.ReadLine();
if (fruta.ToLower() == "banana")
{
    Console.WriteLine("Amarelo");
}
else if (fruta.ToLower() == "pera")
{
    Console.WriteLine("Qual tipo da pera, williams ou portuguesa?");

    string tipo = Console.ReadLine();
    if (tipo.ToLower() == "williams")
    {
        Console.WriteLine("verde");
    }
    else if (tipo.ToLower() == "portuguesa")
    {
        Console.WriteLine("amarela");
    }
    else
    {
        Console.WriteLine("tipo inválido");
    }
}
else if (fruta.ToLower() == "uva")
{
    Console.WriteLine("Roxo");
}
else 
{
    Console.WriteLine("fruta inválida");
}
