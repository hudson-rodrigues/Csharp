using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Process_Image_Two
{
    class Histograma_
    {
        public Bitmap image1;
        public Bitmap image2;
        public Bitmap image3;
        
        public double[,] Matriz_R;
        public double[,] Matriz_G;
        public double[,] Matriz_B;
        public double[,] Aux_R;
        public double[,] Aux_G;
        public double[,] Aux_B;
 
        public int[] vetor_NK_R;//>>>>>>>>>>//
        public int[] vetor_NK_G;//HISTOGRAMA// [K]    [NK]
        public int[] vetor_NK_B;//>>>>>>>>>>//

        public int[] vetor_EQ_R;//>>>>>>>>>>//
        public int[] vetor_EQ_G;//EQUALIZADO// [K]    [NK]
        public int[] vetor_EQ_B;//>>>>>>>>>>//

        public double[] vetor_NK_N_R;//>>>>>>>>>>>>//
        public double[] vetor_NK_N_G;//FORMULA NK/N//
        public double[] vetor_NK_N_B;//>>>>>>>>>>>>//

        public double[] vetor_S_R;//>>>>>>>>>>>>//
        public double[] vetor_S_G;//FORMULA S   //
        public double[] vetor_S_B;//>>>>>>>>>>>>//

        public int[] Nova_Cor_R;//>>>>>>>>>>>>//
        public int[] Nova_Cor_G;// NOVA COR   //
        public int[] Nova_Cor_B;//>>>>>>>>>>>>//
        private void gera_matriz()
        {
            Color pixel;
            for (int i = 0; i < image1.Width; i++)
            {
                for (int j = 0; j < image1.Height; j++)
                {
                    pixel = image1.GetPixel(i, j);
//--------------------------------------------------------------------
                    vetor_NK_R[pixel.R] = vetor_NK_R[pixel.R] + 1;
                    vetor_NK_G[pixel.G] = vetor_NK_G[pixel.G] + 1;
                    vetor_NK_B[pixel.B] = vetor_NK_B[pixel.B] + 1;
//--------------------------------------------------------------------
                    Matriz_R[i, j] = pixel.R;
                    Matriz_G[i, j] = pixel.G;
                    Matriz_B[i, j] = pixel.B;

//--------------------------------------------------------------------
                    Aux_R[i, j] = pixel.R;
                    Aux_G[i, j] = pixel.G;
                    Aux_B[i, j] = pixel.B;
                }
            }
        }
        public void gerar_equalizador()
        {
            Color pixel;
            for (int i = 0; i < image3.Width; i++)
            {
                for (int j = 0; j < image3.Height; j++)
                {
                    pixel = image3.GetPixel(i, j);
                    vetor_EQ_R[pixel.R] = vetor_EQ_R[pixel.R] + 1;
                    vetor_EQ_G[pixel.G] = vetor_EQ_G[pixel.G] + 1;
                    vetor_EQ_B[pixel.B] = vetor_EQ_B[pixel.B] + 1;
                }
            }
        }
        private void zerar()
        {
            for (int i = 0; i < 256; i++) { 
                vetor_NK_R[i]=vetor_NK_G[i]=vetor_NK_B[i]=Nova_Cor_R[i]=Nova_Cor_G[i]=Nova_Cor_B[i] = 0;
                vetor_NK_N_R[i] = vetor_NK_N_G[i] = vetor_NK_N_B[i] = vetor_S_R[i] = vetor_S_G[i] = vetor_S_B[i] = vetor_EQ_R[i] = vetor_EQ_G[i]= vetor_EQ_B[i]= 0;
            }
        }
        public void achar_histograma()
        {//Instânciando as matrizes com o tamanho da image1 do picture box 1
            vetor_NK_R = new int[256];
            vetor_NK_G = new int[256];
            vetor_NK_B = new int[256];

            vetor_NK_N_R = new double[256];
            vetor_NK_N_G = new double[256];
            vetor_NK_N_B = new double[256];

            vetor_S_R = new double[256];
            vetor_S_G = new double[256];
            vetor_S_B = new double[256];

            Nova_Cor_R = new int[256];
            Nova_Cor_G = new int[256];
            Nova_Cor_B = new int[256];

            vetor_EQ_R = new int[256];
            vetor_EQ_G = new int[256];
            vetor_EQ_B = new int[256];

            zerar();
            Matriz_R = new double[image1.Width, image1.Height];
            Matriz_G = new double[image1.Width, image1.Height];
            Matriz_B = new double[image1.Width, image1.Height];
            Aux_R = new double[image1.Width, image1.Height];
            Aux_G = new double[image1.Width, image1.Height];
            Aux_B = new double[image1.Width, image1.Height];
            gera_matriz();
        }

        public void equalizar(double tamanho)
        {
            //variavel soma
            double soma_r=0, soma_g=0, soma_b = 0;
            int r=0, g=0, b=0;
            //NK/N
            for (int i = 0; i < 256;i++)
            {
                vetor_NK_N_R[i] = (vetor_NK_R[i] / tamanho);
                vetor_NK_N_G[i] = (vetor_NK_G[i] / tamanho);
                vetor_NK_N_B[i] = (vetor_NK_B[i] / tamanho);
            }
            //S
            for (int i = 0; i < 256; i++)
            {
                soma_r += vetor_NK_N_R[i];
                vetor_S_R[i] = soma_r;

                soma_g += vetor_NK_N_G[i];
                vetor_S_G[i] = soma_g;

                soma_b += vetor_NK_N_B[i];
                vetor_S_B[i] = soma_b;
            }
            //Nova Cor
            for (int i = 0; i < 256; i++)
            {
                Nova_Cor_R[i] = (int)Math.Round(vetor_S_R[i] * 255);
                Nova_Cor_G[i] = (int)Math.Round(vetor_S_G[i] * 255);
                Nova_Cor_B[i] = (int)Math.Round(vetor_S_B[i] * 255);
            }
            for (int i = 0; i < image1.Width; i++)
            {
                for (int j = 0; j < image1.Height; j++)
                {
                    r = (int)Matriz_R[i, j];
                    g = (int)Matriz_G[i, j];
                    b = (int)Matriz_B[i, j];
                    Aux_R[i, j] = Nova_Cor_R[r];
                    Aux_G[i, j] = Nova_Cor_G[g];
                    Aux_B[i, j] = Nova_Cor_B[b];
                }
            }
        }
        public Bitmap imagem_equalizada()
        {
            int R = 0, G = 0, B = 0;
            for (int i = 0; i < image1.Width; i++)
            {
                for (int j = 0; j < image1.Height; j++)
                {
                    R = (int)Aux_R[i, j];
                    G = (int)Aux_G[i, j];
                    B = (int)Aux_B[i, j];
                    image3.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }
            return image3;
        }
    }
}
