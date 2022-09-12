
namespace AppCompanhiaAerea_V._4.Forms
{
    using AppCompanhiaAerea_V._4.UserControls;
    using System;
    using System.Windows.Forms;

    public partial class FormMenuPrincipal : Form
    {
        bool sidebarExpand;
        public FormMenuPrincipal()
        {
            InitializeComponent();
            About();
        }



        #region Buttons

        private void BtnAvioes_Click(object sender, EventArgs e)
        {
            UCAvioes uCAvioes = new UCAvioes();
            GetUserControl(uCAvioes);
        }

        private void BtnAeroportos_Click(object sender, EventArgs e)
        {
            UCAeroportos uCAeroportos = new UCAeroportos();
            GetUserControl(uCAeroportos);
        }


        private void BtnBilhetes_Click(object sender, EventArgs e)
        {
            UCBilhetes uCBilhetes = new UCBilhetes();
            GetUserControl(uCBilhetes);
        }

        private void BtnVoos_Click(object sender, EventArgs e)
        {
            UCVoos uCVoos = new UCVoos();
            GetUserControl(uCVoos);
        }

        private void BtnSobre_Click(object sender, EventArgs e)
        {
            UcAbout uCAbout = new UcAbout();
            GetUserControl(uCAbout);
        }
        private void ButtonSair_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Quer sair da aplicação?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

        }
        private void MenuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }


        #endregion

        #region UC

        private void GetUserControl(UserControl userControl) // -> Ao passar de UC para UC assume as propriedades referidas no metodo
        {
            userControl.Dock = DockStyle.Fill;
            PanelConteudo.Controls.Clear();
            PanelConteudo.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void About()
        {
            UcAbout ucAbout = new UcAbout();
            GetUserControl(ucAbout);
        }

        #endregion

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }


    }
}
