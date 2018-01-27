namespace Process_Image_Two
{
    partial class Salvar
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
            this.bntSalvar = new System.Windows.Forms.Button();
            this.picSave = new System.Windows.Forms.PictureBox();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picSave)).BeginInit();
            this.SuspendLayout();
            // 
            // bntSalvar
            // 
            this.bntSalvar.BackgroundImage = global::Process_Image_Two.Properties.Resources.floppy_icon;
            this.bntSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntSalvar.Location = new System.Drawing.Point(170, 310);
            this.bntSalvar.Name = "bntSalvar";
            this.bntSalvar.Size = new System.Drawing.Size(73, 54);
            this.bntSalvar.TabIndex = 1;
            this.bntSalvar.UseVisualStyleBackColor = true;
            this.bntSalvar.Click += new System.EventHandler(this.bntSalvar_Click);
            // 
            // picSave
            // 
            this.picSave.Location = new System.Drawing.Point(12, 12);
            this.picSave.Name = "picSave";
            this.picSave.Size = new System.Drawing.Size(409, 292);
            this.picSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSave.TabIndex = 0;
            this.picSave.TabStop = false;
            // 
            // Salvar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 387);
            this.Controls.Add(this.bntSalvar);
            this.Controls.Add(this.picSave);
            this.Name = "Salvar";
            this.Text = "Salvar";
            this.Load += new System.EventHandler(this.Salvar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picSave;
        private System.Windows.Forms.Button bntSalvar;
        private System.Windows.Forms.SaveFileDialog saveFile;
    }
}