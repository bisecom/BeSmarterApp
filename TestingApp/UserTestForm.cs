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
    public partial class UserTestForm : Form
    {
        private Point m_Location = new Point(10, 10);
        private int height;
        private string buttonBackTag;
        private string buttonNextTag;
        public List<Question> questShow { get; set; }
        public UserTestForm(List<Question> _ques)
        {
            InitializeComponent();
            questShow = null;
            questShow = new List<Question>();
            questShow.AddRange(_ques);
            CreateDynamicAnswers(_ques[0]);
            this.buttonBack.Enabled = false;
            this.buttonComplete.Enabled = false;
        }
        public UserTestForm(List<Question> _ques, string mystr)//Additional Constructor for Statistic
        {
            InitializeComponent();
            questShow = null;
            questShow = new List<Question>();
            questShow.AddRange(_ques);
            ShowStatistic(questShow[0], mystr);
            this.buttonBack.Enabled = false;
        }

        private void CreateDynamicAnswers(Question ques)
        {
            labelSubjectShow.Text = ques.Subject;
            labelSubjectShow.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));

            labelQuestDescr.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            labelQuestDescr.Text = ques.QuestionDescr;
            labelQuestDescr.MaximumSize = new Size(500, 0);
            labelQuestDescr.AutoSize = true;
            height = labelSubjectShow.Height + labelQuestDescr.Height + labelSubjectText.Height + label3.Height;
            this.buttonBack.Tag = "1";
            buttonBackTag = "1";
            this.buttonNext.Tag = "2";
            buttonNextTag = "2";
            for (int i = 0; i < ques.Answers.Count; i++)
                {
                if (ques.Answers[i] != "")
                {
                    Label mylabel = new Label();
                    this.Controls.Add(mylabel);
                    mylabel.Location = new Point(this.m_Location.X + 30, this.m_Location.Y + height + 150); //230
                    mylabel.Width = 150;
                    mylabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
                    mylabel.Text = $"Answer No{Convert.ToString(i + 1)}:";
                    mylabel.BringToFront();

                    Label mylabelShow = new Label();
                    this.Controls.Add(mylabelShow);
                    mylabelShow.Location = new Point(this.m_Location.X + 32, this.m_Location.Y + height + 170);  //250
                    mylabel.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
                    mylabelShow.Text = ques.Answers[i];
                    mylabelShow.BringToFront();

                    RadioButton myradio = new RadioButton();
                    this.Controls.Add(myradio);
                    myradio.Location = new Point(this.m_Location.X + 560, this.m_Location.Y + height + 165);  //245
                    myradio.BringToFront();

                    if(ques.AnsweredQuestionNo != -1 && i == ques.AnsweredQuestionNo)
                       myradio.Checked = true;
                    else myradio.Checked = false;

                    myradio.Tag = i.ToString();
                    m_Location.Y += mylabel.Height + mylabelShow.Height;
                }
                }
          }

        private void ShowStatistic(Question ques, string str)
        {
            Label labelStatFormName = new Label();
            this.Controls.Add(labelStatFormName);
            labelStatFormName.Location = new Point(38, 85);
            labelStatFormName.AutoSize = true;
            labelStatFormName.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, ((byte)(204)));
            labelStatFormName.Text = str;
            labelStatFormName.BringToFront();

            labelSubjectShow.Text = ques.Subject;
            labelSubjectShow.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));

            labelQuestDescr.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            labelQuestDescr.Text = ques.QuestionDescr;
            labelQuestDescr.MaximumSize = new Size(500, 0);
            labelQuestDescr.AutoSize = true;
            height = labelSubjectShow.Height + labelQuestDescr.Height + labelSubjectText.Height + label3.Height + labelStatFormName.Height;
 
            this.buttonBack.Tag = "Back";
            this.buttonNext.Tag = "Next";
            this.buttonComplete.Text = "Exit";
            buttonBackTag = "Back";
            buttonNextTag = "Next";

            for (int i = 0; i < ques.Answers.Count; i++)
            {
                if (ques.Answers[i] != "")
                {
                    Label mylabel = new Label();
                    this.Controls.Add(mylabel);
                    mylabel.Location = new Point(this.m_Location.X + 30, this.m_Location.Y + height + 130);
                    mylabel.Width = 150;
                    mylabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
                    mylabel.Text = "Possible Answer No " + Convert.ToString(i + 1) + ":";
                    mylabel.BringToFront();

                    Label mylabelShow = new Label();
                    this.Controls.Add(mylabelShow);
                    mylabelShow.Location = new Point(this.m_Location.X + 32, this.m_Location.Y + height + 150);
                    mylabel.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
                    mylabelShow.Text = ques.Answers[i];
                    mylabelShow.BringToFront();
                    if(i == ques.CorrectAnswerNo - 1)
                    {
                        PictureBox picture = new PictureBox();
                    if (ques.AnsweredQuestionNo == ques.CorrectAnswerNo - 1)
                        picture.Image = Properties.Resources.Ok_icon;
                    else picture.Image = Properties.Resources.Close_2_icon;
                    
                    picture.Size = new Size(32, 32);
                    picture.Location = new Point(this.m_Location.X + 560, this.m_Location.Y + height + 140);
                    this.Controls.Add(picture);
                    picture.BringToFront();
                    }
                    m_Location.Y += mylabel.Height + mylabelShow.Height;
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            int index = questShow.FindIndex(a => a.QuestionDescr == labelQuestDescr.Text);
            index--;
            if (index < 1)
            {
                Controls.Clear();
                InitializeComponent();
                m_Location = new Point(10, 10);
                if (buttonBackTag == "1")
                {
                    CreateDynamicAnswers(questShow[index]);
                    buttonComplete.Enabled = false;
                }
                else ShowStatistic(questShow[index], "Testing Results");
                buttonBack.Enabled = false;
                Show();
            }
            if (index > 0) //>=
            {
                questShow[index+1].AnsweredQuestionNo = DetermineRadioButtonNumber();
                Controls.Clear();
                InitializeComponent();
                m_Location = new Point(10, 10);
                if (buttonBackTag == "1")
                {
                    CreateDynamicAnswers(questShow[index]);
                    buttonComplete.Enabled = false;
                }
                else ShowStatistic(questShow[index], "Testing Results");
                Show();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            int index = questShow.FindIndex(a => a.QuestionDescr == labelQuestDescr.Text);
            index++;
            if (index < questShow.Count)
            {
                questShow[index - 1].AnsweredQuestionNo = DetermineRadioButtonNumber();
                Controls.Clear();
                InitializeComponent();
                m_Location = new Point(10, 10);
                if (buttonNextTag == "2")
                {
                    CreateDynamicAnswers(questShow[index]);
                    buttonComplete.Enabled = false;
                }
                else ShowStatistic(questShow[index], "Testing Results");

                if (index == questShow.Count - 1)
                { 
                buttonNext.Enabled = false;
                buttonComplete.Enabled = true;
                }
                else
                buttonNext.Enabled = true;
                Show();
            }
        }

        private int DetermineRadioButtonNumber()
        {
            foreach (var control in this.Controls)
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
            return -1;
        }


        private void buttonComplete_Click(object sender, EventArgs e)
        {
            int result = 0;
            int index = questShow.FindIndex(a => a.QuestionDescr == labelQuestDescr.Text);
            if (index < questShow.Count)
               questShow[index].AnsweredQuestionNo = DetermineRadioButtonNumber();

            if (buttonComplete.Text == "Exit")
                this.Close();
            else
            {
                foreach (var item in questShow)
                {
                    if ((item.CorrectAnswerNo - 1) == item.AnsweredQuestionNo)
                        result += 12 / questShow.Count;

                }
                labelBall.Text = result.ToString();
                labelResult.Text = "Your Result:";
                UserForm_1 main = this.Owner as UserForm_1;
                main.questionsShow.Clear();
                main.questionsShow.AddRange(questShow);
                main.operatingRepo = null;
                main.operatingRepo = new Operating();
                MessageBox.Show("Thank you!\nYour test is complete!");
                this.Close();
            }
       
        }

    }
}
