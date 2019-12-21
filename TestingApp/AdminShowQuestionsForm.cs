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
    public partial class AdminShowQuestionsForm : Form
    {
        Operating operatingRepo = new Operating();
               
        public AdminShowQuestionsForm()
        {
            InitializeComponent();
            PopulateDataGridView();
        }

        public void PopulateDataGridView()
        {
            AdminForm_1 admin = this.Owner as AdminForm_1;
            List<string[]> tempList = new List<string[]>();
            dataGridViewAdminShow.ColumnCount = 8;
            dataGridViewAdminShow.Columns[0].Name = "Quesion Theme";
            dataGridViewAdminShow.Columns[1].Name = "Quesion Description";
            dataGridViewAdminShow.Columns[2].Name = "Answer # 1";
            dataGridViewAdminShow.Columns[3].Name = "Answer # 2";
            dataGridViewAdminShow.Columns[4].Name = "Answer # 3";
            dataGridViewAdminShow.Columns[5].Name = "Answer # 4";
            dataGridViewAdminShow.Columns[6].Name = "Answer # 5";
            dataGridViewAdminShow.Columns[7].Name = "Correct Answer #";

            dataGridViewAdminShow.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewAdminShow.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewAdminShow.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            for (int i = 0; i< operatingRepo.questions.Count; i++)
            {
                string[] temp = new string[8];
                temp[0] = operatingRepo.questions[i].Subject;
                temp[1] = operatingRepo.questions[i].QuestionDescr;
                temp[2] = operatingRepo.questions[i].Answers[0];
                temp[3] = operatingRepo.questions[i].Answers[1];
                temp[4] = operatingRepo.questions[i].Answers[2];
                temp[5] = operatingRepo.questions[i].Answers[3];
                temp[6] = operatingRepo.questions[i].Answers[4];
                temp[7] = operatingRepo.questions[i].CorrectAnswerNo.ToString();
                tempList.Add(temp);

            }
            foreach (string[] str in tempList)
            {
                dataGridViewAdminShow.Rows.Add(str);
            }
        }


    }
}
