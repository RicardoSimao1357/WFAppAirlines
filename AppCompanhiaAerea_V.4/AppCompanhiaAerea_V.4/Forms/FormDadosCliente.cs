
namespace AppCompanhiaAerea_V._4.Forms
{
    using System;
    using System.Data;
    using System.Linq;
    using System.Net;
    using System.Net.Mail;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    public partial class FormDadosCliente : Form
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();

        string lugar = "";
        int _idVoos;
        int _lugaresTotaisDisponiveis;
        string _idBilhete;
        string _origem;
        string _destino;
        string _categoria;
        string _data;
        string _hora;

        public FormDadosCliente(int idVoo, string origem, string destino, string categoria, string idBilhete, int lugaresTotaisDisponiveis, string data, string hora)
        {
            InitializeComponent();
            _idVoos = idVoo;
            _origem = origem;
            _destino = destino;
            _categoria = categoria;
            _idBilhete = idBilhete;
            _lugaresTotaisDisponiveis = lugaresTotaisDisponiveis--;
            _data = data;
            _hora = hora;
        }

        private void Mail()
        {
            SmtpClient client = new SmtpClient();
            NetworkCredential credential = new NetworkCredential();

            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;

            credential.UserName = "ricardo.simao.1357@gmail.com";
            credential.Password = "pkzdcbgllwabqugj";

            client.Credentials = credential;

            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("ricardo.simao.1357@gmail.com");
            mailMessage.Subject = "Confirmação de Compra de bilhete ";

            mailMessage.IsBodyHtml = true;

            mailMessage.Body = $"Senhor(a), {TxtNome.Text}, segue em baixo os dados relativos ao seu voo.<br><br>"
                             + $"<strong>NºTicket: </strong>{Txt_IdBilhete.Text}<br>"
                             + $"<strong>Origem: </strong>{TxtOrigem.Text}<br>"
                             + $"<strong>Destino: </strong>{Txt_Destino.Text}<br>"
                             + $"<strong>Numero do Voo: </strong>{Txt_IdVoo.Text}<br>"
                             + $"<strong>Categoria: </strong>{Txt_Categoria.Text}<br>"
                             + $"<strong>Nº de lugar: </strong>{TxtNumeroLugar.Text}<br>"
                             + $"<strong>Data do voo: </strong>{TxtData.Text}<br>"
                             + $"<strong>Hora do voo: </strong>{TxtHora.Text}<br>"
                             + "<br><br> Obrigado por escolher Marteleira Airlines";
            mailMessage.To.Add($"{Txt_Email.Text}");

            try
            {
                client.Send(mailMessage);
                MessageBox.Show("Bilhete enviado para o email !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormDadosCliente_Load(object sender, EventArgs e)
        {
            DataGridViewLugares.Columns.Add("ColunaLugares", "Lugares Ocupados");
            Txt_IdVoo.Text = _idVoos.ToString();
            TxtOrigem.Text = _origem;
            Txt_Destino.Text = _destino;
            Txt_Categoria.Text = _categoria;
            Txt_IdBilhete.Text = _idBilhete;
            TxtData.Text = _data;
            TxtHora.Text = _hora;
            AtualizaDataGridView();

        }



        private void AtualizaDataGridView()
        {
            if (_categoria == "Economic")
            {
                DataGridViewLugares.Rows.Clear();

                var listaLugares = from Vendas in dc.Vendas where Vendas.Categoria == _categoria select Vendas;

                int linha = 0;

                foreach (Vendas vendas in listaLugares)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    DataGridViewLugares.Rows.Add(row);

                    DataGridViewLugares.Rows[linha].Cells[0].Value = vendas.lugar;

                    linha++;
                }
            }

            if (_categoria == "Executive")
            {
                DataGridViewLugares.Rows.Clear();

                var listaLugares = from Vendas in dc.Vendas where Vendas.Categoria == _categoria select Vendas;

                int linha = 0;

                foreach (Vendas vendas in listaLugares)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    DataGridViewLugares.Rows.Add(row);

                    DataGridViewLugares.Rows[linha].Cells[0].Value = vendas.lugar;

                    linha++;
                }
            }

            if (_categoria == "First Class")
            {
                DataGridViewLugares.Rows.Clear();

                var listaLugares = from Vendas in dc.Vendas where Vendas.Categoria == _categoria select Vendas;

                int linha = 0;

                foreach (Vendas vendas in listaLugares)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    DataGridViewLugares.Rows.Add(row);

                    DataGridViewLugares.Rows[linha].Cells[0].Value = vendas.lugar;

                    linha++;
                }
            }
        }


        private void ButtonConfirmar_Click(object sender, EventArgs e)
        {
            if (validaCampos())
            {
                string nome = TxtNome.Text;
                int nif = Convert.ToInt32(TxtNif.Text);
                int idBilhete = Convert.ToInt32(Txt_IdBilhete.Text);
                string categoria = Txt_Categoria.Text;
                string email = Txt_Email.Text;

                if (_categoria == "Economic")
                {
                    lugar += "EC" + TxtNumeroLugar.Text;

                    var listaLugares = from Vendas in dc.Vendas where Vendas.lugar == lugar select Vendas;

                    foreach (Vendas vendas in listaLugares)
                    {
                        if (lugar == vendas.lugar)
                        {
                            MessageBox.Show("Este lugar já está ocupado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            lugar = "";
                            return;
                        }
                        if (_lugaresTotaisDisponiveis <= vendas.lugar.Count())
                        {
                            MessageBox.Show("Insira um lugar válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            lugar = "";
                            return;
                        }
                    }
                }

                if (_categoria == "Executive")
                {
                    lugar += "EX" + TxtNumeroLugar.Text;

                    var listaLugares = from Vendas in dc.Vendas where Vendas.lugar == lugar select Vendas;

                    foreach (Vendas vendas in listaLugares)
                    {
                        if (lugar == vendas.lugar)
                        {
                            MessageBox.Show("Este lugar já está ocupado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            lugar = "";
                            return;
                        }
                        if (_lugaresTotaisDisponiveis > vendas.lugar.Count())
                        {
                            MessageBox.Show("Insira um lugar válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            lugar = "";
                            return;
                        }
                    }
                }

                if (_categoria == "First Class")
                {
                    lugar += "FC" + TxtNumeroLugar.Text;

                    var listaLugares = from Vendas in dc.Vendas where Vendas.lugar == lugar select Vendas;

                    foreach (Vendas vendas in listaLugares)
                    {
                        if (lugar == vendas.lugar)
                        {
                            MessageBox.Show("Este lugar já está ocupado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            lugar = "";
                            return;
                        }
                        if (_lugaresTotaisDisponiveis > vendas.lugar.Count())
                        {
                            MessageBox.Show("Insira um lugar válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            lugar = "";
                            return;
                        }
                    }
                }

                var v = new Vendas
                {
                    Nome = nome,
                    Nif = nif,
                    idBilhete = idBilhete,
                    lugar = lugar,
                    Categoria = categoria,
                    Email = email,
                };

                dc.Vendas.InsertOnSubmit(v);

                try
                {

                    AtualizaDataGridView();

                    dc.SubmitChanges();
                    Mail();

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private bool validaCampos()
        {
            bool output = true;
            string email = Txt_Email.Text;

            // Verificação do Campo Email
            Regex reg = new Regex(@"(\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,6})");

            if (reg.IsMatch(email) == false)
            {
                MessageBox.Show("Insira um email válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Txt_Email.ResetText();
                output = false;
            }

            if (string.IsNullOrEmpty(TxtNome.Text))
            {
                MessageBox.Show("É obrigatório preencher o campo NOME!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                output = false;
            }

            if (string.IsNullOrEmpty(TxtNif.Text))
            {
                MessageBox.Show("É obrigatório preencher o campo NIF!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                output = false;
            }

            if (string.IsNullOrEmpty(TxtNumeroLugar.Text))
            {
                MessageBox.Show("É obrigatório preencher o campo Nº DO LUGAR!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                output = false;
            }
            if (TxtNif.TextLength != 9)
            {
                MessageBox.Show("Insira um Nif Válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtNif.ResetText();
                output = false;
            }

            return output;
        }

        private void TxtNumeroLugar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {

                MessageBox.Show("Insira apenas dígitos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtNif_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {

                MessageBox.Show("Insira apenas dígitos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem a certeza que pretende cancelar o Bilhete?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                var b = (from Bilhetes in dc.Bilhetes where Bilhetes.idVoo == int.Parse(Txt_IdVoo.Text) select Bilhetes).First();

                dc.Bilhetes.DeleteOnSubmit(b);

                try
                {
                    dc.SubmitChanges();
                    MessageBox.Show("Bilhete eliminado com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                AtualizaDataGridView();

            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
    }
}

