
namespace AppCompanhiaAerea_V._4.Forms
{
    using System;
    using System.Windows.Forms;

    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            TxtUserName.ResetText();
            TxtPassword.ResetText();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (TxtUserName.Text == "" || TxtPassword.Text == "")
            {
                MessageBox.Show("Insira o username e a password!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (TxtUserName.Text == "Admin" && TxtPassword.Text == "cinel123")
            {
                FormMenuPrincipal menuPrincipal = new FormMenuPrincipal();
                menuPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username ou password errados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void PicBoxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
