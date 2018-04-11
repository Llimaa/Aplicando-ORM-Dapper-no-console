using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicandoDapper.Models
{
    [Table("Professor")]
    public class Professor
    {
        [Key]
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Disciplina { get; set; }
        public string Cpf { get; set; }
    }
}
