namespace Process_Image_Two
{
    partial class Passa_alta
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
            this.open = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.bntPassaAlta = new System.Windows.Forms.Button();
            this.bntSomaNormalizada = new System.Windows.Forms.Button();
            this.bntPassaBaixa = new System.Windows.Forms.Button();
            this.bntSomaTruncada = new System.Windows.Forms.Button();
            this.bntPassaBaixa2 = new System.Windows.Forms.Button();
            this.bntPassaAlta2 = new System.Windows.Forms.Button();
            this.bntLimpar = new System.Windows.Forms.Button();
            this.bntAbrir = new System.Windows.Forms.Button();
            this.bntSalvar = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            this.SuspendLayout();
            // 
            // open
            // 
            this.open.FileName = "openFile";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.pic1);
            this.panel1.Location = new System.Drawing.Point(230, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 216);
            this.panel1.TabIndex = 1;
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(3, 3);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(264, 210);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.pic2);
            this.panel2.Location = new System.Drawing.Point(230, 222);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 210);
            this.panel2.TabIndex = 3;
            // 
            // pic2
            // 
            this.pic2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pic2.Location = new System.Drawing.Point(3, 3);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(264, 204);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2.TabIndex = 2;
            this.pic2.TabStop = false;
            // 
            // bntPassaAlta
            // 
            this.bntPassaAlta.BackColor = System.Drawing.Color.LavenderBlush;
            this.bntPassaAlta.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.bntPassaAlta.Location = new System.Drawing.Point(131, 136);
            this.bntPassaAlta.Name = "bntPassaAlta";
            this.bntPassaAlta.Size = new System.Drawing.Size(75, 23);
            this.bntPassaAlta.TabIndex = 3;
            this.bntPassaAlta.Text = "Passa Alta";
            this.bntPassaAlta.UseVisualStyleBackColor = false;
            this.bntPassaAlta.Click += new System.EventHandler(this.bntPassaAlta_Click);
            // 
            // bntSomaNormalizada
            // 
            this.bntSomaNormalizada.BackColor = System.Drawing.Color.LavenderBlush;
            this.bntSomaNormalizada.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.bntSomaNormalizada.Location = new System.Drawing.Point(57, 193);
            this.bntSomaNormalizada.Name = "bntSomaNormalizada";
            this.bntSomaNormalizada.Size = new System.Drawing.Size(112, 23);
            this.bntSomaNormalizada.TabIndex = 4;
            this.bntSomaNormalizada.Text = "Soma Normalizada";
            this.bntSomaNormalizada.UseVisualStyleBackColor = false;
            this.bntSomaNormalizada.Click += new System.EventHandler(this.bntSomaNormalizada_Click);
            // 
            // bntPassaBaixa
            // 
            this.bntPassaBaixa.BackColor = System.Drawing.Color.LavenderBlush;
            this.bntPassaBaixa.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.bntPassaBaixa.Location = new System.Drawing.Point(21, 136);
            this.bntPassaBaixa.Name = "bntPassaBaixa";
            this.bntPassaBaixa.Size = new System.Drawing.Size(75, 23);
            this.bntPassaBaixa.TabIndex = 2;
            this.bntPassaBaixa.Text = "Passa Baixa";
            this.bntPassaBaixa.UseVisualStyleBackColor = false;
            this.bntPassaBaixa.Click += new System.EventHandler(this.bntPassaBaixa_Click);
            // 
            // bntSomaTruncada
            // 
            this.bntSomaTruncada.BackColor = System.Drawing.Color.LavenderBlush;
            this.bntSomaTruncada.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.bntSomaTruncada.Location = new System.Drawing.Point(57, 225);
            this.bntSomaTruncada.Name = "bntSomaTruncada";
            this.bntSomaTruncada.Size = new System.Drawing.Size(112, 23);
            this.bntSomaTruncada.TabIndex = 5;
            this.bntSomaTruncada.Text = "Soma Truncada";
            this.bntSomaTruncada.UseVisualStyleBackColor = false;
            this.bntSomaTruncada.Click += new System.EventHandler(this.bntSomaTruncada_Click);
            // 
            // bntPassaBaixa2
            // 
            this.bntPassaBaixa2.BackColor = System.Drawing.Color.LavenderBlush;
            this.bntPassaBaixa2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.bntPassaBaixa2.Location = new System.Drawing.Point(21, 336);
            this.bntPassaBaixa2.Name = "bntPassaBaixa2";
            this.bntPassaBaixa2.Size = new System.Drawing.Size(75, 23);
            this.bntPassaBaixa2.TabIndex = 6;
            this.bntPassaBaixa2.Text = "Passa Baixa";
            this.bntPassaBaixa2.UseVisualStyleBackColor = false;
            this.bntPassaBaixa2.Click += new System.EventHandler(this.bntPassaBaixa2_Click);
            // 
            // bntPassaAlta2
            // 
            this.bntPassaAlta2.BackColor = System.Drawing.Color.LavenderBlush;
            this.bntPassaAlta2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.bntPassaAlta2.Location = new System.Drawing.Point(131, 336);
            this.bntPassaAlta2.Name = "bntPassaAlta2";
            this.bntPassaAlta2.Size = new System.Drawing.Size(75, 23);
            this.bntPassaAlta2.TabIndex = 7;
            this.bntPassaAlta2.Text = "Passa Alta";
            this.bntPassaAlta2.UseVisualStyleBackColor = false;
            this.bntPassaAlta2.Click += new System.EventHandler(this.bntPassaAlta2_Click);
            // 
            // bntLimpar
            // 
            this.bntLimpar.BackColor = System.Drawing.Color.LavenderBlush;
            this.bntLimpar.BackgroundImage = global::Process_Image_Two.Properties.Resources.vassoura;
            this.bntLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntLimpar.Location = new System.Drawing.Point(147, 26);
            this.bntLimpar.Name = "bntLimpar";
            this.bntLimpar.Size = new System.Drawing.Size(59, 53);
            this.bntLimpar.TabIndex = 8;
            this.bntLimpar.UseVisualStyleBackColor = false;
            this.bntLimpar.Click += new System.EventHandler(this.bntLimpar_Click);
            // 
            // bntAbrir
            // 
            this.bntAbrir.BackColor = System.Drawing.Color.LavenderBlush;
            this.bntAbrir.BackgroundImage = global::Process_Image_Two.Properties.Resources.open_file_40455;
            this.bntAbrir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntAbrir.Location = new System.Drawing.Point(21, 26);
            this.bntAbrir.Name = "bntAbrir";
            this.bntAbrir.Size = new System.Drawing.Size(69, 50);
            this.bntAbrir.TabIndex = 1;
            this.bntAbrir.UseVisualStyleBackColor = false;
            this.bntAbrir.Click += new System.EventHandler(this.bntAbrir_Click);
            // 
            // bntSalvar
            // 
            this.bntSalvar.BackgroundImage = global::Process_Image_Two.Properties.Resources.floppy_icon;
            this.bntSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntSalvar.Location = new System.Drawing.Point(84, 272);
            this.bntSalvar.Name = "bntSalvar";
            this.bntSalvar.Size = new System.Drawing.Size(60, 46);
            this.bntSalvar.TabIndex = 9;
            this.bntSalvar.UseVisualStyleBackColor = true;
            this.bntSalvar.Click += new System.EventHandler(this.bntSalvar_Click);
            // 
            // Passa_alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 436);
            this.Controls.Add(this.bntSalvar);
            this.Controls.Add(this.bntLimpar);
            this.Controls.Add(this.bntPassaBaixa2);
            this.Controls.Add(this.bntPassaAlta2);
            this.Controls.Add(this.bntSomaTruncada);
            this.Controls.Add(this.bntPassaBaixa);
            this.Controls.Add(this.bntSomaNormalizada);
            this.Controls.Add(this.bntPassaAlta);
            this.Controls.Add(this.bntAbrir);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Passa_alta";
            this.Text = "Filtragem Espacial";
            this.Load += new System.EventHandler(this.Passa_alta_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog open;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bntAbrir;
        private System.Windows.Forms.Button bntPassaAlta;
        private System.Windows.Forms.Button bntSomaNormalizada;
        private System.Windows.Forms.Button bntPassaBaixa;
        private System.Windows.Forms.Button bntSomaTruncada;
        private System.Windows.Forms.Button bntPassaBaixa2;
        private System.Windows.Forms.Button bntPassaAlta2;
        private System.Windows.Forms.Button bntLimpar;
        private System.Windows.Forms.Button bntSalvar;
        private System.Windows.Forms.SaveFileDialog saveFile;
    }
}

