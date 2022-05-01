using ManageUser;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();
            if(user.AuthenticateUser(textBox1.Text, textBox2.Text))
            {
                MessageBox.Show(user.HelloUser(textBox1.Text));
            }
            else
            {
                MessageBox.Show("Invalid username/password");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}