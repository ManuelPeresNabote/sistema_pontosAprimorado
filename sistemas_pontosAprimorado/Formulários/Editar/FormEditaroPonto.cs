using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.Entidades;
using sistemas_pontosAprimorado.DAO;

namespace sistemas_pontosAprimorado.Formulários.Editar
{
    public partial class FormEditaroPonto : Form
    {
        private string LinhaConexao = "Server=CLAUDIA1968\\DBCARLOS;Database=CONTROLEO_PONTO;User=carkapo;Password=112233; ";
        private SqlConnection Conexao;
        DAOPontos dao = new DAOPontos();
        public FormEditaroPonto(int pontoId)
        {
            InitializeComponent();
            cbFuncionarios.DataSource = dao.PreencherComboBox();
            cbFuncionarios.DisplayMember = "NOME";
            cbFuncionarios.ValueMember = "FUNCIONARIO_ID";

            string query = @"select PONTO_ID, FUNCIONARIO_ID, DATA,HORA_ENTRADA,HORA_SAIDA
                from PONTO where PONTO_ID = @id";

            Conexao = new SqlConnection(LinhaConexao);
            Conexao.Open();

            SqlCommand comando = new SqlCommand(query, Conexao);

            comando.Parameters.Add(new SqlParameter("@id", pontoId));

            SqlDataReader leitura = comando.ExecuteReader();
            
            if (leitura.HasRows)
            {
                while (leitura.Read())
                {
                    label_id.Text = leitura[0].ToString();
                    cbFuncionarios.SelectedValue = Convert.ToInt32(leitura[1]);
                    dtpData.Value = Convert.ToDateTime(leitura[2]);

                    string horaEntrada = leitura[3].ToString().Trim();
                    string horaSaida = leitura[4].ToString().Trim();

                    DateTime horaEntradaDate = DateTime.Parse(horaEntrada);
                    DateTime horaSaidaDate = DateTime.Parse(horaSaida);

                    DateTime dataHoraEntrada = new DateTime(1753, 1, 1, horaEntradaDate.Hour, horaEntradaDate.Minute, horaEntradaDate.Second);
                    DateTime dataHoraSaida = new DateTime(1753, 1, 1, horaSaidaDate.Hour, horaSaidaDate.Minute, horaSaidaDate.Second);

                    dtpHoraEntrada.Value = dataHoraEntrada;
                    dtpHoraSaida.Value = dataHoraSaida;



                }
            }
            Conexao.Close();
        }

        private void FormEditaroPonto_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string query = "update PONTO set FUNCIONARIO_ID = @idF, DATA = @data, HORA_ENTRADA = @horaE,HORA_SAIDA=@horaS WHERE PONTO_ID = @id";

            Conexao = new SqlConnection(LinhaConexao);
            Conexao.Open();

            SqlCommand comando = new SqlCommand(query, Conexao);

            comando.Parameters.Add(new SqlParameter("@idF", cbFuncionarios.SelectedValue));
            comando.Parameters.Add(new SqlParameter("@data", dtpData.Value.Date));
            comando.Parameters.Add(new SqlParameter("@horaE", dtpHoraEntrada.Value));
            comando.Parameters.Add(new SqlParameter("@horaS", dtpHoraSaida.Value));
            comando.Parameters.Add(new SqlParameter("@id", label_id.Text));

            int resposta = comando.ExecuteNonQuery();

            if (resposta == 1)
            {
                MessageBox.Show("Ponto editado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao editar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string query = "Delete from PONTO WHERE PONTO_ID = @id";

            Conexao = new SqlConnection(LinhaConexao);
            Conexao.Open();


                SqlCommand comando = new SqlCommand(query, Conexao);
                comando.Parameters.Add(new SqlParameter("@id", label_id.Text));

                int resposta = comando.ExecuteNonQuery();

                if (resposta == 1)
                {
                    MessageBox.Show("Ponto excluído com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao excluir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
    }
}
