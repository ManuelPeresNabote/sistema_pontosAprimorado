using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entidades
{
    public class EntUsuario
    {
        public int ID_USUARIOS { get; set; }
        public string LOGIN { get; set; }
        public string SENHA { get; set; }

        public EntUsuario(string login, string senha)
        {
            LOGIN = login;
            SENHA = senha;
        }
        public object[] Linha()
        {
            return new object[] { ID_USUARIOS, LOGIN, SENHA };
        }
    }
}
