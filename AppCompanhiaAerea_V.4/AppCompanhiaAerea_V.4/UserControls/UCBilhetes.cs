
namespace AppCompanhiaAerea_V._4.UserControls
{
    using AppCompanhiaAerea_V._4.Forms;
    using System;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;

    public partial class UCBilhetes : UserControl
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();

        string origem, destino, categoria, hora, data;

        public UCBilhetes()
        {
            InitializeComponent();
            ComboBoxOrigem.Visible = false;
            ComboBoxDestino.Visible = false;
            dateTimePicker1.Visible = false;
            Lbl_Origem.Visible = false;
            Lbl_Destino.Visible = false;
            Lbl_Data.Visible = false;
            ComboBoxEscondeCampos();
        }

        private void ComboBoxEscondeCampos() // -> Metodo para esconder dados
        {
            LabelEconomicos.Visible = false;
            ButtonComprarBilheteEconomico.Visible = false;
            ProgressBarEconomicos.Visible = false;
            Lbl_EconomicosDisponiveis.Visible = false;
            LabelExecutivos.Visible = false;
            ButtonComprarBilheteExecutivo.Visible = false;
            ProgressBarExecutivos.Visible = false;
            Lbl_ExecutivosDisponiveis.Visible = false;
            Label1Classe.Visible = false;
            ButtonComprarBilhete1Classe.Visible = false;
            ProgressBar1Classe.Visible = false;
            Lbl_1ClasseDisponiveis.Visible = false;
       
        }

        private void UCBilhetes_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("ColunaIdVoo", "ID Voo");
            dataGridView1.Columns.Add("ColunaAviao", "Aviao");
            dataGridView1.Columns.Add("ColunaAeroporto", "Aeroporto");
            dataGridView1.Columns.Add("ColunaDestino", "Destino");
            dataGridView1.Columns.Add("ColunaDataVoo", "Data");
            dataGridView1.Columns.Add("ColunaHoraVoo", "Hora");
            dataGridView1.Columns.Add("ColunaLugaresEconomicos", "Lugares Economicos");
            dataGridView1.Columns.Add("ColunaLugaresExecutivos", "Lugares Executivos");
            dataGridView1.Columns.Add("ColunaLugares1Classe", "Lugares 1ªClasse");

            GroupBoxComprarBilhete.Visible = false;

            var listaAeroportos = from Aeroporto in dc.Aeroportos orderby Aeroporto.nome select Aeroporto;

            ComboBoxOrigem.DataSource = listaAeroportos;
            ComboBoxOrigem.DisplayMember = "Nome";

            AtualizaComboBoxDestinos();
            Pesquisas();
        }

        private void AtualizaComboBoxDestinos() // -> Carrega os aeroportos para a ComboBox Destino 
        {
            var listaDestinos = from Aeroportos in dc.Aeroportos
                                orderby Aeroportos.nome
                                where Aeroportos.nome != ComboBoxOrigem.Text
                                select Aeroportos;

            ComboBoxDestino.DataSource = listaDestinos;
            ComboBoxDestino.DisplayMember = "Nome";
        }

        private void ComboBoxOrigem_SelectedValueChanged(object sender, EventArgs e)
        {
            AtualizaComboBoxDestinos(); // -> chama-se o metodo neste evento para impedir que o utilizador possa selecionar o mesmo local para origem/destino
        }

        private void ButtonPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisas();
        }

        private void AtualizaLugaresOcupados(int idVoo) // metodo criado para controlar o numero de lugares disponiveis e atualizar também o valor das progressbars
        {
            Voos voo = new Voos();

            //__________________________ Lugares Economicos ____________________________________________________________________//

            var listaLugaresEconomicosOcupados = from Bilhetes in dc.Bilhetes where Bilhetes.idVoo == idVoo select Bilhetes;
            int SomaLugaresEconomicosOcupados = 0;


            if (listaLugaresEconomicosOcupados.Count() > 0)
            {
                SomaLugaresEconomicosOcupados = listaLugaresEconomicosOcupados.Sum(a => a.lugaresEconomicosOcupados);
            }
            else
            {
                SomaLugaresEconomicosOcupados = 0;
            }


            var totalLugaresEconomicos = from Voos in dc.Voos where Voos.idVoo == idVoo select Voos;

            voo = totalLugaresEconomicos.Single();


            ProgressBarEconomicos.Value = (SomaLugaresEconomicosOcupados * 100) / voo.Avioes.lugaresEconomicos;

            var listaLugaresEconomicosDisponiveis = from Voos in dc.Voos where Voos.idVoo == idVoo select Voos;

            Voos LugaresEconomicos = listaLugaresEconomicosDisponiveis.Single();

            Lbl_EconomicosDisponiveis.Text = Convert.ToString(LugaresEconomicos.Avioes.lugaresEconomicos - SomaLugaresEconomicosOcupados);


            //__________________________ Lugares Executivos ____________________________________________________________________//

            var listaLugaresExecutivosOcupados = from Bilhetes in dc.Bilhetes where Bilhetes.idVoo == idVoo select Bilhetes;

            int SomaLugaresExecutivosOcupados = 0;

            if (listaLugaresExecutivosOcupados.Count() > 0)
            {
                SomaLugaresExecutivosOcupados = listaLugaresExecutivosOcupados.Sum(a => a.lugaresExecutivosOcupados);
            }
            else
            {
                SomaLugaresExecutivosOcupados = 0;
            }

            var totalLugaresExecutivos = from Voos in dc.Voos where Voos.idVoo == idVoo select Voos;

            voo = totalLugaresExecutivos.Single();

            ProgressBarExecutivos.Value = (SomaLugaresExecutivosOcupados * 100) / voo.Avioes.lugaresExecutivos;

            var listaLugaresExecutivosDisponiveis = from Voos in dc.Voos where Voos.idVoo == idVoo select Voos;

            Voos LugaresExecutivos = listaLugaresExecutivosDisponiveis.Single();

            Lbl_ExecutivosDisponiveis.Text = Convert.ToString(LugaresExecutivos.Avioes.lugaresExecutivos - SomaLugaresExecutivosOcupados);



            //__________________________ Lugares 1ªClasse ____________________________________________________________________//

            var listaLugares1ClasseOcupados = from Bilhetes in dc.Bilhetes where Bilhetes.idVoo == idVoo select Bilhetes;

            int SomaLugares1ClasseOcupados = 0;

            if (listaLugares1ClasseOcupados.Count() > 0)
            {
                SomaLugares1ClasseOcupados = listaLugares1ClasseOcupados.Sum(a => a.lugaresPrimeiraClasseOcupados);
            }
            else
            {
                SomaLugares1ClasseOcupados = 0;
            }
            var totalLugares1Classe = from Voos in dc.Voos where Voos.idVoo == idVoo select Voos;

            voo = totalLugares1Classe.Single();

            ProgressBar1Classe.Value = (SomaLugares1ClasseOcupados * 100) / voo.Avioes.lugaresPrimeiraClasse;


            var listaLugares1ClasseDisponiveis = from Voos in dc.Voos where Voos.idVoo == idVoo select Voos;

            Voos Lugares1Classe = listaLugares1ClasseDisponiveis.Single();

            Lbl_1ClasseDisponiveis.Text = Convert.ToString(Lugares1Classe.Avioes.lugaresPrimeiraClasse - SomaLugares1ClasseOcupados);

        }

        private void Pesquisas() // metodo criado para permitir ao utilizador fazer diferentes tipos de pesquisa e atualizar a Datagrid
        {
            int LugEconomicosOcupados = 0;
            int LugExecutivosOcupados = 0;
            int Lug1ClasseOcupados = 0;

            var listaVoos = (from Voo in dc.Voos
                             select Voo);

            Aeroportos aeroportosOrigem = (Aeroportos)ComboBoxOrigem.SelectedItem;
            Aeroportos aeroportosDestino = (Aeroportos)ComboBoxDestino.SelectedItem;

            dataGridView1.Rows.Clear();

            if (CheckBoxData.Checked == true && CheckBoxDestino.Checked == true && CheckBoxOrigem.Checked == true)
            {

                listaVoos = (from Voo in dc.Voos
                             where Voo.idAeroporto == aeroportosOrigem.idAeroporto
                             && Voo.destino == aeroportosDestino.idAeroporto
                             && Voo.dataVoo == dateTimePicker1.Text
                             select Voo);

           

                Lbl_Data.Visible = true;
                dateTimePicker1.Visible = true;
                Lbl_Origem.Visible = true;
                ComboBoxOrigem.Visible = true;
                Lbl_Destino.Visible = true;
                ComboBoxDestino.Visible = true;
            }
            else if (CheckBoxOrigem.Checked == true && CheckBoxDestino.Checked == true)
            {
                listaVoos = (from Voo in dc.Voos
                             where Voo.idAeroporto == aeroportosOrigem.idAeroporto
                             && Voo.destino == aeroportosDestino.idAeroporto
                             select Voo);

                if (listaVoos.Count() < 0)
                {
                    MessageBox.Show("Não existem voos com os critérios de pesquisa selecionados !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                Lbl_Data.Visible = false;
                dateTimePicker1.Visible = false;
                Lbl_Origem.Visible = true;
                ComboBoxOrigem.Visible = true;
                Lbl_Destino.Visible = true;
                ComboBoxDestino.Visible = true;
            }
            else if (CheckBoxData.Checked == true && CheckBoxDestino.Checked == true)
            {

                listaVoos = (from Voo in dc.Voos
                             where Voo.destino == aeroportosDestino.idAeroporto
                              & Voo.dataVoo == dateTimePicker1.Text
                             select Voo);

         

                Lbl_Origem.Visible = false;
                ComboBoxOrigem.Visible = false;
                Lbl_Destino.Visible = true;
                ComboBoxDestino.Visible = true;
                Lbl_Data.Visible = true;
                dateTimePicker1.Visible = true;

            }
            else if (CheckBoxData.Checked == true && CheckBoxOrigem.Checked == true)
            {
                listaVoos = (from Voo in dc.Voos
                             where Voo.idAeroporto == aeroportosOrigem.idAeroporto
                             && Voo.dataVoo == dateTimePicker1.Text
                             select Voo);


                Lbl_Destino.Visible = false;
                ComboBoxDestino.Visible = false;
                Lbl_Data.Visible = true;
                dateTimePicker1.Visible = true;
                Lbl_Origem.Visible = true;
                ComboBoxOrigem.Visible = true;
            }
            else if (CheckBoxDestino.Checked == true)
            {
                listaVoos = (from Voo in dc.Voos
                             where Voo.destino == aeroportosDestino.idAeroporto
                             select Voo);   

                Lbl_Origem.Visible = false;
                ComboBoxOrigem.Visible = false;
                Lbl_Data.Visible = false;
                dateTimePicker1.Visible = false;
                Lbl_Destino.Visible = true;
                ComboBoxDestino.Visible = true;
            }
            else if (CheckBoxOrigem.Checked == true)
            {
                listaVoos = (from Voo in dc.Voos
                             where Voo.idAeroporto == aeroportosOrigem.idAeroporto
                             select Voo);
         

                Lbl_Origem.Visible = true;
                ComboBoxOrigem.Visible = true;
                Lbl_Data.Visible = false;
                dateTimePicker1.Visible = false;
                Lbl_Destino.Visible = false;
                ComboBoxDestino.Visible = false;

            }
            else if (CheckBoxData.Checked == true)
            {
                listaVoos = (from Voo in dc.Voos
                             where Voo.dataVoo == dateTimePicker1.Text
                             select Voo);
         

                Lbl_Origem.Visible = false;
                ComboBoxOrigem.Visible = false;
                Lbl_Data.Visible = true;
                dateTimePicker1.Visible = true;
                Lbl_Destino.Visible = false;
                ComboBoxDestino.Visible = false;
            }
            else
            {

                Lbl_Data.Visible = false;
                dateTimePicker1.Visible = false;
                Lbl_Origem.Visible = false;
                ComboBoxOrigem.Visible = false;
                Lbl_Destino.Visible = false;
                ComboBoxDestino.Visible = false;
            }

            int linha = 0;

            try
            {
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


                    var listaLugaresEconomicosOcupados = from Bilhetes in dc.Bilhetes where Bilhetes.idVoo == voo.idVoo select Bilhetes;

                    if (listaLugaresEconomicosOcupados.Count() > 0) // -> se houver bilhetes comprados faz a conta
                    {
                        LugEconomicosOcupados = listaLugaresEconomicosOcupados.Sum(a => a.lugaresEconomicosOcupados);

                    }
                    int LugEconomicosDisponiveis = voo.Avioes.lugaresEconomicos - LugEconomicosOcupados;

                    dataGridView1.Rows[linha].Cells[6].Value = LugEconomicosDisponiveis;

                    // ______________________________________________________________________________________ //

                    var listaLugaresExecutivosOcupados = from Bilhetes in dc.Bilhetes where Bilhetes.idVoo == voo.idVoo select Bilhetes;

                    if (listaLugaresExecutivosOcupados.Count() > 0)
                    {
                        LugExecutivosOcupados = listaLugaresExecutivosOcupados.Sum(a => a.lugaresExecutivosOcupados);
                    }

                    int LugExecutivosDisponiveis = voo.Avioes.lugaresExecutivos - LugExecutivosOcupados;

                    dataGridView1.Rows[linha].Cells[7].Value = LugExecutivosDisponiveis;

                    // ___________________________________________________________________________________________ //

                    var listaLugares1ClasseOcupados = from Bilhetes in dc.Bilhetes where Bilhetes.idVoo == voo.idVoo select Bilhetes;

                    if (listaLugares1ClasseOcupados.Count() > 0)
                    {
                        Lug1ClasseOcupados = listaLugares1ClasseOcupados.Sum(a => a.lugaresPrimeiraClasseOcupados);

                    }
                    int Lug1ClasseDisponiveis = voo.Avioes.lugaresPrimeiraClasse - Lug1ClasseOcupados;

                    dataGridView1.Rows[linha].Cells[8].Value = Lug1ClasseDisponiveis;

                    linha++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CheckBoxOrigem_CheckedChanged(object sender, EventArgs e)
        {
            Pesquisas();
        }

        private void CheckBoxDestino_CheckedChanged(object sender, EventArgs e)
        {
            Pesquisas();
        }

        private void CheckBoxData_CheckedChanged(object sender, EventArgs e)
        {
            Pesquisas();
        }

        private void ButtonComprarBilheteEconomico_Click(object sender, EventArgs e)
        {
            int idVoo = Convert.ToInt32(Txt_IDVoo.Text);
            int lugaresEconomicosOcupados = 1;
            int LugaresEconomicosDisponiveis = Convert.ToInt32(Lbl_EconomicosDisponiveis.Text);

            if (LugaresEconomicosDisponiveis < lugaresEconomicosOcupados)
            {
                MessageBox.Show("já não existem lugares Economicos Disponiveis !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var b = new Bilhetes
            {
                idVoo = idVoo,
                lugaresEconomicosOcupados = lugaresEconomicosOcupados,
            };

            dc.Bilhetes.InsertOnSubmit(b);

            try
            {
                dc.SubmitChanges();

                var idBilhete = (from Bilhetes in dc.Bilhetes where Bilhetes.idVoo == int.Parse(Txt_IDVoo.Text) select Bilhetes);

                foreach (Bilhetes bilhete in idBilhete)
                {
                    Txt_IdBilhete.Text = bilhete.idBilhete.ToString();
                }

                FormDadosCliente dadosCliente = new FormDadosCliente(idVoo, origem, destino, categoria, Txt_IdBilhete.Text, LugaresEconomicosDisponiveis, data, hora);

                dadosCliente.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            AtualizaLugaresOcupados(idVoo);
        }

        private void ComboBoxTipoBilhete_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ComboBoxTipoBilhete.SelectedItem.ToString())
            {
                case "Economic":
                    ComboBoxEscondeCampos();
                    LabelEconomicos.Visible = true;
                    ButtonComprarBilheteEconomico.Visible = true;
                    ProgressBarEconomicos.Visible = true;
                    Lbl_EconomicosDisponiveis.Visible = true;
                    categoria = "Economic";
                    break;

                case "Executive":
                    ComboBoxEscondeCampos();
                    LabelExecutivos.Visible = true;
                    ButtonComprarBilheteExecutivo.Visible = true;
                    ProgressBarExecutivos.Visible = true;
                    Lbl_ExecutivosDisponiveis.Visible = true;
                    categoria = "Executive";
                    break;

                case "First Class":
                    ComboBoxEscondeCampos();
                    Label1Classe.Visible = true;
                    ButtonComprarBilhete1Classe.Visible = true;
                    ProgressBar1Classe.Visible = true;
                    Lbl_1ClasseDisponiveis.Visible = true;
                    categoria = "First Class";
                    break;

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                GroupBoxComprarBilhete.Visible = true;

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                Txt_IDVoo.Text = row.Cells["ColunaIdVoo"].Value.ToString();
                ComboBoxOrigem.Text = row.Cells["ColunaAeroporto"].Value.ToString();
                ComboBoxDestino.Text = row.Cells["ColunaDestino"].Value.ToString();
                dateTimePicker1.Text = row.Cells["ColunaDataVoo"].Value.ToString();
                TxtHora.Text = row.Cells["ColunaHoraVoo"].Value.ToString();
                Lbl_EconomicosDisponiveis.Text = row.Cells["ColunaLugaresEconomicos"].Value.ToString();
                Lbl_ExecutivosDisponiveis.Text = row.Cells["ColunaLugaresExecutivos"].Value.ToString();
                Lbl_1ClasseDisponiveis.Text = row.Cells["ColunaLugares1Classe"].Value.ToString();

                origem = row.Cells["ColunaAeroporto"].Value.ToString();
                destino = row.Cells["ColunaDestino"].Value.ToString();
                data = row.Cells["ColunaDataVoo"].Value.ToString();
                hora = row.Cells["ColunaHoraVoo"].Value.ToString();

                AtualizaLugaresOcupados(Convert.ToInt32(row.Cells["ColunaIdVoo"].Value));

            }
        }

        private void ButtonLimpar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            ComboBoxDestino.ResetText();
            ComboBoxOrigem.ResetText();
            dateTimePicker1.ResetText();
            GroupBoxComprarBilhete.Visible = false;
        }

        private void ButtonComprarBilheteExecutivo_Click(object sender, EventArgs e)
        {
            int idVoo = Convert.ToInt32(Txt_IDVoo.Text);

            int lugaresExecutivosOcupados = 1;

            int LugaresExecutivosDisponiveis = Convert.ToInt32(Lbl_ExecutivosDisponiveis.Text);

            if (LugaresExecutivosDisponiveis < lugaresExecutivosOcupados)
            {
                MessageBox.Show("já não existem lugares Executivos Disponiveis !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            var b = new Bilhetes
            {
                idVoo = idVoo,
                lugaresExecutivosOcupados = lugaresExecutivosOcupados,
            };

            dc.Bilhetes.InsertOnSubmit(b);

            try
            {


                var idBilhete = (from Bilhetes in dc.Bilhetes where Bilhetes.idVoo == int.Parse(Txt_IDVoo.Text) select Bilhetes);

                foreach (Bilhetes bilhete in idBilhete)
                {
                    Txt_IdBilhete.Text = bilhete.idBilhete.ToString();
                }


                FormDadosCliente dadosCliente = new FormDadosCliente(idVoo, origem, destino, categoria, Txt_IdBilhete.Text, LugaresExecutivosDisponiveis, data, hora);

                dadosCliente.Show();
                this.Hide();
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            AtualizaLugaresOcupados(idVoo);
        }


        private void ButtonComprarBilhete1Classe_Click(object sender, EventArgs e)
        {
            int idVoo = Convert.ToInt32(Txt_IDVoo.Text);
            int lugares1ClasseOcupados = 1;
            int Lugares1classeDisponiveis = Convert.ToInt32(Lbl_1ClasseDisponiveis.Text);

            if (Lugares1classeDisponiveis < lugares1ClasseOcupados)
            {
                MessageBox.Show("já não existem lugares de 1ª Classe Disponiveis !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var b = new Bilhetes
            {
                idVoo = idVoo,
                lugaresPrimeiraClasseOcupados = lugares1ClasseOcupados
            };

            dc.Bilhetes.InsertOnSubmit(b);

            try
            {

                var idBilhete = (from Bilhetes in dc.Bilhetes where Bilhetes.idVoo == int.Parse(Txt_IDVoo.Text) select Bilhetes);

                foreach (Bilhetes bilhete in idBilhete)
                {
                    Txt_IdBilhete.Text = bilhete.idBilhete.ToString();
                }

                FormDadosCliente dadosCliente = new FormDadosCliente(idVoo, origem, destino, categoria, Txt_IdBilhete.Text, Lugares1classeDisponiveis, data, hora);

                dadosCliente.Show();
                this.Hide();
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            AtualizaLugaresOcupados(idVoo);
        }

    }
}




