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
    public partial class AdminAddEditedQuestionForm : Form
    {
        public Question Myquestion { get; set;}
        public AdminAddEditedQuestionForm()
        {
            InitializeComponent();
            Myquestion = new Question();
        }

        public AdminAddEditedQuestionForm(Question q)
        {
            InitializeComponent();
            Myquestion = new Question();
            textBoxSubject.Text  = q.Subject;
            textBoxQuestionDesc.Text = q.QuestionDescr;
            textBoxAnswer1.Text = q.Answers[0];
            textBoxAnswer2.Text = q.Answers[1];
            textBoxAnswer3.Text = q.Answers[2];
            textBoxAnswer4.Text = q.Answers[3];
            textBoxAnswer5.Text = q.Answers[4];
            switch (q.CorrectAnswerNo)
            {
                case 1: { this.radioButton1.Checked = true; break; }
                case 2: { this.radioButton2.Checked = true; break; }
                case 3: { this.radioButton3.Checked = true; break; }
                case 4: { this.radioButton4.Checked = true; break; }
                case 5: { this.radioButton5.Checked = true; break; }
               default: { this.radioButton1.Checked = true; break; }
            }
            Myquestion = q;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxSubject.Text == "" || textBoxQuestionDesc.Text == "" || textBoxAnswer1.Text == "" ||
                radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && 
                radioButton4.Checked == false && radioButton5.Checked == false)
            {
                MessageBox.Show("Please, enter the question correctly!");
            }
            else
            {
                this.TopMost = true;
                MessageBox.Show("Operation succeeded!!");
                this.Close();
            }

        }

        private int DetermineRadioButtonNumber()
        {
            foreach (var control in groupBoxCorrAnswers.Controls)
            {
                if (control is RadioButton)
                {
                    var radioButton = control as RadioButton;
                    if (radioButton.Checked)
                    {
                        return Convert.ToInt32(radioButton.Tag);
                    }
                }
            }
            return 0;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxesTextChanged(object sender, EventArgs e)
        {
            Myquestion = null;
            Myquestion = new Question();
            Myquestion.Subject = textBoxSubject.Text;
            Myquestion.QuestionDescr = textBoxQuestionDesc.Text;
            Myquestion.Answers.Add(textBoxAnswer1.Text);
            Myquestion.Answers.Add(textBoxAnswer2.Text);
            Myquestion.Answers.Add(textBoxAnswer3.Text);
            Myquestion.Answers.Add(textBoxAnswer4.Text);
            Myquestion.Answers.Add(textBoxAnswer5.Text);
            Myquestion.CorrectAnswerNo = DetermineRadioButtonNumber();

        }
    }
}
