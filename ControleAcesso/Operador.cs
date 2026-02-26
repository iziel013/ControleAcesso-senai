using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleAesso
{
    public class Operador : Funcionario, IValidavel
    {
        public Operador(string nome) : base(nome, "Operador de Pátio"){}

        public bool Validar()
        {
            Console.WriteLine("---> [TECLADO] digite sua senha(4digitos): ");
            string senha = Console.ReadLine();
            return senha == "1234";
        }
    }
}