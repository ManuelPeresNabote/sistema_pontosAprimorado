using EletronicoPonto.DAO;
using EletronicoPonto.Formulários;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EletronicoPonto
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        public void FecharForm(object sender, FormClosedEventArgs e)
        {
            Visible = true;
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            DAOUsuarios dao = new DAOUsuarios();
            FrmMenu menu = new FrmMenu();
            if (dao.UsuarioConfirmado(txtLogin.Text, txtSenha.Text))
            {
                this.Hide();
                txtLogin.Text = "";
                txtSenha.Text = "";
                txtLogin.Focus();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Usuário e/ou senha inválidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
