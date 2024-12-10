using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entidades
{
    public class EntFuncionario
    {
        public int FUNCIONARIO_ID {  get; set; }
        public string NOME { get; set; }
        public string CARGO { get; set; }
        public object[] Linha()
        {
            return new object[] { FUNCIONARIO_ID, NOME, CARGO };
        }
    }
}
