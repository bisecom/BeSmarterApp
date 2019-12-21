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
    public partial class AdminAddQuestionForm : Form
    {
        public Question Myquestion { get; set;}
        public AdminAddQuestionForm()
        {
            InitializeComponent();
            Myquestion = new Question();
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
                    Operating operatingRepo = new Operating();
                    Question temp = new Question();
                    temp.Subject = textBoxSubject.Text;
                    temp.QuestionDescr = textBoxQuestionDesc.Text;
                    temp.Answers.Add(textBoxAnswer1.Text);
                    temp.Answers.Add(textBoxAnswer2.Text);
                    temp.Answers.Add(textBoxAnswer3.Text);
                    temp.Answers.Add(textBoxAnswer4.Text);
                    temp.Answers.Add(textBoxAnswer5.Text);
                    temp.CorrectAnswerNo = DetermineRadioButtonNumber();
                if (operatingRepo.questions.Select(x => x.Subject).Distinct().ToList().Count > 4 && CheckIfElementAvailable(operatingRepo.questions, textBoxSubject.Text))
                    { MessageBox.Show("Sorry, you have exceeded the themes number!\nContact your admin!"); }
                else
                {
                    operatingRepo.questions.Add(temp);
                    operatingRepo.SaveQuestions();
                    MessageBox.Show("Operation succeeded!!");
                    this.Close();
                }
            }

        }

        private bool CheckIfElementAvailable(List<Question> myList, string str)
        {
            var distinctThemes = myList.Select(x => x.Subject).Distinct().ToList();
            for (int i = 0; i < distinctThemes.Count; i++)
                    distinctThemes[i] = distinctThemes[i].ToUpper();
            str = str.ToUpper();
            if (!distinctThemes.Contains(str)) // true if its a new theme
                return true;
            else return false;
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

       
    }
}
