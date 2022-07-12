Console.WriteLine("Por favor digite um número:");
int num = Int32.Parse(Console.ReadLine());
int num1 = 3;
int num2 = 5;
int somaNum1 = 0;
int somaNum2 = 0;
int res;


for (int i = 0; i < num; i++)
{
    if(i % num1 == 0)
    {
        somaNum1 += i;
    }
}

for (int i = 0; i < num; i++)
{
    if (i % num2 == 0)
    {
        somaNum2 += i;
    }
}
res = somaNum1 + somaNum2;

Console.WriteLine("A soma dos multiplos de 3 e 5 até "+num+ ",é: " + res);
Console.ReadKey();  