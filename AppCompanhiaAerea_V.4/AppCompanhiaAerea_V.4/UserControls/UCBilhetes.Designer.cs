namespace AppCompanhiaAerea_V._4.UserControls
{
    partial class UCBilhetes
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CheckBoxData = new System.Windows.Forms.CheckBox();
            this.CheckBoxDestino = new System.Windows.Forms.CheckBox();
            this.CheckBoxOrigem = new System.Windows.Forms.CheckBox();
            this.ButtonLimpar = new System.Windows.Forms.Button();
            this.Lbl_Data = new System.Windows.Forms.Label();
            this.ButtonPesquisar = new System.Windows.Forms.Button();
            this.Txt_IDVoo = new System.Windows.Forms.TextBox();
            this.ComboBoxOrigem = new System.Windows.Forms.ComboBox();
            this.Lbl_Destino = new System.Windows.Forms.Label();
            this.ComboBoxDestino = new System.Windows.Forms.ComboBox();
            this.Lbl_Origem = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LabelIDVoo = new System.Windows.Forms.Label();
            this.Lbl_1ClasseDisponiveis = new System.Windows.Forms.Label();
            this.Lbl_ExecutivosDisponiveis = new System.Windows.Forms.Label();
            this.Lbl_EconomicosDisponiveis = new System.Windows.Forms.Label();
            this.ProgressBar1Classe = new System.Windows.Forms.ProgressBar();
            this.ProgressBarExecutivos = new System.Windows.Forms.ProgressBar();
            this.ProgressBarEconomicos = new System.Windows.Forms.ProgressBar();
            this.GroupBoxComprarBilhete = new System.Windows.Forms.GroupBox();
            this.TxtHora = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_IdBilhete = new System.Windows.Forms.TextBox();
            this.ComboBoxTipoBilhete = new System.Windows.Forms.ComboBox();
            this.ButtonComprarBilhete1Classe = new System.Windows.Forms.Button();
            this.ButtonComprarBilheteExecutivo = new System.Windows.Forms.Button();
            this.LabelEconomicos = new System.Windows.Forms.Label();
            this.LabelExecutivos = new System.Windows.Forms.Label();
            this.Label1Classe = new System.Windows.Forms.Label();
            this.ButtonComprarBilheteEconomico = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.GroupBoxComprarBilhete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CheckBoxData);
            this.groupBox1.Controls.Add(this.CheckBoxDestino);
            this.groupBox1.Controls.Add(this.CheckBoxOrigem);
            this.groupBox1.Controls.Add(this.ButtonLimpar);
            this.groupBox1.Controls.Add(this.Lbl_Data);
            this.groupBox1.Controls.Add(this.ButtonPesquisar);
            this.groupBox1.Controls.Add(this.Txt_IDVoo);
            this.groupBox1.Controls.Add(this.ComboBoxOrigem);
            this.groupBox1.Controls.Add(this.Lbl_Destino);
            this.groupBox1.Controls.Add(this.ComboBoxDestino);
            this.groupBox1.Controls.Add(this.Lbl_Origem);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.LabelIDVoo);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(27, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(384, 218);
            this.groupBox1.TabIndex = 136;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar por:";
            // 
            // CheckBoxData
            // 
            this.CheckBoxData.AutoSize = true;
            this.CheckBoxData.Location = new System.Drawing.Point(12, 81);
            this.CheckBoxData.Name = "CheckBoxData";
            this.CheckBoxData.Size = new System.Drawing.Size(58, 20);
            this.CheckBoxData.TabIndex = 2;
            this.CheckBoxData.Text = "Data";
            this.CheckBoxData.UseVisualStyleBackColor = true;
            this.CheckBoxData.CheckedChanged += new System.EventHandler(this.CheckBoxData_CheckedChanged);
            // 
            // CheckBoxDestino
            // 
            this.CheckBoxDestino.AutoSize = true;
            this.CheckBoxDestino.Location = new System.Drawing.Point(12, 55);
            this.CheckBoxDestino.Name = "CheckBoxDestino";
            this.CheckBoxDestino.Size = new System.Drawing.Size(75, 20);
            this.CheckBoxDestino.TabIndex = 1;
            this.CheckBoxDestino.Text = "Destino";
            this.CheckBoxDestino.UseVisualStyleBackColor = true;
            this.CheckBoxDestino.CheckedChanged += new System.EventHandler(this.CheckBoxDestino_CheckedChanged);
            // 
            // CheckBoxOrigem
            // 
            this.CheckBoxOrigem.AutoSize = true;
            this.CheckBoxOrigem.Location = new System.Drawing.Point(12, 29);
            this.CheckBoxOrigem.Name = "CheckBoxOrigem";
            this.CheckBoxOrigem.Size = new System.Drawing.Size(73, 20);
            this.CheckBoxOrigem.TabIndex = 0;
            this.CheckBoxOrigem.Text = "Origem";
            this.CheckBoxOrigem.UseVisualStyleBackColor = true;
            this.CheckBoxOrigem.CheckedChanged += new System.EventHandler(this.CheckBoxOrigem_CheckedChanged);
            // 
            // ButtonLimpar
            // 
            this.ButtonLimpar.BackColor = System.Drawing.Color.RoyalBlue;
            this.ButtonLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLimpar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLimpar.ForeColor = System.Drawing.Color.White;
            this.ButtonLimpar.Location = new System.Drawing.Point(179, 177);
            this.ButtonLimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonLimpar.Name = "ButtonLimpar";
            this.ButtonLimpar.Size = new System.Drawing.Size(85, 34);
            this.ButtonLimpar.TabIndex = 103;
            this.ButtonLimpar.Text = "Limpar";
            this.ButtonLimpar.UseVisualStyleBackColor = false;
            this.ButtonLimpar.Click += new System.EventHandler(this.ButtonLimpar_Click);
            // 
            // Lbl_Data
            // 
            this.Lbl_Data.AutoSize = true;
            this.Lbl_Data.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Data.ForeColor = System.Drawing.Color.White;
            this.Lbl_Data.Location = new System.Drawing.Point(127, 124);
            this.Lbl_Data.Name = "Lbl_Data";
            this.Lbl_Data.Size = new System.Drawing.Size(52, 19);
            this.Lbl_Data.TabIndex = 134;
            this.Lbl_Data.Text = "Data:";
            // 
            // ButtonPesquisar
            // 
            this.ButtonPesquisar.BackColor = System.Drawing.Color.RoyalBlue;
            this.ButtonPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPesquisar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPesquisar.ForeColor = System.Drawing.Color.White;
            this.ButtonPesquisar.Location = new System.Drawing.Point(270, 177);
            this.ButtonPesquisar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonPesquisar.Name = "ButtonPesquisar";
            this.ButtonPesquisar.Size = new System.Drawing.Size(101, 34);
            this.ButtonPesquisar.TabIndex = 130;
            this.ButtonPesquisar.Text = "Pesquisar";
            this.ButtonPesquisar.UseVisualStyleBackColor = false;
            this.ButtonPesquisar.Click += new System.EventHandler(this.ButtonPesquisar_Click);
            // 
            // Txt_IDVoo
            // 
            this.Txt_IDVoo.Enabled = false;
            this.Txt_IDVoo.Location = new System.Drawing.Point(211, 27);
            this.Txt_IDVoo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_IDVoo.Name = "Txt_IDVoo";
            this.Txt_IDVoo.Size = new System.Drawing.Size(165, 22);
            this.Txt_IDVoo.TabIndex = 125;
            // 
            // ComboBoxOrigem
            // 
            this.ComboBoxOrigem.FormattingEnabled = true;
            this.ComboBoxOrigem.Location = new System.Drawing.Point(211, 57);
            this.ComboBoxOrigem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBoxOrigem.Name = "ComboBoxOrigem";
            this.ComboBoxOrigem.Size = new System.Drawing.Size(165, 24);
            this.ComboBoxOrigem.TabIndex = 127;
            this.ComboBoxOrigem.Text = "Selecione uma opção";
            this.ComboBoxOrigem.SelectedValueChanged += new System.EventHandler(this.ComboBoxOrigem_SelectedValueChanged);
            // 
            // Lbl_Destino
            // 
            this.Lbl_Destino.AutoSize = true;
            this.Lbl_Destino.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Destino.ForeColor = System.Drawing.Color.White;
            this.Lbl_Destino.Location = new System.Drawing.Point(127, 91);
            this.Lbl_Destino.Name = "Lbl_Destino";
            this.Lbl_Destino.Size = new System.Drawing.Size(74, 19);
            this.Lbl_Destino.TabIndex = 132;
            this.Lbl_Destino.Text = "Destino:";
            // 
            // ComboBoxDestino
            // 
            this.ComboBoxDestino.FormattingEnabled = true;
            this.ComboBoxDestino.Location = new System.Drawing.Point(211, 89);
            this.ComboBoxDestino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBoxDestino.Name = "ComboBoxDestino";
            this.ComboBoxDestino.Size = new System.Drawing.Size(165, 24);
            this.ComboBoxDestino.TabIndex = 128;
            this.ComboBoxDestino.Text = "Selecione uma opção";
            // 
            // Lbl_Origem
            // 
            this.Lbl_Origem.AutoSize = true;
            this.Lbl_Origem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Origem.ForeColor = System.Drawing.Color.White;
            this.Lbl_Origem.Location = new System.Drawing.Point(126, 58);
            this.Lbl_Origem.Name = "Lbl_Origem";
            this.Lbl_Origem.Size = new System.Drawing.Size(75, 19);
            this.Lbl_Origem.TabIndex = 131;
            this.Lbl_Origem.Text = "Origem:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(211, 121);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(165, 22);
            this.dateTimePicker1.TabIndex = 129;
            this.dateTimePicker1.Value = new System.DateTime(2022, 6, 1, 0, 0, 0, 0);
            // 
            // LabelIDVoo
            // 
            this.LabelIDVoo.AutoSize = true;
            this.LabelIDVoo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIDVoo.ForeColor = System.Drawing.Color.White;
            this.LabelIDVoo.Location = new System.Drawing.Point(127, 25);
            this.LabelIDVoo.Name = "LabelIDVoo";
            this.LabelIDVoo.Size = new System.Drawing.Size(70, 19);
            this.LabelIDVoo.TabIndex = 124;
            this.LabelIDVoo.Text = "ID Voo:";
            // 
            // Lbl_1ClasseDisponiveis
            // 
            this.Lbl_1ClasseDisponiveis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_1ClasseDisponiveis.Location = new System.Drawing.Point(390, 173);
            this.Lbl_1ClasseDisponiveis.Name = "Lbl_1ClasseDisponiveis";
            this.Lbl_1ClasseDisponiveis.Size = new System.Drawing.Size(54, 30);
            this.Lbl_1ClasseDisponiveis.TabIndex = 118;
            this.Lbl_1ClasseDisponiveis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_ExecutivosDisponiveis
            // 
            this.Lbl_ExecutivosDisponiveis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_ExecutivosDisponiveis.Location = new System.Drawing.Point(390, 131);
            this.Lbl_ExecutivosDisponiveis.Name = "Lbl_ExecutivosDisponiveis";
            this.Lbl_ExecutivosDisponiveis.Size = new System.Drawing.Size(54, 30);
            this.Lbl_ExecutivosDisponiveis.TabIndex = 117;
            this.Lbl_ExecutivosDisponiveis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_EconomicosDisponiveis
            // 
            this.Lbl_EconomicosDisponiveis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_EconomicosDisponiveis.Location = new System.Drawing.Point(390, 89);
            this.Lbl_EconomicosDisponiveis.Name = "Lbl_EconomicosDisponiveis";
            this.Lbl_EconomicosDisponiveis.Size = new System.Drawing.Size(54, 31);
            this.Lbl_EconomicosDisponiveis.TabIndex = 116;
            this.Lbl_EconomicosDisponiveis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProgressBar1Classe
            // 
            this.ProgressBar1Classe.Location = new System.Drawing.Point(244, 173);
            this.ProgressBar1Classe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProgressBar1Classe.Name = "ProgressBar1Classe";
            this.ProgressBar1Classe.Size = new System.Drawing.Size(136, 30);
            this.ProgressBar1Classe.TabIndex = 115;
            // 
            // ProgressBarExecutivos
            // 
            this.ProgressBarExecutivos.Location = new System.Drawing.Point(244, 131);
            this.ProgressBarExecutivos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProgressBarExecutivos.Name = "ProgressBarExecutivos";
            this.ProgressBarExecutivos.Size = new System.Drawing.Size(136, 30);
            this.ProgressBarExecutivos.TabIndex = 114;
            // 
            // ProgressBarEconomicos
            // 
            this.ProgressBarEconomicos.Location = new System.Drawing.Point(244, 89);
            this.ProgressBarEconomicos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProgressBarEconomicos.Name = "ProgressBarEconomicos";
            this.ProgressBarEconomicos.Size = new System.Drawing.Size(136, 30);
            this.ProgressBarEconomicos.TabIndex = 113;
            // 
            // GroupBoxComprarBilhete
            // 
            this.GroupBoxComprarBilhete.Controls.Add(this.TxtHora);
            this.GroupBoxComprarBilhete.Controls.Add(this.label1);
            this.GroupBoxComprarBilhete.Controls.Add(this.Txt_IdBilhete);
            this.GroupBoxComprarBilhete.Controls.Add(this.ComboBoxTipoBilhete);
            this.GroupBoxComprarBilhete.Controls.Add(this.ButtonComprarBilhete1Classe);
            this.GroupBoxComprarBilhete.Controls.Add(this.ButtonComprarBilheteExecutivo);
            this.GroupBoxComprarBilhete.Controls.Add(this.Lbl_1ClasseDisponiveis);
            this.GroupBoxComprarBilhete.Controls.Add(this.Lbl_ExecutivosDisponiveis);
            this.GroupBoxComprarBilhete.Controls.Add(this.Lbl_EconomicosDisponiveis);
            this.GroupBoxComprarBilhete.Controls.Add(this.ProgressBar1Classe);
            this.GroupBoxComprarBilhete.Controls.Add(this.ProgressBarExecutivos);
            this.GroupBoxComprarBilhete.Controls.Add(this.ProgressBarEconomicos);
            this.GroupBoxComprarBilhete.Controls.Add(this.LabelEconomicos);
            this.GroupBoxComprarBilhete.Controls.Add(this.LabelExecutivos);
            this.GroupBoxComprarBilhete.Controls.Add(this.Label1Classe);
            this.GroupBoxComprarBilhete.Controls.Add(this.ButtonComprarBilheteEconomico);
            this.GroupBoxComprarBilhete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxComprarBilhete.ForeColor = System.Drawing.Color.White;
            this.GroupBoxComprarBilhete.Location = new System.Drawing.Point(417, 27);
            this.GroupBoxComprarBilhete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GroupBoxComprarBilhete.Name = "GroupBoxComprarBilhete";
            this.GroupBoxComprarBilhete.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GroupBoxComprarBilhete.Size = new System.Drawing.Size(471, 218);
            this.GroupBoxComprarBilhete.TabIndex = 133;
            this.GroupBoxComprarBilhete.TabStop = false;
            this.GroupBoxComprarBilhete.Text = "Comprar Bilhete";
            // 
            // TxtHora
            // 
            this.TxtHora.Enabled = false;
            this.TxtHora.Location = new System.Drawing.Point(309, 13);
            this.TxtHora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtHora.Name = "TxtHora";
            this.TxtHora.Size = new System.Drawing.Size(64, 22);
            this.TxtHora.TabIndex = 139;
            this.TxtHora.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 19);
            this.label1.TabIndex = 122;
            this.label1.Text = "Selecione o tipo de bilhete:";
            // 
            // Txt_IdBilhete
            // 
            this.Txt_IdBilhete.Enabled = false;
            this.Txt_IdBilhete.Location = new System.Drawing.Point(376, 13);
            this.Txt_IdBilhete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_IdBilhete.Name = "Txt_IdBilhete";
            this.Txt_IdBilhete.Size = new System.Drawing.Size(68, 22);
            this.Txt_IdBilhete.TabIndex = 138;
            this.Txt_IdBilhete.Visible = false;
            // 
            // ComboBoxTipoBilhete
            // 
            this.ComboBoxTipoBilhete.FormattingEnabled = true;
            this.ComboBoxTipoBilhete.Items.AddRange(new object[] {
            "Economic",
            "Executive",
            "First Class"});
            this.ComboBoxTipoBilhete.Location = new System.Drawing.Point(309, 40);
            this.ComboBoxTipoBilhete.Name = "ComboBoxTipoBilhete";
            this.ComboBoxTipoBilhete.Size = new System.Drawing.Size(135, 24);
            this.ComboBoxTipoBilhete.TabIndex = 121;
            this.ComboBoxTipoBilhete.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTipoBilhete_SelectedIndexChanged);
            // 
            // ButtonComprarBilhete1Classe
            // 
            this.ButtonComprarBilhete1Classe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonComprarBilhete1Classe.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonComprarBilhete1Classe.ForeColor = System.Drawing.Color.White;
            this.ButtonComprarBilhete1Classe.Location = new System.Drawing.Point(137, 173);
            this.ButtonComprarBilhete1Classe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonComprarBilhete1Classe.Name = "ButtonComprarBilhete1Classe";
            this.ButtonComprarBilhete1Classe.Size = new System.Drawing.Size(97, 30);
            this.ButtonComprarBilhete1Classe.TabIndex = 120;
            this.ButtonComprarBilhete1Classe.Text = "Reservar";
            this.ButtonComprarBilhete1Classe.UseVisualStyleBackColor = true;
            this.ButtonComprarBilhete1Classe.Click += new System.EventHandler(this.ButtonComprarBilhete1Classe_Click);
            // 
            // ButtonComprarBilheteExecutivo
            // 
            this.ButtonComprarBilheteExecutivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonComprarBilheteExecutivo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonComprarBilheteExecutivo.ForeColor = System.Drawing.Color.White;
            this.ButtonComprarBilheteExecutivo.Location = new System.Drawing.Point(137, 131);
            this.ButtonComprarBilheteExecutivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonComprarBilheteExecutivo.Name = "ButtonComprarBilheteExecutivo";
            this.ButtonComprarBilheteExecutivo.Size = new System.Drawing.Size(97, 30);
            this.ButtonComprarBilheteExecutivo.TabIndex = 119;
            this.ButtonComprarBilheteExecutivo.Text = "Reservar";
            this.ButtonComprarBilheteExecutivo.UseVisualStyleBackColor = true;
            this.ButtonComprarBilheteExecutivo.Click += new System.EventHandler(this.ButtonComprarBilheteExecutivo_Click);
            // 
            // LabelEconomicos
            // 
            this.LabelEconomicos.AutoSize = true;
            this.LabelEconomicos.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEconomicos.ForeColor = System.Drawing.Color.White;
            this.LabelEconomicos.Location = new System.Drawing.Point(6, 93);
            this.LabelEconomicos.Name = "LabelEconomicos";
            this.LabelEconomicos.Size = new System.Drawing.Size(116, 19);
            this.LabelEconomicos.TabIndex = 107;
            this.LabelEconomicos.Text = "Economicos:";
            // 
            // LabelExecutivos
            // 
            this.LabelExecutivos.AutoSize = true;
            this.LabelExecutivos.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelExecutivos.ForeColor = System.Drawing.Color.White;
            this.LabelExecutivos.Location = new System.Drawing.Point(6, 137);
            this.LabelExecutivos.Name = "LabelExecutivos";
            this.LabelExecutivos.Size = new System.Drawing.Size(102, 19);
            this.LabelExecutivos.TabIndex = 109;
            this.LabelExecutivos.Text = "Executivos:";
            // 
            // Label1Classe
            // 
            this.Label1Classe.AutoSize = true;
            this.Label1Classe.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1Classe.ForeColor = System.Drawing.Color.White;
            this.Label1Classe.Location = new System.Drawing.Point(6, 177);
            this.Label1Classe.Name = "Label1Classe";
            this.Label1Classe.Size = new System.Drawing.Size(85, 19);
            this.Label1Classe.TabIndex = 111;
            this.Label1Classe.Text = "1ªClasse:";
            // 
            // ButtonComprarBilheteEconomico
            // 
            this.ButtonComprarBilheteEconomico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonComprarBilheteEconomico.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonComprarBilheteEconomico.ForeColor = System.Drawing.Color.White;
            this.ButtonComprarBilheteEconomico.Location = new System.Drawing.Point(137, 89);
            this.ButtonComprarBilheteEconomico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonComprarBilheteEconomico.Name = "ButtonComprarBilheteEconomico";
            this.ButtonComprarBilheteEconomico.Size = new System.Drawing.Size(97, 30);
            this.ButtonComprarBilheteEconomico.TabIndex = 99;
            this.ButtonComprarBilheteEconomico.Text = "Reservar";
            this.ButtonComprarBilheteEconomico.UseVisualStyleBackColor = true;
            this.ButtonComprarBilheteEconomico.Click += new System.EventHandler(this.ButtonComprarBilheteEconomico_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.RoyalBlue;
            this.dataGridView1.Location = new System.Drawing.Point(27, 254);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(861, 266);
            this.dataGridView1.TabIndex = 139;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // UCBilhetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GroupBoxComprarBilhete);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCBilhetes";
            this.Size = new System.Drawing.Size(921, 524);
            this.Load += new System.EventHandler(this.UCBilhetes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GroupBoxComprarBilhete.ResumeLayout(false);
            this.GroupBoxComprarBilhete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Lbl_Data;
        private System.Windows.Forms.Label Lbl_1ClasseDisponiveis;
        private System.Windows.Forms.Label Lbl_ExecutivosDisponiveis;
        private System.Windows.Forms.Label Lbl_EconomicosDisponiveis;
        private System.Windows.Forms.ProgressBar ProgressBar1Classe;
        private System.Windows.Forms.ProgressBar ProgressBarExecutivos;
        private System.Windows.Forms.ProgressBar ProgressBarEconomicos;
        private System.Windows.Forms.GroupBox GroupBoxComprarBilhete;
        private System.Windows.Forms.Label LabelEconomicos;
        private System.Windows.Forms.Label LabelExecutivos;
        private System.Windows.Forms.Label Label1Classe;
        private System.Windows.Forms.Button ButtonComprarBilheteEconomico;
        private System.Windows.Forms.Button ButtonLimpar;
        private System.Windows.Forms.Label Lbl_Destino;
        private System.Windows.Forms.Label Lbl_Origem;
        private System.Windows.Forms.Button ButtonPesquisar;
        private System.Windows.Forms.TextBox Txt_IDVoo;
        private System.Windows.Forms.Label LabelIDVoo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox ComboBoxDestino;
        private System.Windows.Forms.ComboBox ComboBoxOrigem;
        private System.Windows.Forms.CheckBox CheckBoxData;
        private System.Windows.Forms.CheckBox CheckBoxDestino;
        private System.Windows.Forms.CheckBox CheckBoxOrigem;
        private System.Windows.Forms.Button ButtonComprarBilhete1Classe;
        private System.Windows.Forms.Button ButtonComprarBilheteExecutivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBoxTipoBilhete;
        private System.Windows.Forms.TextBox Txt_IdBilhete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtHora;
    }
}
