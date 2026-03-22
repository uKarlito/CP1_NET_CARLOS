
// Método para aceitar "," e "." como separador decimal
static double LerDecimal(string mensagem)
{
    while (true)
    {
        Console.Write(mensagem);
        string entrada = Console.ReadLine();

        entrada = entrada.Replace(',', '.');

        if (double.TryParse(entrada, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double valor))
        {
            return valor;
        }

        Console.WriteLine("Valor inválido, tente novamente.");
    }
}

// Produto 1
Console.WriteLine("===== Produto 1 =====");
Console.Write("Nome: ");
string nome1 = Console.ReadLine();

double preco1 = LerDecimal("Preço Unitário: "); // Usando o "LerDecimal" com double para ajudar o valor com ","

Console.Write("Quantidade: ");
int quantidade1 = int.Parse(Console.ReadLine());

double desconto1 = LerDecimal("Desconto: "); // Usando o "LerDecimal" com double para ajudar o valor com ","

Produto p1 = new Produto(nome1, preco1, quantidade1, desconto1);

// Produto 2
Console.WriteLine("\n===== Produto 2 =====");
Console.Write("Nome: ");
string nome2 = Console.ReadLine();

double preco2 = LerDecimal("Preço Unitário: "); // Usando o "LerDecimal" com double para ajudar o valor com ","

Console.Write("Quantidade: ");
int quantidade2 = int.Parse(Console.ReadLine());

double desconto2 = LerDecimal("Desconto: "); // Usando o "LerDecimal" com double para ajudar o valor com ","

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
    Console.WriteLine("O produto com maior custo final é: " + p2.GetNome()); 
}