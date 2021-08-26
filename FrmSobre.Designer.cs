namespace SysDiarias
{
    partial class FrmSobre
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
            this.btnSobreFechar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnSobreFechar
            // 
            this.btnSobreFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnSobreFechar.BackgroundImage = global::SysDiarias.Properties.Resources.icone_FecharC;
            this.btnSobreFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSobreFechar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnSobreFechar.FlatAppearance.BorderSize = 0;
            this.btnSobreFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSobreFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSobreFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSobreFechar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobreFechar.Location = new System.Drawing.Point(227, 424);
            this.btnSobreFechar.Name = "btnSobreFechar";
            this.btnSobreFechar.Size = new System.Drawing.Size(74, 78);
            this.btnSobreFechar.TabIndex = 3;
            this.btnSobreFechar.UseVisualStyleBackColor = false;
            this.btnSobreFechar.Click += new System.EventHandler(this.btnSobreFechar_Click);
            this.btnSobreFechar.MouseLeave += new System.EventHandler(this.BtnSobreFechar_MouseLeave);
            this.btnSobreFechar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnSobreFechar_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // FrmSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(200)))), ((int)(((byte)(196)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(510, 540);
            this.Controls.Add(this.btnSobreFechar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSobre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSobre";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(200)))), ((int)(((byte)(196)))));
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSobreFechar;
        private System.Windows.Forms.Timer timer1;
    }
}