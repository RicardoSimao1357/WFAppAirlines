namespace AppCompanhiaAerea_V._4.Forms
{
    partial class FormDadosCliente
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDadosCliente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ButtonConfirmar = new System.Windows.Forms.Button();
            this.Txt_Categoria = new System.Windows.Forms.TextBox();
            this.Txt_IdVoo = new System.Windows.Forms.TextBox();
            this.Txt_Destino = new System.Windows.Forms.TextBox();
            this.TxtOrigem = new System.Windows.Forms.TextBox();
            this.TxtNif = new System.Windows.Forms.TextBox();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.Txt_IdBilhete = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtNumeroLugar = new System.Windows.Forms.TextBox();
            this.DataGridViewLugares = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonEliminar = new System.Windows.Forms.Button();
            this.TxtData = new System.Windows.Forms.TextBox();
            this.TxtHora = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewLugares)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonConfirmar
            // 
            this.ButtonConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonConfirmar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonConfirmar.ForeColor = System.Drawing.Color.White;
            this.ButtonConfirmar.Location = new System.Drawing.Point(294, 190);
            this.ButtonConfirmar.Name = "ButtonConfirmar";
            this.ButtonConfirmar.Size = new System.Drawing.Size(108, 35);
            this.ButtonConfirmar.TabIndex = 35;
            this.ButtonConfirmar.Text = "Confirmar ";
            this.ButtonConfirmar.UseVisualStyleBackColor = true;
            this.ButtonConfirmar.Click += new System.EventHandler(this.ButtonConfirmar_Click);
            // 
            // Txt_Categoria
            // 
            this.Txt_Categoria.AccessibleName = "Txt_Destino";
            this.Txt_Categoria.Enabled = false;
            this.Txt_Categoria.Location = new System.Drawing.Point(941, 130);
            this.Txt_Categoria.Name = "Txt_Categoria";
            this.Txt_Categoria.Size = new System.Drawing.Size(150, 22);
            this.Txt_Categoria.TabIndex = 33;
            // 
            // Txt_IdVoo
            // 
            this.Txt_IdVoo.AccessibleName = "Txt_Destino";
            this.Txt_IdVoo.Enabled = false;
            this.Txt_IdVoo.Location = new System.Drawing.Point(824, 130);
            this.Txt_IdVoo.Name = "Txt_IdVoo";
            this.Txt_IdVoo.Size = new System.Drawing.Size(111, 22);
            this.Txt_IdVoo.TabIndex = 31;
            // 
            // Txt_Destino
            // 
            this.Txt_Destino.AccessibleName = "Txt_Destino";
            this.Txt_Destino.Enabled = false;
            this.Txt_Destino.Location = new System.Drawing.Point(613, 130);
            this.Txt_Destino.Name = "Txt_Destino";
            this.Txt_Destino.Size = new System.Drawing.Size(205, 22);
            this.Txt_Destino.TabIndex = 29;
            // 
            // TxtOrigem
            // 
            this.TxtOrigem.Enabled = false;
            this.TxtOrigem.Location = new System.Drawing.Point(280, 130);
            this.TxtOrigem.Name = "TxtOrigem";
            this.TxtOrigem.Size = new System.Drawing.Size(202, 22);
            this.TxtOrigem.TabIndex = 27;
            // 
            // TxtNif
            // 
            this.TxtNif.Location = new System.Drawing.Point(132, 85);
            this.TxtNif.MaxLength = 999999999;
            this.TxtNif.Multiline = true;
            this.TxtNif.Name = "TxtNif";
            this.TxtNif.Size = new System.Drawing.Size(270, 26);
            this.TxtNif.TabIndex = 21;
            this.TxtNif.Text = "123456789";
            this.TxtNif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNif_KeyPress);
            // 
            // Txt_Email
            // 
            this.Txt_Email.Location = new System.Drawing.Point(132, 135);
            this.Txt_Email.Multiline = true;
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(270, 26);
            this.Txt_Email.TabIndex = 20;
            this.Txt_Email.Text = "ricardo.simao.1357@gmail.com";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(132, 40);
            this.TxtNome.Multiline = true;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(270, 26);
            this.TxtNome.TabIndex = 19;
            this.TxtNome.Text = "Ricardo Simão";
            // 
            // Txt_IdBilhete
            // 
            this.Txt_IdBilhete.Enabled = false;
            this.Txt_IdBilhete.Location = new System.Drawing.Point(146, 130);
            this.Txt_IdBilhete.Name = "Txt_IdBilhete";
            this.Txt_IdBilhete.Size = new System.Drawing.Size(128, 22);
            this.Txt_IdBilhete.TabIndex = 36;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Azure;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.RoyalBlue;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(32, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 23);
            this.label10.TabIndex = 40;
            this.label10.Text = "Operado por";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(488, 116);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(119, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.RoyalBlue;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(280, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(202, 23);
            this.label11.TabIndex = 42;
            this.label11.Text = "Origem";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.RoyalBlue;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(613, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 23);
            this.label6.TabIndex = 43;
            this.label6.Text = "Destino";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.RoyalBlue;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(818, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 23);
            this.label7.TabIndex = 44;
            this.label7.Text = "Nº de Voo";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.RoyalBlue;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(146, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 23);
            this.label12.TabIndex = 45;
            this.label12.Text = "Nº de Bilhete";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.RoyalBlue;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(941, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 23);
            this.label5.TabIndex = 46;
            this.label5.Text = "Categoria";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.RoyalBlue;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(18, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 23);
            this.label8.TabIndex = 47;
            this.label8.Text = "Nome:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.RoyalBlue;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(18, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 23);
            this.label9.TabIndex = 48;
            this.label9.Text = "Nif:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.RoyalBlue;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(18, 135);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 23);
            this.label13.TabIndex = 49;
            this.label13.Text = "Email:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.RoyalBlue;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(18, 179);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 23);
            this.label14.TabIndex = 50;
            this.label14.Text = "Lugar:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtNumeroLugar
            // 
            this.TxtNumeroLugar.Location = new System.Drawing.Point(132, 179);
            this.TxtNumeroLugar.Name = "TxtNumeroLugar";
            this.TxtNumeroLugar.Size = new System.Drawing.Size(100, 26);
            this.TxtNumeroLugar.TabIndex = 52;
            this.TxtNumeroLugar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumeroLugar_KeyPress);
            // 
            // DataGridViewLugares
            // 
            this.DataGridViewLugares.AllowUserToAddRows = false;
            this.DataGridViewLugares.AllowUserToDeleteRows = false;
            this.DataGridViewLugares.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.DataGridViewLugares.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewLugares.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewLugares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewLugares.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewLugares.EnableHeadersVisualStyles = false;
            this.DataGridViewLugares.GridColor = System.Drawing.Color.RoyalBlue;
            this.DataGridViewLugares.Location = new System.Drawing.Point(340, 213);
            this.DataGridViewLugares.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridViewLugares.MultiSelect = false;
            this.DataGridViewLugares.Name = "DataGridViewLugares";
            this.DataGridViewLugares.ReadOnly = true;
            this.DataGridViewLugares.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewLugares.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridViewLugares.RowHeadersVisible = false;
            this.DataGridViewLugares.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.DataGridViewLugares.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridViewLugares.RowTemplate.Height = 24;
            this.DataGridViewLugares.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewLugares.Size = new System.Drawing.Size(133, 287);
            this.DataGridViewLugares.TabIndex = 140;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ButtonEliminar);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TxtNome);
            this.groupBox1.Controls.Add(this.TxtNumeroLugar);
            this.groupBox1.Controls.Add(this.Txt_Email);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.TxtNif);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.ButtonConfirmar);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(489, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 287);
            this.groupBox1.TabIndex = 141;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Cliente";
            // 
            // ButtonEliminar
            // 
            this.ButtonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEliminar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEliminar.ForeColor = System.Drawing.Color.White;
            this.ButtonEliminar.Location = new System.Drawing.Point(294, 231);
            this.ButtonEliminar.Name = "ButtonEliminar";
            this.ButtonEliminar.Size = new System.Drawing.Size(108, 35);
            this.ButtonEliminar.TabIndex = 53;
            this.ButtonEliminar.Text = "Cancelar";
            this.ButtonEliminar.UseVisualStyleBackColor = true;
            this.ButtonEliminar.Click += new System.EventHandler(this.ButtonEliminar_Click);
            // 
            // TxtData
            // 
            this.TxtData.Enabled = false;
            this.TxtData.Location = new System.Drawing.Point(484, 54);
            this.TxtData.Name = "TxtData";
            this.TxtData.Size = new System.Drawing.Size(128, 22);
            this.TxtData.TabIndex = 142;
            this.TxtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtHora
            // 
            this.TxtHora.Enabled = false;
            this.TxtHora.Location = new System.Drawing.Point(488, 91);
            this.TxtHora.Name = "TxtHora";
            this.TxtHora.Size = new System.Drawing.Size(119, 22);
            this.TxtHora.TabIndex = 143;
            this.TxtHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormDadosCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1121, 608);
            this.Controls.Add(this.TxtHora);
            this.Controls.Add(this.TxtData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DataGridViewLugares);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Txt_IdBilhete);
            this.Controls.Add(this.Txt_Categoria);
            this.Controls.Add(this.Txt_IdVoo);
            this.Controls.Add(this.Txt_Destino);
            this.Controls.Add(this.TxtOrigem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDadosCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDadosCliente";
            this.Load += new System.EventHandler(this.FormDadosCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewLugares)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonConfirmar;
        private System.Windows.Forms.TextBox Txt_Categoria;
        private System.Windows.Forms.TextBox Txt_IdVoo;
        private System.Windows.Forms.TextBox Txt_Destino;
        private System.Windows.Forms.TextBox TxtOrigem;
        private System.Windows.Forms.TextBox TxtNif;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox Txt_IdBilhete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtNumeroLugar;
        private System.Windows.Forms.DataGridView DataGridViewLugares;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtData;
        private System.Windows.Forms.TextBox TxtHora;
        private System.Windows.Forms.Button ButtonEliminar;
    }
}