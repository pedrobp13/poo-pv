namespace PooPedidos.Entidades;

public class Cliente
{

    public Cliente(int id, string nome, string email, string telefone, string endereco)
    {
        Id = id;
        Nome = nome;
        Email = email;
        Telefone = telefone;
        Endereco = endereco;
    }

    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Telefone { get; set; } = string.Empty;
    public string Endereco { get; set; } = string.Empty;



    public override string ToString() => $"{Id} - {Nome} ({Email}) - {Telefone} - {Endereco}";

    public bool ValidarCliente(ref string mensagem)
    {
        if ( (Nome.Length < 3)
            {
            mensagem = "O nome do cliente deve ter pelo menos 3 caracteres.";
            return false;
        }
        {
            
        }

        return true;
    }
}
