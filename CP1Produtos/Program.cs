// Lendo os dados do Produto 1
Console.WriteLine("Produto 1:");
Console.Write("Nome: ");
string nome1 = Console.ReadLine();

Console.Write("Preço Unitário: ");
double preco1 = double.Parse(Console.ReadLine());

Console.Write("Quantidade: ");
int quantidade1 = int.Parse(Console.ReadLine());

Console.Write("Desconto: ");
double desconto1 = double.Parse(Console.ReadLine());

// Criando o objeto Produto 1
Produto p1 = new Produto(nome1, preco1, quantidade1, desconto1);