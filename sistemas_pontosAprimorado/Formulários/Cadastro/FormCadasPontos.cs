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
using sistemas_pontosAprimorado.DAO;

namespace sistemas_pontosAprimorado.Formulários.Cadastro
{
    public partial class FormCadasPontos : Form
    {
        //private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
        private string LinhaConexao = "Server=CLAUDIA1968\\DBCARLOS;Database=CONTROLEO_PONTO;User=carkapo;Password=112233; ";
        private SqlConnection Conexao;
        DAOPontos dao = new DAOPontos();
        public FormCadasPontos()
        {
            InitializeComponent();
            cbFuncionarios.DataSource = dao.PreencherComboBox();
            cbFuncionarios.DisplayMember = "NOME";
            cbFuncionarios.ValueMember = "FUNCIONARIO_ID";
        }

        private void FormCadasPontos_Load(object sender, EventArgs e)
        {
            
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string query = "insert into PONTO (FUNCIONARIO_ID, DATA, HORA_ENTRADA,HORA_SAIDA) Values (@idF, @data, @horaE,@horaS)";

            Conexao = new SqlConnection(LinhaConexao);
            Conexao.Open();

            SqlCommand comando = new SqlCommand(query, Conexao);

            comando.Parameters.Add(new SqlParameter("@idF", cbFuncionarios.SelectedValue));
            comando.Parameters.Add(new SqlParameter("@data", dtpData.Value.Date));
            comando.Parameters.Add(new SqlParameter("@horaE", dtpHoraEntrada.Value));
            comando.Parameters.Add(new SqlParameter("@horaS", dtpHoraSaida.Value));


            int resposta = comando.ExecuteNonQuery();

            if (resposta == 1)
            {
                MessageBox.Show("Ponto adicionado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao adicionr", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
