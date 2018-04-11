using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicandoDapper.acessBanco
{
    interface IDapper<T>
    {
        IEnumerable<T> listar();
        T buscarPorId(int ID);
        int inserir(T item);
        bool alterar(int id,string nome,string disciplina,string cpf, T item);
        bool deletar(int id, T item);
    }
}
