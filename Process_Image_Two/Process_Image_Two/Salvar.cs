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
    public partial class Salvar : Form
    {
        public Salvar(Bitmap image)
        {
            imagem = image;
            InitializeComponent();
        }
        Bitmap imagem;
        private void Salvar_Load(object sender, EventArgs e)
        {
            picSave.Image = imagem;
        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            if(saveFile.ShowDialog()==DialogResult.OK)
            {
                picSave.Image.Save(saveFile.FileName);
            }
        }
    }
}
