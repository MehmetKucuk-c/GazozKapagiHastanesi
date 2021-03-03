namespace GazozKapagıHastanesi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.PictureBox();
            this.Kapatma = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Txt_ID = new System.Windows.Forms.TextBox();
            this.Txt_Sifre = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BtnGiriş = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kapatma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.Minimize);
            this.panel1.Controls.Add(this.Kapatma);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 28);
            this.panel1.TabIndex = 1;
            // 
            // Minimize
            // 
            this.Minimize.Image = global::GazozKapagıHastanesi.Properties.Resources.minimize;
            this.Minimize.Location = new System.Drawing.Point(293, 3);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(29, 23);
            this.Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimize.TabIndex = 2;
            this.Minimize.TabStop = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Kapatma
            // 
            this.Kapatma.Image = global::GazozKapagıHastanesi.Properties.Resources.Cancel;
            this.Kapatma.Location = new System.Drawing.Point(323, 3);
            this.Kapatma.Name = "Kapatma";
            this.Kapatma.Size = new System.Drawing.Size(29, 23);
            this.Kapatma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Kapatma.TabIndex = 0;
            this.Kapatma.TabStop = false;
            this.Kapatma.Click += new System.EventHandler(this.Kapatma_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 8;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Txt_ID
            // 
            this.Txt_ID.Location = new System.Drawing.Point(112, 136);
            this.Txt_ID.Multiline = true;
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.Size = new System.Drawing.Size(153, 22);
            this.Txt_ID.TabIndex = 0;
            this.Txt_ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Sifre_KeyDown);
            // 
            // Txt_Sifre
            // 
            this.Txt_Sifre.Location = new System.Drawing.Point(112, 164);
            this.Txt_Sifre.Multiline = true;
            this.Txt_Sifre.Name = "Txt_Sifre";
            this.Txt_Sifre.Size = new System.Drawing.Size(153, 22);
            this.Txt_Sifre.TabIndex = 1;
            this.Txt_Sifre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Sifre_KeyDown);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Green;
            this.linkLabel1.Location = new System.Drawing.Point(184, 253);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(81, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Şifremi Unuttum";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(28, 295);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Green;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(28, 295);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(324, 28);
            this.panel3.TabIndex = 9;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GazozKapagıHastanesi.Properties.Resources.Do_a_removebg_preview;
            this.pictureBox3.Location = new System.Drawing.Point(90, 28);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(175, 102);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // BtnGiriş
            // 
            this.BtnGiriş.ActiveBorderThickness = 1;
            this.BtnGiriş.ActiveCornerRadius = 20;
            this.BtnGiriş.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BtnGiriş.ActiveForecolor = System.Drawing.Color.White;
            this.BtnGiriş.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BtnGiriş.BackColor = System.Drawing.SystemColors.Control;
            this.BtnGiriş.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnGiriş.BackgroundImage")));
            this.BtnGiriş.ButtonText = "Giriş";
            this.BtnGiriş.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGiriş.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGiriş.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnGiriş.IdleBorderThickness = 1;
            this.BtnGiriş.IdleCornerRadius = 20;
            this.BtnGiriş.IdleFillColor = System.Drawing.Color.White;
            this.BtnGiriş.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.BtnGiriş.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BtnGiriş.Location = new System.Drawing.Point(90, 207);
            this.BtnGiriş.Margin = new System.Windows.Forms.Padding(5);
            this.BtnGiriş.Name = "BtnGiriş";
            this.BtnGiriş.Size = new System.Drawing.Size(175, 41);
            this.BtnGiriş.TabIndex = 2;
            this.BtnGiriş.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnGiriş.Click += new System.EventHandler(this.BtnGiriş_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Green;
            this.pictureBox2.Image = global::GazozKapagıHastanesi.Properties.Resources.password1;
            this.pictureBox2.Location = new System.Drawing.Point(90, 164);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Green;
            this.pictureBox1.Image = global::GazozKapagıHastanesi.Properties.Resources.user1;
            this.pictureBox1.Location = new System.Drawing.Point(90, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Green;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(323, 28);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(29, 267);
            this.panel4.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(352, 323);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.BtnGiriş);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Txt_Sifre);
            this.Controls.Add(this.Txt_ID);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kapatma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Kapatma;
        private System.Windows.Forms.PictureBox Minimize;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Txt_Sifre;
        private System.Windows.Forms.TextBox Txt_ID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnGiriş;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel4;
    }
}

