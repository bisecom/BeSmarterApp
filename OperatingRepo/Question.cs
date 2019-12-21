using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperatingRepo
{
    [Serializable]
    public class Question
    {
        public string Subject { get; set; }
        public string QuestionDescr { get; set; }
        public List<string> Answers { get; set; }
        public int CorrectAnswerNo { get; set; }
        public int AnsweredQuestionNo { get; set; }

        public Question()
        {
            Answers = new List<string>(5);
            AnsweredQuestionNo = -1;
        }
        public Question(string Subject_, string QuestionDescr_, List<string> Answers_, int CorrectAnswerNo_)
        {
            Subject = Subject_;
            QuestionDescr = QuestionDescr_;
            Answers = new List<string>(5);
            Answers = Answers_;
            CorrectAnswerNo = CorrectAnswerNo_;
            AnsweredQuestionNo = -1;
        }

        public override string ToString()
        {

            return $"Subject = {Subject}, QuestionDescr = {QuestionDescr}," +
                    $"\nAnswers[0] = {Answers[0]},  \nAnswers[1] = {Answers[1]},\nAnswers[2] = {Answers[2]},\nAnswers[3] = {Answers[3]},\nAnswers[4] = {Answers[4]}," +
                    $"CorrectAnswerNo = {CorrectAnswerNo}";
        }
    }
}
