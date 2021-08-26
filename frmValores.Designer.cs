namespace SysDiarias
{
    partial class frmValores
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtpRetorno = new System.Windows.Forms.MaskedTextBox();
            this.dtpSaida = new System.Windows.Forms.MaskedTextBox();
            this.rchFinalidade = new System.Windows.Forms.RichTextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.cmbSecretaria = new System.Windows.Forms.ComboBox();
            this.cmbBanco = new System.Windows.Forms.ComboBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.txtAgencia = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbicone = new System.Windows.Forms.PictureBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.pbBrasao = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTotalDiarias = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.dtpDtSolicit = new System.Windows.Forms.MaskedTextBox();
            this.cmbTransporte = new System.Windows.Forms.ComboBox();
            this.lblTransporte = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTotalHosp = new System.Windows.Forms.TextBox();
            this.txtValorHosp = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtQtdeHosp = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotalAlim = new System.Windows.Forms.TextBox();
            this.txtValorAlim = new System.Windows.Forms.TextBox();
            this.txtQtdeAlim = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbicone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBrasao)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.dtpRetorno);
            this.panel3.Controls.Add(this.dtpSaida);
            this.panel3.Controls.Add(this.rchFinalidade);
            this.panel3.Controls.Add(this.txtDestino);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 263);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(931, 195);
            this.panel3.TabIndex = 23;
            // 
            // dtpRetorno
            // 
            this.dtpRetorno.Location = new System.Drawing.Point(714, 45);
            this.dtpRetorno.Mask = "00/00/0000";
            this.dtpRetorno.Name = "dtpRetorno";
            this.dtpRetorno.Size = new System.Drawing.Size(194, 20);
            this.dtpRetorno.TabIndex = 10;
            this.dtpRetorno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpRetorno.ValidatingType = typeof(System.DateTime);
            // 
            // dtpSaida
            // 
            this.dtpSaida.Location = new System.Drawing.Point(514, 45);
            this.dtpSaida.Mask = "00/00/0000";
            this.dtpSaida.Name = "dtpSaida";
            this.dtpSaida.Size = new System.Drawing.Size(194, 20);
            this.dtpSaida.TabIndex = 9;
            this.dtpSaida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpSaida.ValidatingType = typeof(System.DateTime);
            // 
            // rchFinalidade
            // 
            this.rchFinalidade.Location = new System.Drawing.Point(15, 89);
            this.rchFinalidade.Name = "rchFinalidade";
            this.rchFinalidade.RightMargin = 2;
            this.rchFinalidade.Size = new System.Drawing.Size(897, 83);
            this.rchFinalidade.TabIndex = 11;
            this.rchFinalidade.Text = "";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(15, 45);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(493, 20);
            this.txtDestino.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(12, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(229, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "FINALIDADE(DESCRIÇÃO DETALHADA):";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(711, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "DATA DE RETORNO:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(511, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "DATA DE SAÍDA:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(12, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "DESTINO (CIDADE/ESTADO):";
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(927, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "DADOS DA VIAGEM:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.mskCpf);
            this.panel2.Controls.Add(this.cmbSecretaria);
            this.panel2.Controls.Add(this.cmbBanco);
            this.panel2.Controls.Add(this.txtCargo);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtConta);
            this.panel2.Controls.Add(this.txtAgencia);
            this.panel2.Controls.Add(this.txtNome);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(931, 173);
            this.panel2.TabIndex = 24;
            // 
            // mskCpf
            // 
            this.mskCpf.Location = new System.Drawing.Point(514, 134);
            this.mskCpf.Mask = "000,000,000-00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(398, 20);
            this.mskCpf.TabIndex = 7;
            this.mskCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbSecretaria
            // 
            this.cmbSecretaria.FormattingEnabled = true;
            this.cmbSecretaria.Location = new System.Drawing.Point(15, 133);
            this.cmbSecretaria.Name = "cmbSecretaria";
            this.cmbSecretaria.Size = new System.Drawing.Size(493, 21);
            this.cmbSecretaria.TabIndex = 6;
            // 
            // cmbBanco
            // 
            this.cmbBanco.FormattingEnabled = true;
            this.cmbBanco.Location = new System.Drawing.Point(15, 88);
            this.cmbBanco.Name = "cmbBanco";
            this.cmbBanco.Size = new System.Drawing.Size(493, 21);
            this.cmbBanco.TabIndex = 3;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(514, 44);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(398, 20);
            this.txtCargo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(511, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "CARGO/FUNÇÃO:";
            // 
            // txtConta
            // 
            this.txtConta.Location = new System.Drawing.Point(714, 89);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(198, 20);
            this.txtConta.TabIndex = 5;
            // 
            // txtAgencia
            // 
            this.txtAgencia.Location = new System.Drawing.Point(514, 89);
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.Size = new System.Drawing.Size(194, 20);
            this.txtAgencia.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(15, 44);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(493, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(711, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "CONTA:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(12, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "SECRETARIA DE VÍNCULO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(511, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "CPF:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(12, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "BANCO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(511, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "AGÊNCIA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "NOME:";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(931, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "DADOS DO SERVIDOR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(230)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pbicone);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.pbBrasao);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 90);
            this.panel1.TabIndex = 27;
            // 
            // pbicone
            // 
            this.pbicone.Image = global::SysDiarias.Properties.Resources.icone;
            this.pbicone.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pbicone.Location = new System.Drawing.Point(822, 1);
            this.pbicone.Name = "pbicone";
            this.pbicone.Size = new System.Drawing.Size(99, 89);
            this.pbicone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbicone.TabIndex = 2;
            this.pbicone.TabStop = false;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.label22.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label22.Location = new System.Drawing.Point(98, 45);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(665, 34);
            this.label22.TabIndex = 1;
            this.label22.Text = "Sistema de Requisição de Diárias";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.label21.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label21.Location = new System.Drawing.Point(97, 4);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(698, 41);
            this.label21.TabIndex = 1;
            this.label21.Text = "PREFEITURA MUNICIPAL DE PAPAGAIOS";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbBrasao
            // 
            this.pbBrasao.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbBrasao.Image = global::SysDiarias.Properties.Resources.brasao_novo_sem_fundo;
            this.pbBrasao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pbBrasao.Location = new System.Drawing.Point(0, 0);
            this.pbBrasao.Name = "pbBrasao";
            this.pbBrasao.Size = new System.Drawing.Size(91, 90);
            this.pbBrasao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBrasao.TabIndex = 0;
            this.pbBrasao.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.lblTotalDiarias);
            this.panel5.Controls.Add(this.label23);
            this.panel5.Location = new System.Drawing.Point(0, 107);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(920, 56);
            this.panel5.TabIndex = 26;
            // 
            // lblTotalDiarias
            // 
            this.lblTotalDiarias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalDiarias.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTotalDiarias.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTotalDiarias.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTotalDiarias.Location = new System.Drawing.Point(548, 7);
            this.lblTotalDiarias.Name = "lblTotalDiarias";
            this.lblTotalDiarias.Size = new System.Drawing.Size(351, 38);
            this.lblTotalDiarias.TabIndex = 0;
            this.lblTotalDiarias.Text = "R$ 0,00";
            this.lblTotalDiarias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label23
            // 
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label23.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label23.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label23.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label23.Location = new System.Drawing.Point(293, 7);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(249, 38);
            this.label23.TabIndex = 0;
            this.label23.Text = "TOTAL DAS DIÁRIAS:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.txtPlaca);
            this.panel6.Controls.Add(this.dtpDtSolicit);
            this.panel6.Controls.Add(this.cmbTransporte);
            this.panel6.Controls.Add(this.lblTransporte);
            this.panel6.Controls.Add(this.label29);
            this.panel6.Controls.Add(this.label26);
            this.panel6.Controls.Add(this.label25);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 615);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(931, 84);
            this.panel6.TabIndex = 25;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(369, 50);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(332, 20);
            this.txtPlaca.TabIndex = 19;
            // 
            // dtpDtSolicit
            // 
            this.dtpDtSolicit.Location = new System.Drawing.Point(707, 51);
            this.dtpDtSolicit.Mask = "00/00/0000";
            this.dtpDtSolicit.Name = "dtpDtSolicit";
            this.dtpDtSolicit.Size = new System.Drawing.Size(194, 20);
            this.dtpDtSolicit.TabIndex = 20;
            this.dtpDtSolicit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpDtSolicit.ValidatingType = typeof(System.DateTime);
            // 
            // cmbTransporte
            // 
            this.cmbTransporte.FormattingEnabled = true;
            this.cmbTransporte.ItemHeight = 13;
            this.cmbTransporte.Location = new System.Drawing.Point(19, 50);
            this.cmbTransporte.Name = "cmbTransporte";
            this.cmbTransporte.Size = new System.Drawing.Size(336, 21);
            this.cmbTransporte.TabIndex = 2;
            // 
            // lblTransporte
            // 
            this.lblTransporte.AutoSize = true;
            this.lblTransporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTransporte.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTransporte.Location = new System.Drawing.Point(367, 32);
            this.lblTransporte.Name = "lblTransporte";
            this.lblTransporte.Size = new System.Drawing.Size(166, 15);
            this.lblTransporte.TabIndex = 0;
            this.lblTransporte.Text = "PLACA / CIA AÉREA / VIAÇÃO:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label29.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label29.Location = new System.Drawing.Point(704, 32);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(141, 15);
            this.label29.TabIndex = 0;
            this.label29.Text = "TIPO DE TRANSPORTE:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label26.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label26.Location = new System.Drawing.Point(16, 32);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(141, 15);
            this.label26.TabIndex = 0;
            this.label26.Text = "TIPO DE TRANSPORTE:";
            // 
            // label25
            // 
            this.label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label25.Dock = System.Windows.Forms.DockStyle.Top;
            this.label25.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label25.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label25.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label25.Location = new System.Drawing.Point(0, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(927, 23);
            this.label25.TabIndex = 0;
            this.label25.Text = "PRESTAÇÃO DE CONTAS:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Controls.Add(this.label27);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 448);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(931, 167);
            this.panel4.TabIndex = 28;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.label14);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 107);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(927, 56);
            this.panel7.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label14.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(548, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(351, 38);
            this.label14.TabIndex = 0;
            this.label14.Text = "R$ 0,00";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label15.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label15.Location = new System.Drawing.Point(293, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(249, 38);
            this.label15.TabIndex = 0;
            this.label15.Text = "TOTAL DAS DIÁRIAS:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTotalHosp);
            this.groupBox2.Controls.Add(this.txtValorHosp);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtQtdeHosp);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(459, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 76);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ALIMENTAÇÃO E HOSPEDAGEM:";
            // 
            // txtTotalHosp
            // 
            this.txtTotalHosp.Enabled = false;
            this.txtTotalHosp.Location = new System.Drawing.Point(237, 47);
            this.txtTotalHosp.Name = "txtTotalHosp";
            this.txtTotalHosp.Size = new System.Drawing.Size(205, 21);
            this.txtTotalHosp.TabIndex = 17;
            this.txtTotalHosp.TabStop = false;
            // 
            // txtValorHosp
            // 
            this.txtValorHosp.Location = new System.Drawing.Point(66, 47);
            this.txtValorHosp.Name = "txtValorHosp";
            this.txtValorHosp.Size = new System.Drawing.Size(165, 21);
            this.txtValorHosp.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label16.Location = new System.Drawing.Point(5, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 15);
            this.label16.TabIndex = 0;
            this.label16.Text = "QTDE:";
            // 
            // txtQtdeHosp
            // 
            this.txtQtdeHosp.Location = new System.Drawing.Point(8, 47);
            this.txtQtdeHosp.Name = "txtQtdeHosp";
            this.txtQtdeHosp.Size = new System.Drawing.Size(52, 21);
            this.txtQtdeHosp.TabIndex = 15;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label19.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label19.Location = new System.Drawing.Point(63, 29);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(108, 15);
            this.label19.TabIndex = 0;
            this.label19.Text = "VALOR UNITÁRIO:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label20.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label20.Location = new System.Drawing.Point(234, 29);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(47, 15);
            this.label20.TabIndex = 0;
            this.label20.Text = "TOTAL:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTotalAlim);
            this.groupBox1.Controls.Add(this.txtValorAlim);
            this.groupBox1.Controls.Add(this.txtQtdeAlim);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(10, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ALIMENTAÇÃO:";
            // 
            // txtTotalAlim
            // 
            this.txtTotalAlim.Enabled = false;
            this.txtTotalAlim.Location = new System.Drawing.Point(238, 47);
            this.txtTotalAlim.Name = "txtTotalAlim";
            this.txtTotalAlim.Size = new System.Drawing.Size(205, 21);
            this.txtTotalAlim.TabIndex = 14;
            this.txtTotalAlim.TabStop = false;
            // 
            // txtValorAlim
            // 
            this.txtValorAlim.Location = new System.Drawing.Point(67, 47);
            this.txtValorAlim.Name = "txtValorAlim";
            this.txtValorAlim.Size = new System.Drawing.Size(165, 21);
            this.txtValorAlim.TabIndex = 13;
            // 
            // txtQtdeAlim
            // 
            this.txtQtdeAlim.Location = new System.Drawing.Point(9, 47);
            this.txtQtdeAlim.Name = "txtQtdeAlim";
            this.txtQtdeAlim.Size = new System.Drawing.Size(52, 21);
            this.txtQtdeAlim.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label17.Location = new System.Drawing.Point(235, 29);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 15);
            this.label17.TabIndex = 0;
            this.label17.Text = "TOTAL:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label18.Location = new System.Drawing.Point(64, 29);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(108, 15);
            this.label18.TabIndex = 0;
            this.label18.Text = "VALOR UNITÁRIO:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label24.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label24.Location = new System.Drawing.Point(6, 29);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(43, 15);
            this.label24.TabIndex = 0;
            this.label24.Text = "QTDE:";
            // 
            // label27
            // 
            this.label27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label27.Dock = System.Windows.Forms.DockStyle.Top;
            this.label27.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label27.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label27.Location = new System.Drawing.Point(0, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(927, 22);
            this.label27.TabIndex = 0;
            this.label27.Text = "VALORES DA DIÁRIA:";
            this.label27.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmValores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 699);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Name = "frmValores";
            this.Text = "frmValores";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbicone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBrasao)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MaskedTextBox dtpRetorno;
        private System.Windows.Forms.MaskedTextBox dtpSaida;
        private System.Windows.Forms.RichTextBox rchFinalidade;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.ComboBox cmbSecretaria;
        private System.Windows.Forms.ComboBox cmbBanco;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.TextBox txtAgencia;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbicone;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.PictureBox pbBrasao;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblTotalDiarias;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.MaskedTextBox dtpDtSolicit;
        private System.Windows.Forms.ComboBox cmbTransporte;
        private System.Windows.Forms.Label lblTransporte;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTotalHosp;
        private System.Windows.Forms.TextBox txtValorHosp;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtQtdeHosp;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTotalAlim;
        private System.Windows.Forms.TextBox txtValorAlim;
        private System.Windows.Forms.TextBox txtQtdeAlim;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label27;
    }
}