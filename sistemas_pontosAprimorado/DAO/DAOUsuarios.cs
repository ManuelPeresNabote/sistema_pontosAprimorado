using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entidades;

namespace sistemas_pontosAprimorado.DAO
{
    internal class DAOUsuarios
    {
        //private SqlConnection Conexao = new SqlConnection("Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;");
        private SqlConnection Conexao = new SqlConnection("Server=CLAUDIA1968\\DBCARLOS;Database=CONTROLEO_PONTO;User=carkapo;Password=112233;");

        public bool UsuarioConfirmado(string nome, string senha)
        {
            EntUsuario usuarios = new EntUsuario(nome, senha);

            string query = "Select LOGIN, SENHA from USUARIOS where SENHA = @senha AND LOGIN = @login";
            Conexao.Open();
            SqlCommand comando = new SqlCommand(query, Conexao);
            comando.Parameters.Add(new SqlParameter("@login", usuarios.LOGIN));
            comando.Parameters.Add(new SqlParameter("@senha", usuarios.SENHA));
            SqlDataReader resultado = comando.ExecuteReader();

            if (resultado.HasRows)
            {
                Conexao.Close();
                return true;
            }
            else
            {
                Conexao.Close();
                return false;
            }
        }

        public void Inserir(string nome, string senha)
        {
            EntUsuario u = new EntUsuario(nome, senha);
            Conexao.Open();
            string query = @"Insert into USUARIOS (NOME , SENHA) 
                             Values (@nome, @senha) ";
            SqlCommand comando = new SqlCommand(query, Conexao);

            SqlParameter parametro1 = new SqlParameter("@nome", u.LOGIN);
            SqlParameter parametro2 = new SqlParameter("@senha", u.SENHA);

            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.ExecuteNonQuery();
            Conexao.Close();
        }

    }
}
