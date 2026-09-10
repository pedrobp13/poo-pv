namespace PooPedidos.Entidades;

public class Pedido
{
    public int Id { get; set; }
    public DateTime Data { get; set; }
    public Cliente Cliente { get; set; } = null!;
    public string Observacao { get; set; } = string.Empty;
    public List<ItemPedido> Itens { get; set; } = [];

    public decimal ValorTotal => Itens.Sum(item => item.ValorTotal);

    public Pedido(int id, DateTime data, Cliente cliente, string observacao)
    {
        Id = id;
        Data = data;
        Cliente = cliente;
        Observacao = observacao;
    }

    public override string ToString() =>
        $"{Id} - {Data:dd/MM/yyyy} - {Cliente.Nome} - {ValorTotal:C}";
}
