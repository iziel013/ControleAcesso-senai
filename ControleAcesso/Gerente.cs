using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleAesso
{
    public class Gerente : Funcionario, IValidavel
    {
        public Gerente(string nome) : base(nome, "Gerente de Operações"){}

        public bool Validar()
        {
            Console.WriteLine("---> [SISTEMA] Iniciando scanner biometrico...");

            Console.WriteLine("---> [SISTEMA] Digital reconhecida!");
            return true;
        }
    }
}