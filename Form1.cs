namespace SistemaGestion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Desarrollador Felix = new Desarrollador()
            {
                Edad = 22,
                Nombre = "Felix",
                Salario = 10000
            };

            Felix.EstablecerLenguaje("C#");
            Felix.EstablecerAñosExperiencia(5);
            Felix.MostrarInformacion();


            cajaNombre.Text = Felix.Nombre;
            cajaEdad.Text = Convert.ToString(Felix.Edad);
            cajaSalario.Text = Convert.ToString(Felix.Salario);
            cajaLenguaje.Text = Felix.RetornarLenguaje();
            cajaAños.Text = Convert.ToString(Felix.RetornarAño());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}