using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroAnimaisExercicio.Entidades
{
    public class Animal
    {
        public string Nome;
        public string Especie;
        public int Idade;

        public Animal(string nome, string especie, int idade)
        {
            Nome = nome;
            Especie = especie;
            Idade = idade;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Espécie: {Especie}");
            Console.WriteLine($"Idade: {Idade} anos");
        }

        public void EmitirSom()
        {
            Console.WriteLine($"{Nome} está emitindo um som!");
        }

        public void AlterarIdade(int novaIdade)
        {
            Idade = novaIdade;
            Console.WriteLine($"A idade de {Nome} foi alterada para {Idade} anos.");
        }
    }
}
