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
    public partial class FormFuncionarios : Form
    {
        DAOFuncionario dao = new DAOFuncionario();
        DataTable dados;
        int LinhaSelecionada;
        public FormFuncionarios()
        {
            InitializeComponent();
            dados = new DataTable();
            dtGridFuncionario.DataSource = dados;
            foreach (var atributos in typeof(EntFuncionario).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }
            dtGridFuncionario.DataSource = dao.ObterFuncioanrios();
        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {
            dtGridFuncionario.DataSource = dao.Pesquisar(txtpesquisa.Text);
        }
        private void Fechou_Editar_FormClosed(object sender, FormClosedEventArgs e)
        {
            dtGridFuncionario.DataSource = dao.ObterFuncioanrios();
        }


        private void FormFuncionarios_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            FormCadasFuncionario cadastro = new FormCadasFuncionario();
            cadastro.FormClosed += Fechou_Editar_FormClosed;
            cadastro.ShowDialog();
        }

        private void dtGridFuncionario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    int id = Convert.ToInt32(
                        dtGridFuncionario.Rows[e.RowIndex].Cells[0].Value);


                    FormEditarFuncionario editar = new FormEditarFuncionario(id);


                    editar.FormClosed += Fechou_Editar_FormClosed;

                    editar.ShowDialog();
                }
            }
        }
    }
}
