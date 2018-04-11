using AplicandoDapper.acessBanco;
using AplicandoDapper.Models;
using System;

namespace AplicandoDapper
{
    public class CRUD
    {
        DapperAluno Aluno = new DapperAluno();
        DapperProfessor Professor = new DapperProfessor();

        public void opcoes()
        {
            SelecioneOpcoes Selecione = new SelecioneOpcoes();
            Selecione.Opcoes();
        }
        public void Escolher()
        {
            opcoes();

            int A;
            A = Convert.ToInt16(Console.ReadLine());

            while (A > 0)
            {
                switch (A)
                {
                    //  Listar todos os dados.
                    case 1:
                        Console.WriteLine("Dados Dos Alunos:\n");
                        //list aluno
                        foreach (var a in Aluno.listar())
                        {

                            Console.WriteLine("Nome: {0} - Cpf: {1} - Disciplina: {2} - Id: {3}", a.Nome, a.Cpf, a.Disciplina, a.ID);
                        }
                        Console.WriteLine("\n\n\n Dados Dos professores: \n");
                        //list professor
                        foreach (var a in Professor.listar())
                        {
                            Console.WriteLine("Nome: {0} - Cpf: {1} - Disciplina: {2} - Id: {3}", a.Nome, a.Cpf, a.Disciplina, a.ID);
                        }


                        break;
                    //Inserir novo aluno
                    case 2:
                        Console.WriteLine("voce selecionou 2");
                        Console.WriteLine("Digite o nome do Aluno: ");
                        string nomeAluno = Console.ReadLine();
                        Console.WriteLine("Digite a Disciplina que voce esta cursando: ");
                        string disciplinaDoAluno = Console.ReadLine();
                        Console.WriteLine("Informe seu CPF: ");
                        string cpfDoAluno = Console.ReadLine();

                        Aluno.inserir(new Aluno { Nome = nomeAluno, Disciplina = disciplinaDoAluno, Cpf = cpfDoAluno });

                        break;
                    //apagar aluno
                    case 3:
                        Console.WriteLine("Digite o id do aluno");
                        int _ID = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("voce selecionou 3");
                        Aluno alu = new Aluno();
                        Console.WriteLine("voce selecionou 6");
                        Aluno.deletar(_ID, alu);
                        Console.WriteLine("Voce apagou os dados");

                        break;
                    //Editar aluno
                    case 4:

                        Console.WriteLine("voce selecionou 7 ");
                        Console.WriteLine("Informe o id do Aluno:");
                        int id = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Digite o nome do aluno");
                        string nome =Console.ReadLine();
                        Console.WriteLine("Digite a disciplina");
                        string disciplin = Console.ReadLine();
                        Console.WriteLine("Digite o Cpf");
                        string cpf = Console.ReadLine();
                        Aluno.alterar(id,nome,disciplin,cpf, new Aluno { ID = id, Nome = nome, Disciplina = disciplin, Cpf = cpf });


                        break;
                    //Inserir novo professor
                    case 5:
                        Console.WriteLine("voce selecionou 5");
                        Console.WriteLine("Digite o nome do professor: ");
                        string nomeDoProfessor = Console.ReadLine();
                        Console.WriteLine("Digite a disciplina doprofessor: ");
                        string DisciplinaProfessor = Console.ReadLine();
                        Console.WriteLine("Digite o cpf do professor: ");
                        string cpfProfessor = Console.ReadLine();
                        Professor.inserir(new Professor { Nome = nomeDoProfessor, Disciplina = DisciplinaProfessor, Cpf = cpfProfessor });

                        break;
                    //apagar professor
                    case 6:
                        Console.WriteLine("Digite o ID do professor que vc quer apagar: ");
                        int _id = Convert.ToInt16(Console.ReadLine());
                        Professor prof = new Professor();
                        Console.WriteLine("voce selecionou 6");
                        Professor.deletar(_id, prof);
                        Console.WriteLine("Voce apagou os dados");
                        break;
                    //editar professor
                    case 7:

                        Console.WriteLine("voce selecionou 7 ");
                        Console.WriteLine("Informe o id do professor: ");
                        int idp = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Informe o novo nome:  ");
                        string nomep = Console.ReadLine();
                        Console.WriteLine("informe a nova disciplina: ");
                        string disciplinp = Console.ReadLine();
                        Console.WriteLine("informe o novo CPF: ");
                        string cpfp = Console.ReadLine();

                        Professor.alterar(idp,nomep,disciplinp,cpfp, new Professor { ID = idp, Nome = nomep, Disciplina = disciplinp, Cpf = cpfp });

                        break;

                    //buscar professor:
                    case 8:
                        Console.WriteLine("Digite o Id para fazer a buscar: ");
                        int idd = int.Parse(Console.ReadLine());

                        Aluno _aln = Aluno.buscarPorId(idd);
                        Console.WriteLine(" Nome: {0}  Discplina=: {1} - Cpf=: {2}", _aln.Nome, _aln.Disciplina, _aln.Cpf);

                        break;
                    //buscar aluno:
                    case 9:
                        Console.WriteLine("Voce selecionou 9");
                        Console.WriteLine("Digite o Id para fazer a buscar: ");
                        int idaa = int.Parse(Console.ReadLine());
                        Professor _al = Professor.buscarPorId(idaa);
                        Console.WriteLine(" Nome: {0} , Discplina=: {1}", _al.Nome, _al.Disciplina);
                        break;

                }
                opcoes();
                A = Convert.ToInt16(Console.ReadLine());
            }



        }
    }
}
