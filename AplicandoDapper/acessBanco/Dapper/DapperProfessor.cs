using AplicandoDapper.Models;
using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace AplicandoDapper.acessBanco
{
    class DapperProfessor : IDapper<Professor>
    {
        Professor _prof = new Professor();
        private SqlConnection _con;
        public DapperProfessor()
        {
            SqlServe conexao = new SqlServe();
            _con = conexao.ConexaoBanco();
        }
        public bool deletar(int id, Professor item)
        {
            _con.Open();
            var a = _con.Delete(item = new Professor{ ID = id, Nome = "", Disciplina = "", Cpf = "" });
            _con.Close();
            return a;
        }

        public int inserir(Professor item)
        {
            _con.Open();
            _con.Insert(item);
            _con.Close();
            return Convert.ToInt32(true);
        }

        public IEnumerable<Professor> listar()
        {
            try
            {
                IEnumerable<Professor> _prof;
                _con.Open();
                _prof = _con.Query<Professor>("Select * from Professor order by Nome,Cpf;");

                _con.Close();
                return _prof;

            }
            catch
            {
                Console.WriteLine("Erro em listar os dados professores!!!");
                return null;
            }
        }
        public Professor buscarPorId(int ID)
        {
            _con.Open();
            _prof = _con.Get<Professor>(ID);
            _con.Close();
            return _prof;
        }

        public bool alterar(int id, string nome, string disciplina, string cpf, Professor item)
        {
            _con.Open();
            var a = _con.Update(item = new Professor { ID = id,Nome=nome,Disciplina=disciplina,Cpf=cpf});
            _con.Close();
            return a;
        }

    }
}
