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
    public partial class AdminEditForm : Form
    {
        public Operating operatingRepo { get; set; }
        public Question TransvQuestion { get; set; }
        public AdminEditForm()
        {
            InitializeComponent();
            operatingRepo = new Operating();
            PopulateDataGridView();
            TransvQuestion = new Question();
            
        }

        public void PopulateDataGridView()
        {
            BindingList<string[]> tempList = new BindingList<string[]>();
            dataGridViewAdminEditDelete.ColumnCount = 8;
            dataGridViewAdminEditDelete.Columns[0].Name = "Quesion Theme";
            dataGridViewAdminEditDelete.Columns[1].Name = "Quesion Description";
            dataGridViewAdminEditDelete.Columns[2].Name = "Answer # 1";
            dataGridViewAdminEditDelete.Columns[3].Name = "Answer # 2";
            dataGridViewAdminEditDelete.Columns[4].Name = "Answer # 3";
            dataGridViewAdminEditDelete.Columns[5].Name = "Answer # 4";
            dataGridViewAdminEditDelete.Columns[6].Name = "Answer # 5";
            dataGridViewAdminEditDelete.Columns[7].Name = "Correct Answer #";

            //Added
            dataGridViewAdminEditDelete.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewAdminEditDelete.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewAdminEditDelete.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            for (int i = 0; i < operatingRepo.questions.Count; i++)
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
                    dataGridViewAdminEditDelete.Rows.Add(str);
                }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridViewAdminEditDelete.SelectedRows[0];
            Question temp = new Question();
            temp.Subject = Convert.ToString(selectedRow.Cells[0].Value);
            temp.QuestionDescr = Convert.ToString(selectedRow.Cells[1].Value);
            temp.Answers.Add(Convert.ToString(selectedRow.Cells[2].Value));
            temp.Answers.Add(Convert.ToString(selectedRow.Cells[3].Value));
            temp.Answers.Add(Convert.ToString(selectedRow.Cells[4].Value));
            temp.Answers.Add(Convert.ToString(selectedRow.Cells[5].Value));
            temp.Answers.Add(Convert.ToString(selectedRow.Cells[6].Value));
            temp.CorrectAnswerNo = Convert.ToInt32(selectedRow.Cells[7].Value);

            AdminAddEditedQuestionForm tempQuestion = new AdminAddEditedQuestionForm(temp);
            tempQuestion.Text = "BeSmarter Question Editing..";
            
            if (tempQuestion.ShowDialog() == DialogResult.OK)
            {
                operatingRepo.EditingQuestion(tempQuestion.Myquestion, dataGridViewAdminEditDelete.CurrentRow.Index);
                dataGridViewAdminEditDelete.Rows.Clear();
                PopulateDataGridView();
               
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridViewAdminEditDelete.SelectedRows[0];
            DialogResult result = MessageBox.Show(
            $"Do you wish to delete question: \n{Convert.ToString(selectedRow.Cells[1].Value)}",
            "Question deleting..",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
            {
                operatingRepo.RemovingQuestion(dataGridViewAdminEditDelete.CurrentRow.Index);
                dataGridViewAdminEditDelete.Rows.Clear();
                PopulateDataGridView();
            }
            this.TopMost = true;
        }
    }
}
