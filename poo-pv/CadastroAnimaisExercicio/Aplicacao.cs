using CadastroAnimaisExercicio.Entidades;
namespace CadastroAnimaisExercicio;

public class Aplicacao
{
    private List<Animal> animais = new List<Animal>();
    public void Executar()
    {
        while (true)
        {
            ExibirMenu();
            var opcao = LerInteiro("Escolha uma opção: ");

            switch (opcao)
            {
                case 1:
                    CadastrarAnimal();
                    break;
                case 2:
                    ListarAnimais();
                    break;
                case 3:
                    BuscarAnimal();
                    break;
                case 4:
                    AlterarIdade();
                    break;
                case 5:
                    FazerAnimalEmitirSom();
                    break;
                case 0:
                    Console.WriteLine("Programa encerrado.");
                    return;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            Pausar();
        }
    }

    private static void ExibirMenu()
    {
        LimparConsole();
        Console.WriteLine("=== CADASTRO DE ANIMAIS ===");
        Console.WriteLine("1 - Cadastrar animal");
        Console.WriteLine("2 - Listar animais");
        Console.WriteLine("3 - Buscar animal");
        Console.WriteLine("4 - Alterar idade");
        Console.WriteLine("5 - Emitir som");
        Console.WriteLine("0 - Sair");
        Console.WriteLine();
    }

    private void CadastrarAnimal()
    {
        Console.WriteLine("=== CADASTRAR ANIMAL ===");

        var nome = LerTexto("Digite o nome do animal: ");
        var especie = LerTexto("Digite a espécie do animal: ");
        var idade = LerInteiro("Digite a idade do animal: ");

        var animal = new Animal(nome, especie, idade);
        Console.WriteLine("\nAnimal cadastrado com sucesso!");
        animais.Add(animal);
    }

    private void ListarAnimais()
    {
        if(animais.Count == 0)
        {
            Console.WriteLine("Nenhum animal cadastrado.");
        }
        else
        {
            Console.WriteLine("=== ANIMAIS CADASTRADOS ===");
            foreach (var animal in animais)
            {
                animal.ExibirDados();
                Console.WriteLine();
            }
        }
    }

    private void BuscarAnimal()
    {
        var nome = LerTexto("Digite o nome do animal que deseja buscar: ");
        foreach(var animal in animais)
        {
            if (animal.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("\nAnimal Encontrado");
                animal.ExibirDados();
                return;

            }
        }
        Console.WriteLine("Animal não encontrado");
    }

    private static void AlterarIdade()
    {
        // TODO: implementar a opção 4.
    }

    private static void FazerAnimalEmitirSom()
    {
        
    }

    private static string LerTexto(string mensagem)
    {
        while (true)
        {
            Console.Write(mensagem);
            var texto = Console.ReadLine()?.Trim();

            if (!string.IsNullOrWhiteSpace(texto))
            {
                return texto;
            }

            Console.WriteLine("O texto não pode ficar vazio.");
        }
    }

    private static int LerInteiro(string mensagem)
    {
        while (true)
        {
            Console.Write(mensagem);

            if (int.TryParse(Console.ReadLine(), out var numero))
            {
                return numero;
            }

            Console.WriteLine("Digite um número inteiro válido.");
        }
    }

    private static void Pausar()
    {
        Console.WriteLine("\nPressione Enter para continuar...");
        Console.ReadLine();
    }

    private static void LimparConsole()
    {
        try
        {
            Console.Clear();
        }
        catch (IOException)
        {
            // Permite executar o projeto com entrada redirecionada em testes.
        }
    }
}
