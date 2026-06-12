Console.Write("informe a nota final: ");
int nota = int.Parse(Console.ReadLine());

if (nota >=7)
{
    Console.WriteLine("estudante aprovado.");
}
else if (nota >=5)
{
    Console.WriteLine("estudante em recuperação.");
}
else
{
    Console.WriteLine("estudante reprovado.");
}