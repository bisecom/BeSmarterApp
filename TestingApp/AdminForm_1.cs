using OperatingRepo;
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
    public partial class AdminForm_1 : Form
    {
        public AdminForm_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminShowQuestionsForm showQuestions = new AdminShowQuestionsForm();
            showQuestions.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminAddQuestionForm newQuestion = new AdminAddQuestionForm();
            newQuestion.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminEditForm myediting = new AdminEditForm();
            myediting.Show();
        }
    }
}
