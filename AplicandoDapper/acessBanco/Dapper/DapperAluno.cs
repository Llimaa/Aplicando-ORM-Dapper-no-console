using AplicandoDapper.Models;
using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AplicandoDapper.acessBanco
{
    class DapperAluno : IDapper<Aluno>
    {
        private SqlConnection _con;
        public DapperAluno()
        {
            try
            {
                SqlServe Conexao = new SqlServe();
                _con = Conexao.ConexaoBanco();
            }
            catch
            {
                Console.WriteLine("Erro 404!");
            }
        }

        public Aluno buscarPorId(int ID)
        {
            Aluno _alu = new Aluno();
            _con.Open();
            _alu = _con.Get<Aluno>(ID);
            _con.Close();
            return _alu;
        }


        public int inserir(Aluno item)
        {
            try
            {
                _con.Open();
                _con.Insert(item);
                _con.Close();
                return Convert.ToInt32(true);
            }
            catch
            {
                Console.WriteLine("Falha ao inserir!!!");
                return Convert.ToInt16(null);
            }
        }
        public IEnumerable<Aluno> listar()
        {
            IEnumerable<Aluno> _aln;
            try
            {
                _con.Open();
                //_aln = _con.GetAll<Aluno>(); e uma outra forma de buscar os item mas sem ordenar a ordem
                _aln = _con.Query<Aluno>("Select * from Aluno order by Nome,Cpf;");
                _con.Close();
                return _aln;

            }
            catch
            {
                Console.WriteLine("Falha ao Listar !!!");
                return null;
            }
        }
       
        public bool deletar(int id, Aluno item)
        {
            _con.Open();
            var a = _con.Delete(item = new Aluno { ID = id});
            _con.Close();
            return a;
        }

        public bool alterar(int id,string nome,string disciplina,string cpf, Aluno item)
        {
            _con.Open();
            var Alterar = _con.Update(item = new Aluno {ID=id,Nome=nome,Disciplina=disciplina,Cpf=cpf });
            _con.Close();
            return Alterar;
        }

    }
}
