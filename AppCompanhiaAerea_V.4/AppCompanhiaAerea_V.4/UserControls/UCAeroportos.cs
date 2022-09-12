
namespace AppCompanhiaAerea_V._4.UserControls
{
    using System;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;

    public partial class UCAeroportos : UserControl
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();

        public UCAeroportos()
        {
            InitializeComponent();
        }

        private void LimpaTextBox() // Metodo para limpar os dados das txt
        {
            Txt_AeroportoID.ResetText();
            Txt_Nome.ResetText();
            Txt_Localidade.ResetText();
        }

        private void ButtonInserir_Click(object sender, EventArgs e)
        {

            if (ValidaCampos())
            {
                string AeroportoNome = Txt_Nome.Text;
                string localidade = Txt_Localidade.Text;

                var a = new Aeroportos
                {
                    nome = AeroportoNome,
                    localidade = localidade,
                };

                dc.Aeroportos.InsertOnSubmit(a);

                try
                {
                    dc.SubmitChanges();
                    MessageBox.Show("Aeroporto Inserido com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                AtualizarDataGridView();

                LimpaTextBox();
            }
        }

        void AtualizarDataGridView() // Metodo para Atualizar a DataGrid á medida que os dados são manipulados
        {
            dataGridView1.Rows.Clear();

            var listaAeroportos = from Aeroporto in dc.Aeroportos select Aeroporto;

            int linha = 0;

            foreach (Aeroportos aeroporto in listaAeroportos)
            {
                DataGridViewRow registo = new DataGridViewRow();
                dataGridView1.Rows.Add(registo);
                dataGridView1.Rows[linha].Cells[0].Value = aeroporto.idAeroporto;
                dataGridView1.Rows[linha].Cells[1].Value = aeroporto.nome;
                dataGridView1.Rows[linha].Cells[2].Value = aeroporto.localidade;
                linha++;
            }

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void UCAeroportos_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("ColunaId", "IdAeroporto");
            dataGridView1.Columns.Add("colunaNome", "Nome");
            dataGridView1.Columns.Add("colunaLocalidade", "Localidade");
            AtualizarDataGridView();
        }

        private void ButtonEditar_Click(object sender, EventArgs e)
        {
            if (Txt_AeroportoID.Text == "")
            {
                MessageBox.Show("Deve selecionar um Aeroporto primeiro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (ValidaCampos())
            {
                int AeroportoId = int.Parse(Txt_AeroportoID.Text);
                string AeroportoNome = Txt_Nome.Text;
                string aeroportoLocalidade = Txt_Localidade.Text;
                int idAlterar = int.Parse(Txt_AeroportoID.Text);

                var a = (from Aeroporto in dc.Aeroportos
                         where Aeroporto.idAeroporto == idAlterar
                         select Aeroporto).First();

                a.idAeroporto = AeroportoId;
                a.nome = AeroportoNome;
                a.localidade = aeroportoLocalidade;


                try
                {
                    dc.SubmitChanges();
                    MessageBox.Show("Aeroporto editado com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Atenção! Não pode editar dados de Aeroportos que já tenham Voos criados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                AtualizarDataGridView();
                LimpaTextBox();
            }
        }

        private void ButtonApagar_Click(object sender, EventArgs e)
        {
            if (Txt_AeroportoID.Text == "")
            {
                MessageBox.Show("Deve selecionar um Aeroporto primeiro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            var a = (from Aeroporto in dc.Aeroportos where Aeroporto.idAeroporto == int.Parse(Txt_AeroportoID.Text) select Aeroporto).First();

            dc.Aeroportos.DeleteOnSubmit(a);

            try
            {
                dc.SubmitChanges();
                MessageBox.Show("Aeroporto Eliminado com Sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception )
            {
                MessageBox.Show("Atenção! Não pode eliminar dados de Aeroportos que já tenham Voos criados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            AtualizarDataGridView();

            LimpaTextBox();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                Txt_AeroportoID.Text = row.Cells["ColunaId"].Value.ToString();
                Txt_Nome.Text = row.Cells["colunaNome"].Value.ToString();
                Txt_Localidade.Text = row.Cells["colunaLocalidade"].Value.ToString();
            }
        }

        private bool ValidaCampos() // Metodo para validar os campos inseridos pelo utilizador
        {
            bool output = true;

            if (string.IsNullOrEmpty(Txt_Nome.Text))
            {
                MessageBox.Show("O campo NOME é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                output = false;
            }

            if (string.IsNullOrEmpty(Txt_Localidade.Text))
            {
                MessageBox.Show("O campo LOCALIDADE é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                output = false;
            }
            return output;
        }
    }
}
