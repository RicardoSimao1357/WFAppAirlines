
namespace AppCompanhiaAerea_V._4.UserControls
{
    using System;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;

    public partial class UCVoos : UserControl
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();

        public UCVoos()
        {
            InitializeComponent();
        }

        private void ButtonInserir_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                Aeroportos destino = (Aeroportos)ComboBoxDestino.SelectedItem;
                Avioes aviao = (Avioes)ComboBoxAviao.SelectedItem;
                Aeroportos aeroporto = (Aeroportos)ComboBoxAeroporto.SelectedItem;
                string dataVoo = dateTimePicker1.Text;
                string horaVoo = MaskedTextBoxHora.Text;

                var v = new Voos
                {
                    destino = destino.idAeroporto,
                    idAviao = aviao.idAviao,
                    idAeroporto = aeroporto.idAeroporto,
                    dataVoo = dataVoo,
                    horaVoo = horaVoo,
                };

                dc.Voos.InsertOnSubmit(v);

                try
                {
                    dc.SubmitChanges();
                    MessageBox.Show("O Voo foi inserido com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                AtualizarDataGridView();
                LimpaTextBox();
            }
        }

        private void UCVoos_Load(object sender, EventArgs e)
        {
            ComboBoxAviao.Enabled = true;
            dataGridView1.Columns.Add("ColunaIdVoo", "ID Voo");
            dataGridView1.Columns.Add("ColunaAviao", "Aviao");
            dataGridView1.Columns.Add("ColunaAeroporto", "Aeroporto");
            dataGridView1.Columns.Add("ColunaDestino", "Destino");
            dataGridView1.Columns.Add("ColunaDataVoo", "Data");
            dataGridView1.Columns.Add("ColunaHoraVoo", "Hora");

            var listaAvioes = from Aviao in dc.Avioes orderby Aviao.nome select Aviao;

            ComboBoxAviao.DataSource = listaAvioes;
            ComboBoxAviao.DisplayMember = "Nome";

            var listaAeroportos = from Aeroporto in dc.Aeroportos orderby Aeroporto.nome select Aeroporto;

            ComboBoxAeroporto.DataSource = listaAeroportos;
            ComboBoxAeroporto.DisplayMember = "Nome";

            AtualizaComboBoxDestinos();
            AtualizarDataGridView();
            LimpaTextBox();
        }

        private void ButtonEditar_Click(object sender, EventArgs e)
        {
            if (Txt_VooID.Text == "")
            {
                MessageBox.Show("Selecione um Voo da lista abaixo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (ValidaCampos())
            {
                int VooID = int.Parse(Txt_VooID.Text);
                Aeroportos Aeroporto = (Aeroportos)ComboBoxAeroporto.SelectedItem;
             
                Aeroportos Destino = (Aeroportos)ComboBoxDestino.SelectedItem;
                string Data = dateTimePicker1.Text;
                string horaVoo = MaskedTextBoxHora.Text;
                
                Voos a = (from Voo in dc.Voos
                         where Voo.idVoo == VooID                         
                         select Voo).First();
            
                a.idVoo = VooID;
                a.idAeroporto = Aeroporto.idAeroporto;
                a.destino = Destino.idAeroporto;
                a.dataVoo = Data;
                a.horaVoo = horaVoo;

                try
                {
                    dc.SubmitChanges();
                    MessageBox.Show("O Voo foi editado com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                AtualizarDataGridView();
                LimpaTextBox();
            }
        }
        private void LimpaTextBox() // -> Metodo Para limpar os dados introduzidos
        {
            Txt_VooID.ResetText();
            ComboBoxAeroporto.ResetText();
            ComboBoxAviao.ResetText();
            ComboBoxDestino.ResetText();
            MaskedTextBoxHora.ResetText();
            dateTimePicker1.ResetText();
        }

        private void AtualizarDataGridView() // -> Metodo para atualizar a datagrid com os dados manipulados pelo utilizador
        {
            dataGridView1.Rows.Clear();

            var listaVoos = from Voo in dc.Voos select Voo;

            int linha = 0;

            foreach (Voos voo in listaVoos)
            {
                DataGridViewRow registo = new DataGridViewRow();
                dataGridView1.Rows.Add(registo);

                dataGridView1.Rows[linha].Cells[0].Value = voo.idVoo;
                dataGridView1.Rows[linha].Cells[1].Value = voo.Avioes.nome;

                var AeroportoOrigem = (from Aeroportos in dc.Aeroportos
                                       where Aeroportos.idAeroporto == voo.idAeroporto
                                       select Aeroportos).Single(); // -> Pesquisa para ir buscar o nome dos aeroportos pelo id

                dataGridView1.Rows[linha].Cells[2].Value = AeroportoOrigem.nome;

                var AeroportoDestino = (from Aeroportos in dc.Aeroportos
                                        where Aeroportos.idAeroporto == voo.destino
                                        select Aeroportos).Single(); // -> Pesquisa para ir buscar o nome dos Destinos/Aeroportos pelo id

                dataGridView1.Rows[linha].Cells[3].Value = AeroportoDestino.nome;
                dataGridView1.Rows[linha].Cells[4].Value = voo.dataVoo;
                dataGridView1.Rows[linha].Cells[5].Value = voo.horaVoo;

                linha++;
            }
        }

        private void ButtonApagar_Click(object sender, EventArgs e)
        {
            if (Txt_VooID.Text == "")
            {
                MessageBox.Show("Deve Selecionar um Voo da lista abaixo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var v = (from Voo in dc.Voos where Voo.idVoo == int.Parse(Txt_VooID.Text) select Voo).First();

            dc.Voos.DeleteOnSubmit(v);

            try
            {
                dc.SubmitChanges();
                MessageBox.Show("Voo Eliminado com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            AtualizarDataGridView();
            LimpaTextBox();
        }

        private void AtualizaComboBoxDestinos() // -> Carrega os aeroportos para a ComboBox Destino 
        {
            var listaDestinos = from Aeroportos in dc.Aeroportos orderby Aeroportos.nome where Aeroportos.nome != ComboBoxAeroporto.Text select Aeroportos;
            ComboBoxDestino.DataSource = listaDestinos;
            ComboBoxDestino.DisplayMember = "Nome";
        }

        private void ComboBoxAeroporto_SelectedValueChanged(object sender, EventArgs e)
        {
            AtualizaComboBoxDestinos();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ComboBoxAviao.Enabled = false;

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                var listaLugaresOcupados = (from Bilhete in dc.Bilhetes where Bilhete.idVoo == Convert.ToInt32(row.Cells["ColunaIdVoo"].Value) select Bilhete);

                if (listaLugaresOcupados.Count() > 0) // -> Se já houver bilhetes comprados para o voo selecionado desabilita a opção de editar ou eliminar o voo
                {
                    MessageBox.Show($"Não é possivel editar ou pagar o voo {row.Cells["ColunaIdVoo"].Value} , já tem bilhetes comprados", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    Txt_VooID.Text = row.Cells["ColunaIdVoo"].Value.ToString();
                    ComboBoxAviao.Text = row.Cells["ColunaAviao"].Value.ToString();
                    ComboBoxAeroporto.Text = row.Cells["ColunaAeroporto"].Value.ToString();
                    ComboBoxDestino.Text = row.Cells["ColunaDestino"].Value.ToString();
                    dateTimePicker1.Text = row.Cells["ColunaDataVoo"].Value.ToString();
                    MaskedTextBoxHora.Text = row.Cells["ColunaHoraVoo"].Value.ToString();
                }
            }
            
        }

        private bool ValidaCampos() // -> Metodo para validar os campos introduzidos pelo utilizador
        {
            DateTime diaSelecionado = DateTime.Today;

            bool output = true;

            if (dateTimePicker1.Value < diaSelecionado)
            {
                MessageBox.Show("Insira uma data válida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                output = false;
            }

            if (string.IsNullOrEmpty(MaskedTextBoxHora.Text))
            {
                MessageBox.Show("O campo Hora é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                output = false;
            }

            return output;
        }

        private void UCVoos_Click(object sender, EventArgs e)
        {
            LimpaTextBox();
            ComboBoxAviao.Enabled = true;
        }
    }
}
