using System.Text.RegularExpressions;

namespace Act1.forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolTip1.SetToolTip(txt1,
            "La contraseña debe contener:\n" +
            "- Una letra mayúscula\n" +
            "- Una letra minúscula\n" +
            "- Un número\n" +
            "- Un símbolo");
        }

        private void validar_Click(object sender, EventArgs e)
        {
            string password = txt1.Text;
            string repetir = txt2.Text;

            // Expresión regular
            string patron = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).+$";

            if (Regex.IsMatch(password, patron))
            {
                if (password == repetir)
                {
                    MessageBox.Show("La contraseña ha sido validada");
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }
            }
            else
            {
                MessageBox.Show("La contraseña debe tener:\n- Una mayúscula\n- Una minúscula\n- Un número\n- Un símbolo");
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }
    }
}
