using System.ComponentModel;

namespace SistemaGestion
{
    public partial class Form1 : Form
    {
        List<Desarrollador> Desarrolladores = new List<Desarrollador>();
        public Form1()
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void botonEmpleado_Click(object sender, EventArgs e)
        {
            Desarrollador Felix = new Desarrollador();

            Felix.Nombre = cajaNombre.Text;
            Felix.Edad = Int16.Parse(cajaEdad.Text);
            Felix.Salario = Int32.Parse(cajaSalario.Text);
            Felix.EstablecerLenguaje(cajaLenguaje.Text);
            Felix.EstablecerA�osExperiencia(Int16.Parse(cajaA�os.Text));


            MessageBox.Show($"Nombre: {Felix.Nombre}\n" +
                $"Edad: {Felix.Edad}\n" +
                $"Salario: {Felix.Salario}\n" +
                $"Lenguaje de programaci�n: {Felix.RetornarLenguaje()}\n" +
                $"A�os de experiencia: {Felix.RetornarA�o()}");

            Desarrolladores.Add(Felix);
            var source = new BindingSource(Desarrolladores, null);
            gridEmpleados.DataSource = source;
            Limpiar();
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        public void Limpiar()
        {
            cajaA�os.Text = "";
            cajaEdad.Text = "";
            cajaNombre.Text = "";
            cajaSalario.Text = "";
            cajaLenguaje.Text = "";
        }
    }
}