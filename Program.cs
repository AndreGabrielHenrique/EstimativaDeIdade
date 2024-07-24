Console.WriteLine("Digite sua data de nascimento:");
string datanascinput=Console.ReadLine();
DateTime datanasc;
if(DateTime.TryParse(datanascinput,out datanasc))
{
    DateTime data2050=new DateTime(2050,10,23,14,0,0);
    int idade2050=data2050.Year-datanasc.Year;
    if(datanasc>data2050.AddYears(-idade2050))
    {
        idade2050--;
    }
    Console.WriteLine($"Você na data do dia {data2050.ToString("dd/MM/yyyy")} às 14 horas terá {idade2050} anos.");
}
else
{
    Console.WriteLine("Data inserida incorretamente.");
    return;
}