class Produto
{

    // Atributos -> Privados para proteger os dados
    private string nome;
    private double precoUnitario;
    private int quantidade;
    private double desconto;

    // Construtor
    public Produto(string nome, double precoUnitario, int quantidade, double desconto)
    {
        this.nome = nome;
        this.precoUnitario = precoUnitario;
        this.quantidade = quantidade;
        this.desconto = desconto;
    }

    // Método para calcular o custo total (Custo Total = Preço Unitário * Quantidade)
    public double CalcularCustoTotal()
    {
        return precoUnitario * quantidade;
    }

    // Método para aplicar o desconto para itens com o valor acima de 5 mil (Custo Final = Custo Total - (Custo Total * (Desconto / 100)))
    public double CalcularCustoFinal()
    {
        double custoTotal = CalcularCustoTotal();

        if (custoTotal > 5000)
        {
            return custoTotal - (custoTotal * (desconto / 100));
        }
        else
        {
            return custoTotal;
        }
    }

    public void ExibirDetalhes()
    {
        double custoTotal = CalcularCustoTotal();
        double custoFinal = CalcularCustoFinal();

        Console.WriteLine("Produto: " + nome);
        Console.WriteLine("Preço Unitário: " + precoUnitario.ToString("F2"));
        Console.WriteLine("Quantidade: " + quantidade);
        Console.WriteLine("Custo Total: " + custoTotal.ToString("F2"));

        if (custoTotal > 5000)
        {
            Console.WriteLine("Desconto Aplicado: " + desconto + "%");
        }
        else
        {
            Console.WriteLine("Sem desconto aplicado.");
        }

        Console.WriteLine("Custo Final: " + custoFinal.ToString("F2"));
    }
}