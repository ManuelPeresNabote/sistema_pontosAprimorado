using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entidades;
namespace EletronicoPonto.DAO
{
    class DAOUsuarios
    {
        private SqlConnection Conexao = new SqlConnection("Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;");

        public bool UsuarioConfirmado(string nome, string senha)
        {
            EntidadeUsuarios usuarios = new EntidadeUsuarios(nome, senha);

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

        public void Inserir(string login, string senha)
        {
            EntidadeUsuarios u = new EntidadeUsuarios(login, senha);
            Conexao.Open();
            string query = @"Insert into USUARIOS (LOGIN , SENHA) 
                             Values (@login, @senha) ";
            SqlCommand comando = new SqlCommand(query, Conexao);

            SqlParameter parametro1 = new SqlParameter("@login", u.LOGIN);
            SqlParameter parametro2 = new SqlParameter("@senha", u.SENHA);

            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.ExecuteNonQuery();
            Conexao.Close();
        }

    }
}
