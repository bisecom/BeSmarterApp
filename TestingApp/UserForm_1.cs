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
    public partial class UserForm_1 : Form
    {
        private Point m_Location = new Point(10, 10);
        public Operating operatingRepo { get; set; }
        public List<Question> questionsShow { get; set; }
        public UserForm_1()
        {
            InitializeComponent();
            operatingRepo = new Operating();
            for (int i = 0; i < operatingRepo.questions.Count; i++)
                operatingRepo.questions[i].AnsweredQuestionNo = -1;
            CreateDynamicButton(operatingRepo.questions);
        }

        private void CreateDynamicButton(List<Question> ques)
        {
            List<string> themes = new List<string>();
            var distinctThemes = ques.Select(x => x.Subject).Distinct();
            foreach (var item in distinctThemes)
                themes.Add(item.ToString());

            if (themes.Count < 6)//max themes quantity
            {
                for (int i = 0; i < themes.Count; i++)
                {
                    Button button = new Button();
                    this.Controls.Add(button);
                    button.Location = new Point(this.m_Location.X + 60, this.m_Location.Y + 210);
                    button.Size = new System.Drawing.Size(90, 30);
                    button.Name = themes[i];
                    button.Text = themes[i];
                    m_Location.X += button.Width + 16;
                    button.Visible = true;
                    button.UseVisualStyleBackColor = true;
                    button.Click += new System.EventHandler(myButtonHandler_Click);
                    button.BringToFront();
                }
            }

        }

        private void myButtonHandler_Click(object sender, EventArgs e)
        {
            List<string> themes = new List<string>();
            int themesQuesCounter = 0;
            var distinctThemes = operatingRepo.questions.Select(x => x.Subject).Distinct();
            foreach (var item in distinctThemes)
                themes.Add(item.ToString());

            Button btn = sender as Button;
           
            if (btn != null && btn.Name != "Check Statistic" && btn.Name != "Exit")
            {
                foreach(Question q in operatingRepo.questions)
                {
                    if (q.Subject == btn.Name) themesQuesCounter++;
                }
                if (themesQuesCounter < 3)
                {
                    MessageBox.Show("Sorry, not enough quantity of questions for the theme!" +
                        "\nAsk to add more questioins!");
                }
                else
                {
                    questionsShow = null; 
                    questionsShow = new List<Question>();
                    Random rnd = new Random();
                    int questionindex = 0;
                    while (questionsShow.Count < 3)
                    {
                        questionindex = rnd.Next(operatingRepo.questions.Count);
                        if (operatingRepo.questions[questionindex].Subject == btn.Name)
                        {
                            if (questionsShow.Count == 0)
                                questionsShow.Add(operatingRepo.questions[questionindex]);
                            else
                            {
                                bool available = false;
                                for (int i = 0; i < questionsShow.Count; i++)
                                {
                                    if (questionsShow[i].QuestionDescr.Contains(operatingRepo.questions[questionindex].QuestionDescr) == true)
                                        available = true;
                                }
                                 if (!available) questionsShow.Add(operatingRepo.questions[questionindex]);
                            }

                        }

                    }
                    UserTestForm mytest = new UserTestForm(questionsShow);
                    mytest.Owner = this;// ADDED
                    mytest.Show();
                }

            }
          
        }

        private void buttonStat_Click(object sender, EventArgs e)
        {
            if (questionsShow == null || questionsShow[0].AnsweredQuestionNo < 0)
                MessageBox.Show("Sorry, you have no statistic!\nTake a test first!");
            else
            {
                UserTestForm mytest = new UserTestForm(questionsShow, "Testing Results:");
                mytest.Show();
            }

        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
