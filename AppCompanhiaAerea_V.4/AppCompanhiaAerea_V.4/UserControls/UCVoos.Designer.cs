namespace AppCompanhiaAerea_V._4.UserControls
{
    partial class UCVoos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.ComboBoxDestino = new System.Windows.Forms.ComboBox();
            this.ComboBoxAviao = new System.Windows.Forms.ComboBox();
            this.ComboBoxAeroporto = new System.Windows.Forms.ComboBox();
            this.ButtonApagar = new System.Windows.Forms.Button();
            this.ButtonEditar = new System.Windows.Forms.Button();
            this.ButtonInserir = new System.Windows.Forms.Button();
            this.Txt_VooID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaskedTextBoxHora = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 113;
            this.label3.Text = "Hora:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(120, 113);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(102, 22);
            this.dateTimePicker1.TabIndex = 112;
            this.dateTimePicker1.Value = new System.DateTime(2022, 5, 15, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(28, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 19);
            this.label6.TabIndex = 111;
            this.label6.Text = "Data:";
            // 
            // ComboBoxDestino
            // 
            this.ComboBoxDestino.FormattingEnabled = true;
            this.ComboBoxDestino.Location = new System.Drawing.Point(336, 111);
            this.ComboBoxDestino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBoxDestino.Name = "ComboBoxDestino";
            this.ComboBoxDestino.Size = new System.Drawing.Size(219, 24);
            this.ComboBoxDestino.TabIndex = 110;
            // 
            // ComboBoxAviao
            // 
            this.ComboBoxAviao.FormattingEnabled = true;
            this.ComboBoxAviao.Location = new System.Drawing.Point(336, 158);
            this.ComboBoxAviao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBoxAviao.Name = "ComboBoxAviao";
            this.ComboBoxAviao.Size = new System.Drawing.Size(110, 24);
            this.ComboBoxAviao.TabIndex = 109;
            // 
            // ComboBoxAeroporto
            // 
            this.ComboBoxAeroporto.FormattingEnabled = true;
            this.ComboBoxAeroporto.Location = new System.Drawing.Point(336, 62);
            this.ComboBoxAeroporto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBoxAeroporto.Name = "ComboBoxAeroporto";
            this.ComboBoxAeroporto.Size = new System.Drawing.Size(219, 24);
            this.ComboBoxAeroporto.TabIndex = 108;
            this.ComboBoxAeroporto.SelectedValueChanged += new System.EventHandler(this.ComboBoxAeroporto_SelectedValueChanged);
            // 
            // ButtonApagar
            // 
            this.ButtonApagar.BackColor = System.Drawing.Color.RoyalBlue;
            this.ButtonApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonApagar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonApagar.ForeColor = System.Drawing.Color.White;
            this.ButtonApagar.Location = new System.Drawing.Point(662, 175);
            this.ButtonApagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonApagar.Name = "ButtonApagar";
            this.ButtonApagar.Size = new System.Drawing.Size(104, 42);
            this.ButtonApagar.TabIndex = 106;
            this.ButtonApagar.Text = "Apagar";
            this.ButtonApagar.UseVisualStyleBackColor = false;
            this.ButtonApagar.Click += new System.EventHandler(this.ButtonApagar_Click);
            // 
            // ButtonEditar
            // 
            this.ButtonEditar.BackColor = System.Drawing.Color.RoyalBlue;
            this.ButtonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEditar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEditar.ForeColor = System.Drawing.Color.White;
            this.ButtonEditar.Location = new System.Drawing.Point(662, 117);
            this.ButtonEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonEditar.Name = "ButtonEditar";
            this.ButtonEditar.Size = new System.Drawing.Size(104, 42);
            this.ButtonEditar.TabIndex = 105;
            this.ButtonEditar.Text = "Editar";
            this.ButtonEditar.UseVisualStyleBackColor = false;
            this.ButtonEditar.Click += new System.EventHandler(this.ButtonEditar_Click);
            // 
            // ButtonInserir
            // 
            this.ButtonInserir.BackColor = System.Drawing.Color.RoyalBlue;
            this.ButtonInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonInserir.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonInserir.ForeColor = System.Drawing.Color.White;
            this.ButtonInserir.Location = new System.Drawing.Point(662, 61);
            this.ButtonInserir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonInserir.Name = "ButtonInserir";
            this.ButtonInserir.Size = new System.Drawing.Size(104, 42);
            this.ButtonInserir.TabIndex = 102;
            this.ButtonInserir.Text = "Inserir";
            this.ButtonInserir.UseVisualStyleBackColor = false;
            this.ButtonInserir.Click += new System.EventHandler(this.ButtonInserir_Click);
            // 
            // Txt_VooID
            // 
            this.Txt_VooID.Enabled = false;
            this.Txt_VooID.Location = new System.Drawing.Point(120, 62);
            this.Txt_VooID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_VooID.Name = "Txt_VooID";
            this.Txt_VooID.Size = new System.Drawing.Size(102, 22);
            this.Txt_VooID.TabIndex = 104;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(28, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 103;
            this.label5.Text = "ID Voo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(236, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 100;
            this.label4.Text = "Destino:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(236, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 99;
            this.label2.Text = "Aviao:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(236, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 98;
            this.label1.Text = "Aeroporto:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.RoyalBlue;
            this.dataGridView1.Location = new System.Drawing.Point(32, 240);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(855, 265);
            this.dataGridView1.TabIndex = 115;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // MaskedTextBoxHora
            // 
            this.MaskedTextBoxHora.Location = new System.Drawing.Point(120, 158);
            this.MaskedTextBoxHora.Mask = "00:00";
            this.MaskedTextBoxHora.Name = "MaskedTextBoxHora";
            this.MaskedTextBoxHora.Size = new System.Drawing.Size(102, 22);
            this.MaskedTextBoxHora.TabIndex = 116;
            this.MaskedTextBoxHora.ValidatingType = typeof(System.DateTime);
            // 
            // UCVoos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.Controls.Add(this.MaskedTextBoxHora);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ComboBoxDestino);
            this.Controls.Add(this.ComboBoxAviao);
            this.Controls.Add(this.ComboBoxAeroporto);
            this.Controls.Add(this.ButtonApagar);
            this.Controls.Add(this.ButtonEditar);
            this.Controls.Add(this.ButtonInserir);
            this.Controls.Add(this.Txt_VooID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCVoos";
            this.Size = new System.Drawing.Size(921, 524);
            this.Load += new System.EventHandler(this.UCVoos_Load);
            this.Click += new System.EventHandler(this.UCVoos_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ComboBoxDestino;
        private System.Windows.Forms.ComboBox ComboBoxAviao;
        private System.Windows.Forms.ComboBox ComboBoxAeroporto;
        private System.Windows.Forms.Button ButtonApagar;
        private System.Windows.Forms.Button ButtonEditar;
        private System.Windows.Forms.Button ButtonInserir;
        private System.Windows.Forms.TextBox Txt_VooID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox MaskedTextBoxHora;
    }
}
