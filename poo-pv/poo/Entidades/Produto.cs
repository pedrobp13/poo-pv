namespace PooPedidos.Entidades;

public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    private decimal Preco { get; set; }
    private int Estoque { get; set; }
    public string Descricao { get; set; } = string.Empty;

    public Produto(int id, string nome, decimal preco, int estoque, string descricao)
    {
        Id = id;
        Nome = nome;
        Preco = preco;
        Estoque = estoque;
        Descricao = descricao;
    }

    public void AlterarPreco(decimal novoPreco)
    {
        if (novoPreco < 0)
            throw new ArgumentException("O preço não pode ser negativo.");
        Preco = novoPreco;
    }

    public decimal ObterPreco() => Preco;

    public void adicionarEstoque(int quantidade)
    {
        if (quantidade < 0)
            throw new ArgumentException("A quantidade a adicionar não pode ser negativa.");
        Estoque += quantidade;
    }

    public int ObterEstoque() => Estoque;

    public void RemoverEstoque(int quantidade)
    {
        if (quantidade < 0)
            throw new ArgumentException("A quantidade a remover não pode ser negativa.");
        if (quantidade > Estoque)
            throw new InvalidOperationException("Não há estoque suficiente para remover a quantidade solicitada.");
        Estoque -= quantidade;
    }

    public override string ToString() => $"{Id} - {Nome} - {Preco:C}";
}
