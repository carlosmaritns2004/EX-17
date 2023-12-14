using System.Reflection.Emit;

namespace EX_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Red;
            this.ForeColor = Color.Blue;
            this.Text = "Página Principal";
            label4.Text = Utilizador.Nome;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string Email = txtEmail.Text;   
            string password = txtPassword.Text;

            Utilizador.Nome = nome;
            Utilizador.Email = Email;
            Utilizador.Password= password;  

            Utilizador.Nome="Utilizador:"+txtNome.Text;
            label4.Text= Utilizador.Nome;   

            MessageBox.Show("Nome:",Utilizador.Nome);   

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 pagina2 = new Form2();
            pagina2.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;

            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
