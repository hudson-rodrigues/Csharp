using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Process_Image_Two
{
    class Filtragem_Espacial
    {
        public Bitmap image1;//imagem original
        public Bitmap image2;//imagem resultante
        public Bitmap image3;//imagem auxiliar
        public double[,] matriz_R;
        public double[,] matriz_G;
        public double[,] matriz_B;
        public double[,] matriz_r;
        public double[,] matriz_g;
        public double[,] matriz_b;
        public int[,] filtro_baixa = { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };//declarando o filtro passa baixa
        public int[,] filtro = { { -1, -1, -1 }, { -1, 8, -1 }, { -1, -1, -1 } };//declarando o filtro passa alta
        public int l, c;
        public double soma_R;
        public double soma_G;
        public double soma_B;
        public int R, G, B;
        //---------------------------
        private double maior_r, maior_g, maior_b, menor_r, menor_g, menor_b;
        private double[,] Matriz_R;
        private double[,] Matriz_G;
        private double[,] Matriz_B;


        private void gera_matriz(Bitmap imagem)
        {
            Color pixel;
            for (int i = 0; i < image1.Width; i++)
            {
                for (int j = 0; j < image1.Height; j++)
                {
                    pixel = imagem.GetPixel(i, j);
                    
                    matriz_R[i, j] = pixel.R;
                    matriz_r[i, j] = pixel.R;
                    matriz_G[i, j] = pixel.G;
                    matriz_g[i, j] = pixel.G;
                    matriz_B[i, j] = pixel.B;
                    matriz_b[i, j] = pixel.B;
                }
            }
        }
        private void somador_alta(int linha, int coluna)
        {
            l = c = 0;
            soma_R = soma_G = soma_B = 0;
            for (int i = linha; i < linha + 3; l++, i++)
            {
                for (int j = coluna; j < coluna + 3; j++)
                {
                    soma_R += matriz_R[i, j] * filtro[l, c];
                    soma_G += matriz_G[i, j] * filtro[l, c];
                    soma_B += matriz_B[i, j] * filtro[l, c];
                    c++;
                    if (c == 3)
                        c = 0;
                }
            }

        }
        private void somador(int linha, int coluna)
        {
            l = c = 0;
            soma_R = soma_G = soma_B = 0;
            for (int i = linha; i < linha + 3; l++, i++)
            {
                for (int j = coluna; j < coluna + 3; j++)
                {
                    soma_R += matriz_R[i, j] * filtro_baixa[l, c];
                    soma_G += matriz_G[i, j] * filtro_baixa[l, c];
                    soma_B += matriz_B[i, j] * filtro_baixa[l, c];

                   
                    c++;
                    if (c == 3)
                        c = 0;
                }
            }
        }
        public Bitmap Passa_Baixa(Bitmap imagem)
        {
            Bitmap image;
            image = new Bitmap(image1.Width, image1.Height);//a imagem
            matriz_R = new double[image1.Width, image1.Height];//declarando a matriz do tamanho da imagem
            matriz_G = new double[image1.Width, image1.Height];
            matriz_B = new double[image1.Width, image1.Height];
            matriz_r = new double[image1.Width, image1.Height];
            matriz_g = new double[image1.Width, image1.Height];
            matriz_b = new double[image1.Width, image1.Height];
            gera_matriz(imagem);
            for (int i = 1; i < image.Width - 1; i++)//percorrendo a linha da imagem
            {
                for (int j = 1; j < image.Height - 1; j++)//percorrendo a coluna da imagem
                {
                    somador(i - 1, j - 1);
                    matriz_r[i, j] = soma_R / 9;
                    matriz_g[i, j] = soma_G / 9;
                    matriz_b[i, j] = soma_B / 9;
                }
            }
            for (int i = 0; i < image1.Width; i++)
            {
                for (int j = 0; j < image1.Height; j++)
                {
                    R = (int)matriz_r[i, j];
                    G = (int)matriz_g[i, j];
                    B = (int)matriz_b[i, j];
                    if (R > 255) R = 255;
                    if (G > 255) G = 255;
                    if (B > 255) B = 255;
                    if (R < 0) R = 0;
                    if (G < 0) G = 0;
                    if (B < 0) B = 0;
                    image.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }
            image2 = image;
            return image;
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------
        public Bitmap Passa_Alta(Bitmap imagem)
        {
            Bitmap image;
            image = new Bitmap(image1.Width, image1.Height);
            matriz_R = new double[image1.Width, image1.Height];//declarando a matriz do tamanho da imagem
            matriz_G = new double[image1.Width, image1.Height];
            matriz_B = new double[image1.Width, image1.Height];
            matriz_r = new double[image1.Width, image1.Height];
            matriz_g = new double[image1.Width, image1.Height];
            matriz_b = new double[image1.Width, image1.Height];
            gera_matriz(imagem);
            for (int i = 1; i < image1.Width - 1; i++)//percorrendo a linha da imagem
            {
                for (int j = 1; j < image1.Height - 1; j++)//percorrendo a coluna da imagem
                {
                    somador_alta(i - 1, j - 1);
                    R = (int)soma_R;
                    G = (int)soma_G;
                    B = (int)soma_B;
                        if (R > 255)R = 255;
                        if (G > 255) G = 255;
                        if (B > 255) B = 255;
                        if (R < 0) R = 0;
                        if (G < 0) G = 0;
                        if (B < 0) B = 0;
                        image.SetPixel(i, j, Color.FromArgb(R, G, B)); 
                }
            }
            image2 = image;
            return image;
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------
        /*NORMALIZADA*/
     
        //------------------------------------------------------------------------------------------------
        private void acha_maior_menor()
        {
            maior_r = maior_g = maior_b = menor_r = menor_g = menor_b = 0;//maiores e menores
            Color Pixel;
            //pegando a primeira posição da imagem
            maior_r = menor_r = Matriz_R[0, 0];
            maior_g = menor_g = Matriz_G[0, 0];
            maior_b = menor_b = Matriz_B[0, 0];
            //------------------------------------
            for (int i = 0; i < image1.Width; i++)
            {
                for (int j = 0; j < image1.Height; j++)
                {
                    Pixel = image1.GetPixel(i, j);
                    if (Matriz_R[i, j] > maior_r) maior_r = Matriz_R[i, j];
                    if (Matriz_G[i, j] > maior_g) maior_g = Matriz_G[i, j];
                    if (Matriz_B[i, j] > maior_b) maior_b = Matriz_B[i, j];

                    if (Matriz_R[i, j] < menor_r) menor_r = Matriz_R[i, j];
                    if (Matriz_G[i, j] < menor_g) menor_g = Matriz_G[i, j];
                    if (Matriz_B[i, j] < menor_b) menor_b = Matriz_B[i, j];
                }
            }
        }
        private void Soma_intermediaria()
        {
            Matriz_R = new double[image1.Width, image1.Height];
            Matriz_G = new double[image1.Width, image1.Height];
            Matriz_B = new double[image1.Width, image1.Height];
            Color Pixel1, Pixel2;
            for (int i = 0; i < image1.Width; i++)
            {
                for (int j = 0; j < image1.Height; j++)
                {
                    Pixel1 = image1.GetPixel(i, j);
                    Pixel2 = image2.GetPixel(i, j);
                    Matriz_R[i, j] = Pixel1.R + Pixel2.R;
                    Matriz_G[i, j] = Pixel1.G + Pixel2.G;
                    Matriz_B[i, j] = Pixel1.B + Pixel2.B;
                }
            }
        }
        public Bitmap Soma_Normalizada()
        {
            //(N(Tons-1)/F(Max) - F(Min)) * (F-F(Min))
            Bitmap image = new Bitmap(image1.Width, image1.Height);//imagem criada do tam que precisa
            Soma_intermediaria();//recebe a imagem intermediaria
            acha_maior_menor();//achou o maior e o menor RGB guardou na variavel
            int R = 0, G = 0, B = 0;
            double x = 0;
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    x = maior_r - menor_r;
                    x = 255 / x;
                    R = (int)(x * (Matriz_R[i, j] - menor_r));
                    x = maior_g - menor_g;
                    x = 255 / x;
                    G = (int)(x * (Matriz_G[i, j] - menor_g));
                    x = maior_b - menor_b;
                    x = 255 / x;
                    B = (int)(x * (Matriz_B[i, j] - menor_b));
                    image.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }
            return image;
        }
        public Bitmap Soma_Truncada()
        {
            int R, G, B;
            Bitmap image;
            Color Pixel1, Pixel2;
            image = new Bitmap(image1.Width, image1.Height);
            for (int i = 0; i < image1.Width; i++)
            {
                for (int j = 0; j < image1.Height; j++)
                {
                    Pixel1 = image1.GetPixel(i, j);
                    Pixel2 = image2.GetPixel(i, j);
                    R = Pixel1.R + Pixel2.R;
                    G = Pixel1.G + Pixel2.G;
                    B = Pixel1.B + Pixel2.B;

                    if (R > 255) R = 255;
                    if (G > 255) G = 255;
                    if (B > 255) B = 255;
                    image.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }
            return image;
        }

    }
}
