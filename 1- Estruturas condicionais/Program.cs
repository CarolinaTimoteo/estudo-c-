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

    string tipoPera = Console.ReadLine();
    if (tipoPera.ToLower() == "williams")
    {
        Console.WriteLine("verde");
    }
    else if (tipoPera.ToLower() == "portuguesa")
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
    Console.WriteLine("Uva vitória ou uva tompson?");

    string tipoUva = Console.ReadLine();
    if(tipoUva.ToLower() == "vitória")
    {
        Console.WriteLine("A uva vitoria é roxa");
    }
    else if (tipoUva.ToLower() == "Tompson")
    {
        Console.WriteLine("A uva tompson é verde");
    }
    else 
    {
        Console.WriteLine("Tipo inválido");
    }
}
else 
{
    Console.WriteLine("fruta inválida");
}

