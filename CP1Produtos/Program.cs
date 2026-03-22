

// Produto 1
Console.WriteLine("Produto 1:");
Console.Write("Nome: ");
string nome1 = Console.ReadLine();

Console.Write("Preço Unitário: ");
double preco1 = double.Parse(Console.ReadLine());

Console.Write("Quantidade: ");
int quantidade1 = int.Parse(Console.ReadLine());

Console.Write("Desconto: ");
double desconto1 = double.Parse(Console.ReadLine());

Produto p1 = new Produto(nome1, preco1, quantidade1, desconto1);

// Produto 2
Console.WriteLine("Produto 2:");
Console.Write("Nome: ");
string nome2 = Console.ReadLine();

Console.Write("Preço Unitário: ");
double preco2 = double.Parse(Console.ReadLine());

Console.Write("Quantidade: ");
int quantidade2 = int.Parse(Console.ReadLine());

Console.Write("Desconto: ");
double desconto2 = double.Parse(Console.ReadLine());

Produto p2 = new Produto(nome2, preco2, quantidade2, desconto2);

// Exibir detalhes
Console.WriteLine();
p1.ExibirDetalhes();
Console.WriteLine();
p2.ExibirDetalhes();

// Comparar produtos
Console.WriteLine();
if (p1.CalcularCustoFinal() > p2.CalcularCustoFinal())
{
    Console.WriteLine("O produto com maior custo final é: " + p1.GetNome());
}
else
{
    Console.WriteLine("O produto com maior custo final é: " + p2.GetNome); 
}