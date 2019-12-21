using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OperatingRepo
{
    [Serializable]
    public class Operating
    {
       public XmlSerializer myserialize;
       public List<Question> questions { get; set; }

        public Operating()
        {
            myserialize = new XmlSerializer(typeof(List<Question>));
            questions = new List<Question>();
            questions.AddRange(GetQuestions());
            //questions = new List<Question>
            //{
            //  new Question {Subject = "Math", QuestionDescr = "Чему эквивалентна функция y = arctg(x-2) при x -> 2 ?",
            //  Answers = new List<string> { "х+2", "х", "х-2", "1/(х-2)", ""} , CorrectAnswerNo = 3},
            //  new Question {Subject = "Math", QuestionDescr = "Чему эквивалентна функция y = a ^(x-2) - 1 при x - > 2 ?",
            //  Answers = new List<string> { "xlna", "(x-2)lna", "xlna-2", "", "" } , CorrectAnswerNo = 2},
            //  new Question {Subject = "Math", QuestionDescr = "Сколько будет 2 + 2 * 3 = ?",
            //  Answers = new List<string> { "7", "15", "1", "8", "20" } , CorrectAnswerNo = 4},
            //  new Question {Subject = "Physics", QuestionDescr = "Каким выражением определяется импульс фотона с энергией E?",
            //  Answers = new List<string> { "c / E", "hv / E", "E / hc", "E / c", "" } , CorrectAnswerNo = 4}

            //};
            //GetQuestions();
        }


        public void SaveQuestions()
        {
            using (Stream fs = File.Create("questions.xml"))
            {
               myserialize.Serialize(fs, questions);
            }

        }

        public List<Question> GetQuestions()
        {
            List<Question> incomeQuestions = new List<Question>();
            using (FileStream fs = new FileStream("questions.xml", FileMode.OpenOrCreate))
            {
                incomeQuestions = (List<Question>)myserialize.Deserialize(fs);
            }
            return incomeQuestions;
        }

        public void EditingQuestion(Question q, int questionNumber)
        {
            questions.RemoveAt(questionNumber);
            questions.Add(q);
            SaveQuestions();
           
        }

        public void RemovingQuestion(int questionIndex)
        {
            questions.RemoveAt(questionIndex);
            SaveQuestions();
        }

    }
}
