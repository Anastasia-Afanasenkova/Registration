using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Authorization
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        ProektDataDataContext BD = new ProektDataDataContext();

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == textBox4.Text)
            {
                User NewUser = new User
                {
                    Name = textBox1.Text,
                    Login = textBox2.Text,
                    Password = textBox3.Text,
                    IdRole = 2
                };
                BD.User.InsertOnSubmit(NewUser);
                try
                {
                    BD.SubmitChanges();
                    MessageBox.Show("Пользователь зарегистрирован");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Пароли не совпадают");
        }
    }
}
