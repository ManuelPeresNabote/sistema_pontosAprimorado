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

namespace sistemas_pontosAprimorado.Formulários.Editar
{
    public partial class FormEditarFuncionario : Form
    {
        private string LinhaConexao = "Server=CLAUDIA1968\\DBCARLOS;Database=CONTROLEO_PONTO;User=carkapo;Password=112233; ";
        private SqlConnection Conexao;
        DAOFuncionario dao = new DAOFuncionario();
        public FormEditarFuncionario(int cursoId)
        {
            InitializeComponent();
            string query = @"select FUNCIONARIO_ID, NOME, CARGO
                from FUNCIONARIOS where FUNCIONARIO_ID = @id";
            Conexao = new SqlConnection(LinhaConexao);
            Conexao.Open();
            SqlCommand comando = new SqlCommand(query, Conexao);
            comando.Parameters.Add(new SqlParameter("@id", cursoId));

            SqlDataReader Leitura = comando.ExecuteReader();

            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    label_id.Text = Leitura[0].ToString();
                    txtNome.Text = Leitura[1].ToString();
                    txtCargo.Text = Leitura[2].ToString();
                }
            }
            Conexao.Close();
        }

        private void FormEditarFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string query = "update FUNCIONARIOS set NOME = @nome, CARGO = @cargo WHERE FUNCIONARIO_ID = @id";

            Conexao = new SqlConnection(LinhaConexao);
            Conexao.Open();

            SqlCommand comando = new SqlCommand(query, Conexao);

            comando.Parameters.Add(new SqlParameter("@nome", txtNome.Text));
            comando.Parameters.Add(new SqlParameter("@cargo", txtCargo.Text));
            comando.Parameters.Add(new SqlParameter("@id", label_id.Text));

            int resposta = comando.ExecuteNonQuery();

            if (resposta == 1)
            {
                MessageBox.Show("Funcionário editado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao editar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string query = "Delete from FUNCIONARIOS WHERE FUNCIONARIO_ID = @id";

            Conexao = new SqlConnection(LinhaConexao);
            Conexao.Open();

                SqlCommand comando = new SqlCommand(query, Conexao);
                comando.Parameters.Add(new SqlParameter("@id", label_id.Text));

                int resposta = comando.ExecuteNonQuery();

                if (resposta == 1)
                {
                    MessageBox.Show("Funcionario excluído com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao excluir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
    }
}
