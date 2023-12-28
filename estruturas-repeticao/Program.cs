// using System.Diagnostics.Contracts;

// for (int contador = 10; contador >0;)
// {
//     Console.WriteLine (contador);

//     contador = contador - 1;
// }


// double salario = 1000;
// for (int ano = 1; ano <=5;)
// {
//     Console.WriteLine(ano + "=" + salario);

//     ano = ano + 1;
//     salario = salario + (salario* 0.05);
// }

Console.WriteLine("Quantos anos voce ficou na empresa?");
int anosNaEmpresa = int.Parse(Console.ReadLine());


double salario = 1000;
for (int anoInicio = 1; anoInicio <= anosNaEmpresa;)
{
    Console.WriteLine(anoInicio + "=" + salario);

    anoInicio = anoInicio + 1;
    salario = salario + (salario* 0.05);
}
