using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Process_Image_Two
{
    public partial class Histograma : Form
    {
        public Histograma()
        {
            InitializeComponent();
        }
        Histograma_ ht = new Histograma_();
        

        private void bntAbrir_Click(object sender, EventArgs e)
        {
            if(open.ShowDialog()==DialogResult.OK)//guardando a imagem aberta na image1
            {
                if(ht.image1!=null)
                    ht.image1.Dispose();
                if (ht.image2 != null)
                    ht.image2.Dispose();
                ht.image1 = new Bitmap(open.FileName);
                ht.image3 = ht.image1;
                pic1.Image = ht.image1;
            }
        }

        private void bntEqualizar_Click(object sender, EventArgs e)
        {
            double tamanho= ht.image1.Width * ht.image1.Height;
            ht.achar_histograma();
            ht.equalizar(tamanho);
            pic2.Image = ht.imagem_equalizada();
        }

        private void bntHistograma_Click(object sender, EventArgs e)
        {//limpa todas as series do gráfico
            
            chartRed.Series.Clear();
            chartGreen.Series.Clear();
            chartBlue.Series.Clear();
            Series series_red = this.chartRed.Series.Add("Red");
            Series series_green = this.chartGreen.Series.Add("Green");
            Series series_blue = this.chartBlue.Series.Add("Blue");
            for (int i = 0; i < 256; i++)
            {
                series_red.Points.Add(ht.vetor_NK_R[i]);
                series_green.Points.Add(ht.vetor_NK_G[i]);
                series_blue.Points.Add(ht.vetor_NK_B[i]);
            }

        }
        private void Histograma_Load(object sender, EventArgs e)
        {
        }

        private void bntEqualizado_Click(object sender, EventArgs e)
        {
            ht.gerar_equalizador();
            chartEqRed.Series.Clear();
            chartEqGreen.Series.Clear();
            chartEqBlue.Series.Clear();
            Series series_red_eq = this.chartEqRed.Series.Add("Red");
            Series series_green_eq = this.chartEqGreen.Series.Add("Green");
            Series series_blue_eq = this.chartEqBlue.Series.Add("Blue");
            for (int i = 0; i < 256; i++)
            {
                series_red_eq.Points.Add(ht.vetor_EQ_R[i]);
                series_green_eq.Points.Add(ht.vetor_EQ_G[i]);
                series_blue_eq.Points.Add(ht.vetor_EQ_B[i]);
            }
        }
    }
}
