using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entidades;

namespace sistemas_pontosAprimorado.DAO
{
    public class DAOFuncionario
    {
        //private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
        private string LinhaConexao = "Server=CLAUDIA1968\\DBCARLOS;Database=CONTROLEO_PONTO;User=carkapo;Password=112233;";
        private SqlConnection Conexao;
        public DAOFuncionario()
        {
            Conexao = new SqlConnection(LinhaConexao);
        }
        public void Inserir(EntFuncionario func)
        {
            Conexao.Open();
            string query = "Insert into FUNCIONARIOS (FUNCIONARIO_ID,NOME,CARGO) Values (@id,@nome,@cargo)";
            SqlCommand comando = new SqlCommand(query, Conexao);
            SqlParameter parametro1 = new SqlParameter("@id", func.FUNCIONARIO_ID);
            SqlParameter parametro2 = new SqlParameter("@nome", func.NOME);
            SqlParameter parametro3 = new SqlParameter("@cargo", func.CARGO);
            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.Parameters.Add(parametro3);
            comando.ExecuteNonQuery();
            Conexao.Close();
        }
        public DataTable ObterFuncioanrios()
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = "Select * From FUNCIONARIOS Order BY FUNCIONARIO_ID desc";
            SqlCommand comando = new SqlCommand(query, Conexao);
            SqlDataReader leitura = comando.ExecuteReader();
            foreach (var atributos in typeof(EntFuncionario).GetProperties())
            {
                dt.Columns.Add(atributos.Name);
            }
            if (leitura.HasRows)
            {
                while (leitura.Read())
                {
                    EntFuncionario curso = new EntFuncionario();
                    curso.FUNCIONARIO_ID = Convert.ToInt32(leitura[0]);
                    curso.NOME = leitura[1].ToString();
                    curso.CARGO = leitura[2].ToString();
                    dt.Rows.Add(curso.Linha());


                }
            }
            Conexao.Close();
            return dt;


        }
        public DataTable Pesquisar(string pesquisar)
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = "";


            if (string.IsNullOrEmpty(pesquisar))
            {
                query = "SELECT * FROM FUNCIONARIOS order by FUNCIONARIO_ID desc";
            }
            else
            {
                query = $@"SELECT * FROM FUNCIONARIOS
                            where NOME LIKE '%{pesquisar}%' OR
                            CARGO LIKE '%{pesquisar}%'
                            Order by FUNCIONARIO_ID desc";
            }

            SqlCommand comando = new SqlCommand(query, Conexao);

            SqlDataReader leitura = comando.ExecuteReader();
            foreach (var atributos in typeof(EntFuncionario).GetProperties())
            {
                dt.Columns.Add(atributos.Name);
            }
            if (leitura.HasRows)
            {
                while (leitura.Read())
                {
                    EntFuncionario curso = new EntFuncionario();
                    curso.FUNCIONARIO_ID = Convert.ToInt32(leitura[0]);
                    curso.NOME = leitura[1].ToString();
                    curso.CARGO = leitura[2].ToString();
                    dt.Rows.Add(curso.Linha());
                }
            }
            Conexao.Close();
            return dt;

        }

    }
}

