namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    // Allow only digits and control characters (like backspace)
        //    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        //    {
        //        try
        //        {
        //            MessageBox.Show("Apenas letras e números");
        //            e.Handled = true;
        //            textBox1.SelectAll();
        //        }
        //        catch
        //        {

        //        }
        //    }

        //}

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.LightBlue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ceteza que deseja fechar o programa?");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "User001" && textBox2.Text == "12345")
            {
                MessageBox.Show("Login bem sucedido!");
            }
            else
            {
                MessageBox.Show("Login falhou. Tente novamente.");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar)  )
            {
                try
                {
                    MessageBox.Show("Apenas letras e números");
                    e.Handled = true;
                    textBox1.SelectAll();
                }
                catch
                {

                }
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.LightBlue;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
        }
    }
}
