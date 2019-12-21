using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminForm_1 form = new AdminForm_1();
            form.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserForm_1 user_form = new UserForm_1();
            user_form.Show();
        }
    }
}
