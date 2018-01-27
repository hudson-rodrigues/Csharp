using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Process_Image_Two
{
    public partial class Passa_alta : Form
    {
        public Passa_alta()
        {
            InitializeComponent();
        }
        Filtragem_Espacial FE = new Filtragem_Espacial();
        private void bntAbrir_Click(object sender, EventArgs e)
        {
            if (open.ShowDialog() == DialogResult.OK)
            {
                if (FE.image1 != null)
                    FE.image1.Dispose();
                FE.image1 = new Bitmap(open.FileName);
                pic1.Image = FE.image1;
                FE.image2 = FE.image1;
            }
            bntPassaBaixa.Enabled = true;
        }

        private void bntPassaBaixa_Click(object sender, EventArgs e)
        {
            pic2.Image = FE.Passa_Baixa(FE.image2);
            //**if (baixa ==*/ 0)*/
            //{
            //    bntPassaBaixa.Enabled = false;
            //    bntPassaAlta.Enabled = false;
            //}
                      
        }

        private void bntPassaAlta_Click(object sender, EventArgs e)
        {
            pic2.Image = FE.Passa_Alta(FE.image2);
            //if (alta == 1)
            //{
            //    bntPassaBaixa.Enabled = false;
            //    bntPassaAlta.Enabled = false;
            //}
        }

        private void Passa_alta_Load(object sender, EventArgs e)
        {
          //  bntSomaTruncada.Enabled = bntSomaNormalizada.Enabled = false;
        }

        private void checkTruncado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkNormalizado_CheckedChanged(object sender, EventArgs e)
        {   

        }

        private void bntSomaNormalizada_Click(object sender, EventArgs e)
        {
            Bitmap img = FE.Soma_Normalizada();//a original tem sempre que ficar na image1
            Salvar sa = new Salvar(img);
            sa.ShowDialog();
        }

        private void bntSomaTruncada_Click(object sender, EventArgs e)
        {
            Bitmap img = FE.Soma_Truncada();//a original tem sempre que ficar na image1
            Salvar sa = new Salvar(img);
            sa.ShowDialog();
        }

        private void bntPassaBaixa2_Click(object sender, EventArgs e)
        {
            pic2.Image = FE.Passa_Baixa(FE.image2);
        }

        private void bntPassaAlta2_Click(object sender, EventArgs e)
        {
                pic2.Image = FE.Passa_Alta(FE.image2);
        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {
        //    Bitmap image;
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                pic2.Image.Save(saveFile.FileName);
            }
        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It's Okay !");
            pic1.Image = null;
            pic2.Image = null;
            FE.image1 = FE.image2 = FE.image3 = null;
            FE.soma_R = FE.soma_G = FE.soma_B = 0;
            FE.R = FE.G = FE.B = 0;
            bntPassaAlta.Enabled = bntPassaBaixa.Enabled = bntPassaBaixa2.Enabled = bntPassaAlta2.Enabled = true;

        }
    }
}
