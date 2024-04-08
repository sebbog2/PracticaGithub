namespace Practica5Entornos
{
    public partial class Form1 : Form
    {
        private GroupBox groupBox1;

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isChecked = checkBox1.Checked;

            // Obtiene el texto ingresado en el TextBox
            string texto = textBox1.Text;

            try
            {
                // Intenta acceder al panel1 dentro de groupBox1
                if (groupBox1.Controls["panel1"] is Panel panel && panel.Controls["textBox2"] is TextBox textBox2)
                {
                    // Intenta convertir el texto de textBox2 en un número
                    if (double.TryParse(textBox2.Text, out double costo))
                    {
                        // Realiza el cálculo si el valor ingresado es un número válido
                        double resultado = isChecked ? costo * 1.1 : costo;
                        MessageBox.Show($"El resultado es: {resultado}");
                    }
                    else
                    {
                        MessageBox.Show("Por favor ingrese un costo válido.");
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo acceder al control textBox2 dentro de groupBox1.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error: {ex.Message}");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}