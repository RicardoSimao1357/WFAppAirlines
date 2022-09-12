
namespace AppCompanhiaAerea_V._4.UserControls
{
    using System;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;

    public partial class UCAvioes : UserControl
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();

        public UCAvioes()
        {
            InitializeComponent();
        }

        private void LimpaTextBox() // -> Metodo para limpar os dados introduzidos
        {
            Txt_AviaoId.ResetText();
            Txt_Nome.ResetText();
            MaskedTextBoxMatricula.ResetText();
            NumericUpDownEconomicos.ResetText();
            NumericUpDownExecutivos.ResetText();
            NumericUpDown1Classe.ResetText();
        }

        private void ButtonInserir_Click(object sender, EventArgs e)

        {
            if (ValidaCampos())
            {
                string AviaoNome = Txt_Nome.Text;
                string matricula = MaskedTextBoxMatricula.Text;
                int lugaresEconomicos = Convert.ToInt32(NumericUpDownEconomicos.Value);
                int lugaresExecutivos = Convert.ToInt32(NumericUpDownExecutivos.Value);
                int lugares1Classe = Convert.ToInt32(NumericUpDown1Classe.Value);

                var a = new Avioes
                {
                    nome = AviaoNome,
                    matricula = matricula,
                    lugaresEconomicos = lugaresEconomicos,
                    lugaresExecutivos = lugaresExecutivos,
                    lugaresPrimeiraClasse = lugares1Classe,
                };

                dc.Avioes.InsertOnSubmit(a);

                try
                {
                    dc.SubmitChanges();
                    MessageBox.Show("Aviao inserido com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                AtualizarDataGridView();
                LimpaTextBox();
            }
        }

        void AtualizarDataGridView() // -> Metodo para atualizar datagrid á medida que os dados são manipulados
        {
            dataGridView1.Rows.Clear();

            var listaAvioes = from Aviao in dc.Avioes select Aviao;

            int linha = 0;

            foreach (Avioes aviao in listaAvioes)
            {
                DataGridViewRow registo = new DataGridViewRow();
                dataGridView1.Rows.Add(registo);

                dataGridView1.Rows[linha].Cells[0].Value = aviao.idAviao;
                dataGridView1.Rows[linha].Cells[1].Value = aviao.nome;
                dataGridView1.Rows[linha].Cells[2].Value = aviao.matricula;
                dataGridView1.Rows[linha].Cells[3].Value = aviao.lugaresEconomicos;
                dataGridView1.Rows[linha].Cells[4].Value = aviao.lugaresExecutivos;
                dataGridView1.Rows[linha].Cells[5].Value = aviao.lugaresPrimeiraClasse;

                linha++;
            }


        }

        private void UCAvioes_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("ColunaId", "IdAviao");
            dataGridView1.Columns.Add("colunaNome", "Nome");
            dataGridView1.Columns.Add("colunaMatricula", "Matricula");
            dataGridView1.Columns.Add("colunaEconomicos", "Lugares Economicos");
            dataGridView1.Columns.Add("colunaExecutivos", "Lugares Executivos");
            dataGridView1.Columns.Add("colunaPrimeiraClasse", "Lugares 1ª Classe");



            AtualizarDataGridView();
        }

        private void ButtonEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_AviaoId.Text))
            {
                MessageBox.Show("Deve selcionar um Avião da lista abaixo!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ValidaCampos())
            {
                int AviaoId = int.Parse(Txt_AviaoId.Text);
                string AviaoNome = Txt_Nome.Text;
                string matricula = MaskedTextBoxMatricula.Text;
                int lugaresEconomicos = Convert.ToInt32(NumericUpDownEconomicos.Value);
                int lugaresExecutivos = Convert.ToInt32(NumericUpDownExecutivos.Value);
                int lugares1Classe = Convert.ToInt32(NumericUpDown1Classe.Value);
                int idAlterar = int.Parse(Txt_AviaoId.Text);

                var a = (from Aviao in dc.Avioes
                         where Aviao.idAviao == idAlterar
                         select Aviao).First();

                a.idAviao = AviaoId;
                a.nome = AviaoNome;
                a.matricula = matricula;
                a.lugaresEconomicos = lugaresEconomicos;
                a.lugaresExecutivos = lugaresExecutivos;
                a.lugaresPrimeiraClasse = lugares1Classe;

                try
                {
                    dc.SubmitChanges();
                    MessageBox.Show("Aviao editado com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                AtualizarDataGridView();
                LimpaTextBox();
            }

        }

        private void ButtonApagar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_AviaoId.Text))
            {
                MessageBox.Show("Deve selcionar um Avião da lista abaixo!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var a = (from Aviao in dc.Avioes where Aviao.idAviao == int.Parse(Txt_AviaoId.Text) select Aviao).First();

            dc.Avioes.DeleteOnSubmit(a);

            try
            {
                dc.SubmitChanges();
                MessageBox.Show("Aviao Eliminado!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            AtualizarDataGridView();
            LimpaTextBox();
        }



        private bool ValidaCampos() // -> Metodo para validar aos campos introduzidos pelo utilizador
        {
            bool output = true;

            if (string.IsNullOrEmpty(Txt_Nome.Text))
            {
                MessageBox.Show("O campo Nome é obrigatorio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                output = false;
            }

            if (string.IsNullOrEmpty(MaskedTextBoxMatricula.Text))
            {
                MessageBox.Show("O campo Matricula é obrigatorio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                output = false;
            }

            if (NumericUpDownEconomicos.Value == 0 || NumericUpDownExecutivos.Value == 0 || NumericUpDown1Classe.Value == 0)
            {
                MessageBox.Show("Deve selecionar o numero de lugares!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                output = false;
            }
            return output;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                Txt_AviaoId.Text = row.Cells["ColunaId"].Value.ToString();
                Txt_Nome.Text = row.Cells["colunaNome"].Value.ToString();
                MaskedTextBoxMatricula.Text = row.Cells["colunaMatricula"].Value.ToString();
                NumericUpDownEconomicos.AccessibleName = row.Cells["colunaEconomicos"].ToString();
                NumericUpDownExecutivos.AccessibleName = row.Cells["colunaExecutivos"].ToString();
                NumericUpDown1Classe.AccessibleName = row.Cells["colunaPrimeiraClasse"].ToString();
            }
        }
    }
}
