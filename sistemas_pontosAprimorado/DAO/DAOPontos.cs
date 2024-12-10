using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.Entidades;

namespace sistemas_pontosAprimorado.DAO
{
    public class DAOPontos
    {
        //private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
        private string LinhaConexao = "Server=CLAUDIA1968\\DBCARLOS;Database=CONTROLEO_PONTO;User=carkapo;Password=112233;";
        private SqlConnection Conexao;
        public DAOPontos()
        {
            Conexao = new SqlConnection(LinhaConexao);
        }

        public void Inserir(EntPontos pontos)
        {
            Conexao.Open();
            string query = "Insert into PONTO (PONTO_ID,FUNCIONARIO_ID,DATA,HORA_ENTRADA,HORA_SAIDA) Values (@idP,@idF,@data, @horaE, @horaS)";
            SqlCommand comando = new SqlCommand(query, Conexao);
            SqlParameter parametro1 = new SqlParameter("@idP", pontos.PONTO_ID);
            SqlParameter parametro2 = new SqlParameter("@idF", pontos.FUNCIONARIO_ID);
            SqlParameter parametro3 = new SqlParameter("@data", pontos.DATA);
            SqlParameter parametro4 = new SqlParameter("@horaE", pontos.HORA_ENTRADA);
            SqlParameter parametro5 = new SqlParameter("@horaS", pontos.HORA_SAIDA);
            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.Parameters.Add(parametro3);
            comando.Parameters.Add(parametro4);
            comando.Parameters.Add(parametro5);
            comando.ExecuteNonQuery();
            Conexao.Close();
        }
        public DataTable ObterPontos()
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = @"SELECT 
                            PONTO.PONTO_ID,
                            PONTO.DATA,
                            PONTO.HORA_ENTRADA,
                            PONTO.HORA_SAIDA,
                            FUNCIONARIOS.FUNCIONARIO_ID,
                            FUNCIONARIOS.NOME
                        FROM 
                            FUNCIONARIOS
                        INNER JOIN 
                            PONTO
                        ON 
                            FUNCIONARIOS.FUNCIONARIO_ID = PONTO.FUNCIONARIO_ID
                        ORDER BY 
                            FUNCIONARIO_ID DESC;";
            SqlCommand comando = new SqlCommand(query, Conexao);
            SqlDataReader leitura = comando.ExecuteReader();
            foreach (var atributos in typeof(EntPontos).GetProperties())
            {
                dt.Columns.Add(atributos.Name);
            }
            if (leitura.HasRows)
            {
                while (leitura.Read())
                {
                    EntPontos ponto = new EntPontos();
                    ponto.PONTO_ID = Convert.ToInt32(leitura[0]);
                    ponto.DATA = Convert.ToDateTime(leitura[1]);

                    string horaEntrada = leitura[2].ToString().Trim();
                    string horaSaida = leitura[3].ToString().Trim();

                    DateTime horaEntradaDate = DateTime.Parse(horaEntrada);
                    DateTime horaSaidaDate = DateTime.Parse(horaSaida);

                    string horaEntradaFormatada = horaEntradaDate.ToString("HH:mm:ss");
                    string horaSaidaFormatada = horaSaidaDate.ToString("HH:mm:ss");

                    ponto.HORA_ENTRADA = TimeSpan.Parse(horaEntradaFormatada);
                    ponto.HORA_SAIDA = TimeSpan.Parse(horaSaidaFormatada);

                    ponto.FUNCIONARIO_ID = Convert.ToInt32(leitura[4]);
                    ponto.NOME = leitura[5].ToString();

                    dt.Rows.Add(ponto.Linha());


                }
            }
            Conexao.Close();
            return dt;


        }
        public DataTable PreencherComboBox()
        {
            DataTable dataTable = new DataTable();

            string query = "SELECT FUNCIONARIO_ID, NOME FROM FUNCIONARIOS";

            using (SqlConnection connection = new SqlConnection(LinhaConexao))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                try
                {
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao acessar os dados: " + ex.Message);
                }
            }

            return dataTable;
        }
        public DataTable Pesquisar(string pesquisar)
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = "";


            if (string.IsNullOrEmpty(pesquisar))
            {
                query = @"SELECT 
                            PONTO.PONTO_ID,
                            PONTO.DATA,
                            PONTO.HORA_ENTRADA,
                            PONTO.HORA_SAIDA,
                            FUNCIONARIOS.FUNCIONARIO_ID,
                            FUNCIONARIOS.NOME
                        FROM 
                            FUNCIONARIOS
                        INNER JOIN 
                            PONTO
                        ON 
                            FUNCIONARIOS.FUNCIONARIO_ID = PONTO.FUNCIONARIO_ID
                        ORDER BY 
                            FUNCIONARIO_ID DESC;";
            }
            else
            {
                query = $@"SELECT 
                            PONTO.PONTO_ID,
                            PONTO.DATA,
                            PONTO.HORA_ENTRADA,
                            PONTO.HORA_SAIDA,
                            FUNCIONARIOS.FUNCIONARIO_ID,
                            FUNCIONARIOS.NOME
                        FROM 
                            FUNCIONARIOS
                        INNER JOIN 
                            PONTO
                        ON 
                            FUNCIONARIOS.FUNCIONARIO_ID = PONTO.FUNCIONARIO_ID
                        WHERE 
                            FUNCIONARIOS.NOME LIKE '%{pesquisar}%' 
                        ORDER BY 
                            FUNCIONARIO_ID DESC;";
            }

            SqlCommand comando = new SqlCommand(query, Conexao);

            SqlDataReader leitura = comando.ExecuteReader();
            foreach (var atributos in typeof(EntPontos).GetProperties())
            {
                dt.Columns.Add(atributos.Name);
            }
            if (leitura.HasRows)
            {
                while (leitura.Read())
                {
                    EntPontos ponto = new EntPontos();
                    ponto.PONTO_ID = Convert.ToInt32(leitura[0]);
                    ponto.DATA = Convert.ToDateTime(leitura[1]);

                    string horaEntrada = leitura[2].ToString().Trim();
                    string horaSaida = leitura[3].ToString().Trim();

                    DateTime horaEntradaDate = DateTime.Parse(horaEntrada);
                    DateTime horaSaidaDate = DateTime.Parse(horaSaida);

                    string horaEntradaFormatada = horaEntradaDate.ToString("HH:mm:ss");
                    string horaSaidaFormatada = horaSaidaDate.ToString("HH:mm:ss");

                    ponto.HORA_ENTRADA = TimeSpan.Parse(horaEntradaFormatada);
                    ponto.HORA_SAIDA = TimeSpan.Parse(horaSaidaFormatada);

                    ponto.FUNCIONARIO_ID = Convert.ToInt32(leitura[4]);
                    ponto.NOME = leitura[5].ToString();

                    dt.Rows.Add(ponto.Linha());

                }
            }
            Conexao.Close();
            return dt;

        }

    }
}

