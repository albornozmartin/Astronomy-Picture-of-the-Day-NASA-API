using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ApiNasa
{
    public partial class FormImagen : Form
    {


        public FormImagen()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormImagen_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormSeleccion form = new FormSeleccion();
            form.Show();
        }

    

        private  void FormImagen_Load(object sender, EventArgs e)
        {

            this.Text = FotoSingleton.GetInstancia().fotoSeleccionada.title;
            pictureBox1.LoadAsync(FotoSingleton.GetInstancia().fotoSeleccionada.url);
            textBoxExplanation.Text = FotoSingleton.GetInstancia().fotoSeleccionada.explanation;
            textBoxExplanation.ScrollBars = ScrollBars.Vertical;
            labelTitle.Text = FotoSingleton.GetInstancia().fotoSeleccionada.title;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("explorer", FotoSingleton.GetInstancia().fotoSeleccionada.hdurl);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog saveFileDialog = new SaveFileDialog() {Filter = @"PNG|*.png",FileName=FotoSingleton.GetInstancia().fotoSeleccionada.title};
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog.FileName);
            }
            
        }
    }
}
