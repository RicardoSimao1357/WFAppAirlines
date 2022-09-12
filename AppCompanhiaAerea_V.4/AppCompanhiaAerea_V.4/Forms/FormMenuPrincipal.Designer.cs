namespace AppCompanhiaAerea_V._4.Forms
{
    partial class FormMenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.PanelCabecalho = new System.Windows.Forms.Panel();
            this.PanelConteudo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.sidebar = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ButtonSair = new System.Windows.Forms.Button();
            this.BtnSobre = new System.Windows.Forms.Button();
            this.BtnBilhetes = new System.Windows.Forms.Button();
            this.BtnVoos = new System.Windows.Forms.Button();
            this.BtnAvioes = new System.Windows.Forms.Button();
            this.MenuButton = new System.Windows.Forms.PictureBox();
            this.BtnAeroportos = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButton)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelCabecalho
            // 
            this.PanelCabecalho.BackColor = System.Drawing.Color.RoyalBlue;
            this.PanelCabecalho.Location = new System.Drawing.Point(182, 0);
            this.PanelCabecalho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelCabecalho.Name = "PanelCabecalho";
            this.PanelCabecalho.Size = new System.Drawing.Size(921, 66);
            this.PanelCabecalho.TabIndex = 0;
            // 
            // PanelConteudo
            // 
            this.PanelConteudo.BackColor = System.Drawing.Color.RoyalBlue;
            this.PanelConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelConteudo.Location = new System.Drawing.Point(185, 0);
            this.PanelConteudo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelConteudo.Name = "PanelConteudo";
            this.PanelConteudo.Size = new System.Drawing.Size(918, 590);
            this.PanelConteudo.TabIndex = 108;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.MenuButton);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 92);
            this.panel1.TabIndex = 106;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.BtnVoos);
            this.panel4.Location = new System.Drawing.Point(0, 149);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(185, 58);
            this.panel4.TabIndex = 106;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(3, 58);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(185, 58);
            this.panel5.TabIndex = 106;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.BtnBilhetes);
            this.panel6.Location = new System.Drawing.Point(0, 265);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(185, 58);
            this.panel6.TabIndex = 106;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.BtnSobre);
            this.panel7.Location = new System.Drawing.Point(0, 322);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(185, 58);
            this.panel7.TabIndex = 107;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 106;
            this.label1.Text = "Menu";
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel7);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.BtnAvioes);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.BtnAeroportos);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidebar.MaximumSize = new System.Drawing.Size(185, 590);
            this.sidebar.MinimumSize = new System.Drawing.Size(65, 590);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(185, 590);
            this.sidebar.TabIndex = 107;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(3, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(185, 58);
            this.panel3.TabIndex = 107;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ButtonSair);
            this.panel2.Location = new System.Drawing.Point(1, 384);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 58);
            this.panel2.TabIndex = 107;
            // 
            // ButtonSair
            // 
            this.ButtonSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.ButtonSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.ButtonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSair.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSair.ForeColor = System.Drawing.Color.White;
            this.ButtonSair.Image = global::AppCompanhiaAerea_V._4.Properties.Resources.btExit;
            this.ButtonSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSair.Location = new System.Drawing.Point(5, 1);
            this.ButtonSair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonSair.Name = "ButtonSair";
            this.ButtonSair.Size = new System.Drawing.Size(175, 58);
            this.ButtonSair.TabIndex = 106;
            this.ButtonSair.Text = "          Sair";
            this.ButtonSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSair.UseVisualStyleBackColor = false;
            this.ButtonSair.Click += new System.EventHandler(this.ButtonSair_Click);
            // 
            // BtnSobre
            // 
            this.BtnSobre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.BtnSobre.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.BtnSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSobre.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSobre.ForeColor = System.Drawing.Color.White;
            this.BtnSobre.Image = global::AppCompanhiaAerea_V._4.Properties.Resources.btAbout;
            this.BtnSobre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSobre.Location = new System.Drawing.Point(7, 6);
            this.BtnSobre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSobre.Name = "BtnSobre";
            this.BtnSobre.Size = new System.Drawing.Size(175, 58);
            this.BtnSobre.TabIndex = 8;
            this.BtnSobre.Text = "          Sobre";
            this.BtnSobre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSobre.UseVisualStyleBackColor = false;
            this.BtnSobre.Click += new System.EventHandler(this.BtnSobre_Click);
            // 
            // BtnBilhetes
            // 
            this.BtnBilhetes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.BtnBilhetes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.BtnBilhetes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBilhetes.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBilhetes.ForeColor = System.Drawing.Color.White;
            this.BtnBilhetes.Image = global::AppCompanhiaAerea_V._4.Properties.Resources.btBilhete;
            this.BtnBilhetes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBilhetes.Location = new System.Drawing.Point(7, 2);
            this.BtnBilhetes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnBilhetes.Name = "BtnBilhetes";
            this.BtnBilhetes.Size = new System.Drawing.Size(175, 58);
            this.BtnBilhetes.TabIndex = 0;
            this.BtnBilhetes.Text = "          Bilhetes";
            this.BtnBilhetes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBilhetes.UseVisualStyleBackColor = false;
            this.BtnBilhetes.Click += new System.EventHandler(this.BtnBilhetes_Click);
            // 
            // BtnVoos
            // 
            this.BtnVoos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.BtnVoos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.BtnVoos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVoos.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoos.ForeColor = System.Drawing.Color.White;
            this.BtnVoos.Image = global::AppCompanhiaAerea_V._4.Properties.Resources.btVoos;
            this.BtnVoos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVoos.Location = new System.Drawing.Point(6, -2);
            this.BtnVoos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnVoos.Name = "BtnVoos";
            this.BtnVoos.Size = new System.Drawing.Size(175, 58);
            this.BtnVoos.TabIndex = 2;
            this.BtnVoos.Text = "           Voos";
            this.BtnVoos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVoos.UseVisualStyleBackColor = false;
            this.BtnVoos.Click += new System.EventHandler(this.BtnVoos_Click);
            // 
            // BtnAvioes
            // 
            this.BtnAvioes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.BtnAvioes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.BtnAvioes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAvioes.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAvioes.ForeColor = System.Drawing.Color.White;
            this.BtnAvioes.Image = global::AppCompanhiaAerea_V._4.Properties.Resources.btAvioes;
            this.BtnAvioes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAvioes.Location = new System.Drawing.Point(6, 86);
            this.BtnAvioes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAvioes.Name = "BtnAvioes";
            this.BtnAvioes.Size = new System.Drawing.Size(175, 58);
            this.BtnAvioes.TabIndex = 6;
            this.BtnAvioes.Text = "           Aviões";
            this.BtnAvioes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAvioes.UseVisualStyleBackColor = false;
            this.BtnAvioes.Click += new System.EventHandler(this.BtnAvioes_Click);
            // 
            // MenuButton
            // 
            this.MenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuButton.Image = global::AppCompanhiaAerea_V._4.Properties.Resources.btMenu;
            this.MenuButton.Location = new System.Drawing.Point(8, 28);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(42, 38);
            this.MenuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuButton.TabIndex = 106;
            this.MenuButton.TabStop = false;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // BtnAeroportos
            // 
            this.BtnAeroportos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.BtnAeroportos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.BtnAeroportos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAeroportos.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAeroportos.ForeColor = System.Drawing.Color.White;
            this.BtnAeroportos.Image = global::AppCompanhiaAerea_V._4.Properties.Resources.btAeroportos;
            this.BtnAeroportos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAeroportos.Location = new System.Drawing.Point(7, 205);
            this.BtnAeroportos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAeroportos.Name = "BtnAeroportos";
            this.BtnAeroportos.Size = new System.Drawing.Size(175, 58);
            this.BtnAeroportos.TabIndex = 4;
            this.BtnAeroportos.Text = "          Destinos";
            this.BtnAeroportos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAeroportos.UseVisualStyleBackColor = false;
            this.BtnAeroportos.Click += new System.EventHandler(this.BtnAeroportos_Click);
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1103, 590);
            this.ControlBox = false;
            this.Controls.Add(this.PanelConteudo);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.PanelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.sidebar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MenuButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelCabecalho;
        private System.Windows.Forms.Button BtnSobre;
        private System.Windows.Forms.Button BtnAvioes;
        private System.Windows.Forms.Button BtnAeroportos;
        private System.Windows.Forms.Button BtnVoos;
        private System.Windows.Forms.Button BtnBilhetes;
        private System.Windows.Forms.Panel PanelConteudo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox MenuButton;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ButtonSair;
    }
}