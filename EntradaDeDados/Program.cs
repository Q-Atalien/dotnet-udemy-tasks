using System.Globalization;

Console.WriteLine("Digite uma frase");
string frase = Console.ReadLine();

Console.WriteLine("Digite 1 cor");
string x = Console.ReadLine();

Console.WriteLine("Digite outra cor");
string y = Console.ReadLine();

Console.WriteLine("Digite ultima cor");
string z = Console.ReadLine();

Console.WriteLine("Digite 3 coisas");
string[] vetor = Console.ReadLine().Split(' ');
string a = vetor[0], b = vetor[1], c = vetor[2];

Console.WriteLine(frase);

Console.WriteLine($"{x}\n{y}\n{z} \n{a} {b} {c}");


Console.WriteLine("\nDigite Nome, Sexo, Idade e Altura");
string[] info = Console.ReadLine().Split(' ');

string nome = info[0];
char sexo = char.Parse(info[1]); 
int idade = int.Parse(info[2]);
double altura = double.Parse(info[3], CultureInfo.InvariantCulture);

Console.WriteLine($"Seu nome: {nome} Sexo: {sexo} Idade: {idade} anos " +
    $"Altura: {altura}");


Console.WriteLine("\nEntre com seu nome completo");
string nome1 = Console.ReadLine();

Console.WriteLine("\nQuantos quartos tem na sua casa?");
int qtdQuartos = int.Parse(Console.ReadLine());

Console.WriteLine("\nQual valor deste produto?");
double vlrProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("\nDigite sobrenome, idade e altura:");
string[] info2 = Console.ReadLine().Split(' ');

string sobrenome = info2[0];
int idade2 = int.Parse(info2[1]);
double altura2 = double.Parse(info2[2], CultureInfo.InvariantCulture);

Console.WriteLine($"\n{nome1} \n{qtdQuartos} \n{vlrProduto}" +
    $"\n {sobrenome} \n{idade2} \n{altura2}");

