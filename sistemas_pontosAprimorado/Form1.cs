using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistemas_pontosAprimorado.DAO;
using sistemas_pontosAprimorado.Formulários;

namespace sistemas_pontosAprimorado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void FecharForm(object sender, FormClosedEventArgs e)
        {
            Visible = true;
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            DAOUsuarios dao = new DAOUsuarios();
            if (dao.UsuarioConfirmado(txtLogin.Text, txtSenha.Text))
            {
                FormPrincipal menu = new FormPrincipal();
                menu.FormClosed += FecharForm;
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
