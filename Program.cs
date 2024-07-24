Console.WriteLine("Digite sua data de nascimento:");
string datanascinput=Console.ReadLine();
DateTime datanasc;
if(DateTime.TryParse(datanascinput,out datanasc))
{
    int dia=datanasc.Day;
    int mes=datanasc.Month;
    int ano=datanasc.Year;
    int idade2050=2050-ano;
    Console.WriteLine($"Você na data do dia 23/10/2050 às 14 horas terá {idade2050} anos.");
}
else
{
    Console.WriteLine("Data inserida incorretamente.");
    return;
}
