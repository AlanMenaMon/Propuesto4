namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_regitrar_Click(object sender, EventArgs e)
        {

            string nombre = txtNombre.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string correo = txtCorreo.Text.Trim();


            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(telefono) || string.IsNullOrEmpty(correo))
            {
                MessageBox.Show("Por favor, llena los tres campos (Nombre, Teléfono y Correo).", "Campos incompletos");
                return;
            }


            string registroEmpleado = $"{nombre} - Tel: {telefono} - Correo: {correo}";


            if (listBox_empleados.Items.Contains(registroEmpleado))
            {
                MessageBox.Show("Este empleado ya está adentro con los mismos datos.", "Registro Duplicado");
            }
            else
            {

                listBox_empleados.Items.Add(registroEmpleado);
                MessageBox.Show("Empleado registrado con éxito.", "Éxito");


                txtNombre.Clear();
                txtTelefono.Clear();
                txtCorreo.Clear();
                txtNombre.Focus();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
