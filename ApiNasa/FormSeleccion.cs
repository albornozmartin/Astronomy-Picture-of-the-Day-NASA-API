using System;
using System.Windows.Forms;

namespace ApiNasa
{
    public partial class FormSeleccion : Form
    {
        public FormSeleccion()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // posicion de inicio, medio de la pantalla
        }

        private void FormSeleccion_Load(object sender, EventArgs e)
        {
            FotoSingleton fotoSingleton1 = FotoSingleton.GetInstancia();
            dateTimePicker1.MaxDate = DateTime.Today;
            dateTimePicker1.CustomFormat = "ddd: /d /MM /yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            FotoDia fotoNueva = new FotoDia();
            fotoNueva = await fotoNueva.getFotoDiaAsync();
            FotoSingleton.GetInstancia().fotoSeleccionada=fotoNueva;
            FormImagen formIm = new FormImagen();
            formIm.Show();
            this.Hide();
        }

        private void FormSeleccion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private async void buttonGo_Click(object sender, EventArgs e)
        {
            string fecha = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            FotoDia fotoNueva = new FotoDia();
            fotoNueva = await fotoNueva.getDiaEspecificoAsync(fecha);
            FotoSingleton.GetInstancia().fotoSeleccionada = fotoNueva;
            FormImagen formIm = new FormImagen();
            formIm.Show();
            this.Hide();
        }
    }
}
