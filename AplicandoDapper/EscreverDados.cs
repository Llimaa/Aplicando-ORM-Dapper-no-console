using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicandoDapper
{
    public class EscreverDados:Dados
    {
        public void Escrever()
        {

            Console.WriteLine("Digite o nome do Aluno: ");
            Nome= Console.ReadLine();
            Console.WriteLine("Digite a Disciplina que voce esta cursando: ");
            Disciplina = Console.ReadLine();
            Console.WriteLine("Informe seu CPF: ");
           Cpf = Console.ReadLine();
        }
    }
}
