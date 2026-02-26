using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleAesso
{
    public abstract class Funcionario
    {
        private string nome;

        public string Nome
        {
            get => nome;
            set => nome = !string.IsNullOrEmpty(value) ? value:
            "desconhecido";
        }

        public string Cargo {get; protected set;}

        public Funcionario (string nome, string cargo)
        {
            Nome = nome;
            Cargo = cargo;

        }
        
        public void BoasVindas()
        {
            Console.WriteLine($"\n identificação nome{Nome} cargo{Cargo}");
        }
    }
}