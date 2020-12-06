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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProektDataDataContext BD = new ProektDataDataContext();

        private void button1_Click(object sender, EventArgs e)
        {
            IQueryable<int> user = BD.User.Where(u => u.Login == textBox1.Text && u.Password == textBox2.Text).Select(u => u.IdRole);
            if (user.Count() > 0)
            {
                MessageBox.Show("Данный пользователь найден");
            }
            else
                MessageBox.Show("Данный пользователь не найден");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 reg = new Form2();
            reg.ShowDialog();
        }
    }
}
