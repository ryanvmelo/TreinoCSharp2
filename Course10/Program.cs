using System.Globalization;

//Exemplo 1
/*
Console.WriteLine("Digite um número inteiro:");
int number = int.Parse(Console.ReadLine());

if (number >= 0)
{
    Console.WriteLine("Não negativo");
}
else
{
    Console.WriteLine("Negativo");
}
*/

//Exemplo 2
/*
Console.WriteLine("Digite um número inteiro:");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("Par");
}
else
{
    Console.WriteLine("Ímpar");
}
*/

//Exemplo 3
/*
Console.WriteLine("Digite o valor 'A'");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor 'B'");
int b = int.Parse(Console.ReadLine());

if (a % b == 0 || b % a == 0)
{
    Console.WriteLine("São multiplos");
}
else
{
    Console.WriteLine("Não são multiplos");
}
*/

//Exemplo 4
/*
Console.WriteLine("Digite a hora inicial e a hora final do jogo:");
string[] horas = Console.ReadLine().Split(' ');
int horaInicio = int.Parse(horas[0]);
int horaFim = int.Parse(horas[1]);

int duracao;
if (horaInicio < horaFim)
{
    duracao = horaFim - horaInicio;
}
else
{
    duracao = 24 - horaInicio + horaFim;
}
 Console.WriteLine("O jogo durou " + duracao + " hora(s)");
*/

//Exemplo 5
/*
double cachorroQuente = 4;
double xsalada = 4.5;
double xbacon = 5;
double torrada = 2;
double refri = 1.5;

Console.WriteLine("Digite o código do produto e a quantidade");
string[] pedido = Console.ReadLine().Split(' ');

int code = int.Parse(pedido[0]);
int qtd = int.Parse(pedido[1]);

double price;
if (code == 1)
{
    price = cachorroQuente;
}
else if (code == 2)
{
    price = xsalada;
}
else if (code == 3)
{
    price = xbacon;
}
else if (code == 4)
{
    price = torrada;
}
else if (code == 5)
{
    price = refri;
}
else
{
    price = 0;
    Console.WriteLine("Não possuímos esse item.");
}

double totalValue = price * qtd;

Console.WriteLine("Total: R$ "+totalValue.ToString("F2", CultureInfo.InvariantCulture));
*/

//Exemplo 6
/*
Console.WriteLine("Digite um número");
double number = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

if(number < 0 || number > 100)
{
    Console.WriteLine("Fora do intervalo");
}
else if(number <= 25)
{
    Console.WriteLine("Intervalo (0, 25)");
}
else if(number <= 50)
{
    Console.WriteLine("Intervalo (25, 50)");
}
else if(number <= 75)
{
    Console.WriteLine("Intervalo (50, 75)");
}
else{
    Console.WriteLine("Intervalo (75, 100)");
}
*/
