using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.Entidades;
using sistemas_pontosAprimorado.DAO;
using sistemas_pontosAprimorado.Formulários.Cadastro;
using sistemas_pontosAprimorado.Formulários.Editar;

namespace sistemas_pontosAprimorado.Formulários
{
    public partial class FormPontos : Form
    {
        DAOPontos dao = new DAOPontos();
        DataTable dados;
        int LinhaSelecionada;
        public FormPontos()
        {
            InitializeComponent();
            dados = new DataTable();
            dtGridPontos.DataSource = dados;
            foreach (var atributos in typeof(EntPontos).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }
            dtGridPontos.DataSource = dao.ObterPontos();
        }

        private void FormPontos_Load(object sender, EventArgs e)
        {

        }

        private void dtGridPontos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    int id = Convert.ToInt32(
                        dtGridPontos.Rows[e.RowIndex].Cells[0].Value);


                    FormEditaroPonto editar = new FormEditaroPonto(id);


                    editar.FormClosed += Fechou_Editar_FormClosed;

                    editar.ShowDialog();
                }
            }
        }
        private void Fechou_Editar_FormClosed(object sender, FormClosedEventArgs e)
        {
            dtGridPontos.DataSource = dao.ObterPontos();
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            FormCadasPontos cadastro = new FormCadasPontos();
            cadastro.FormClosed += Fechou_Editar_FormClosed;
            cadastro.ShowDialog();
        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {
            dtGridPontos.DataSource = dao.Pesquisar(txtpesquisa.Text);
        }
    }
}
