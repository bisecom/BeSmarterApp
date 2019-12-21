using OperatingRepo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Question> questions = new List<Question>
            //{
            //  new Question {Subject = "Math", QuestionDescr = "Чему эквивалентна функция y = arctg(x-2) при x -> 2 ?",
            //  Answers = new List<string> { "х+2", "х", "х-2", "1/(х-2)"} , CorrectAnswerNo = 3},
            //  new Question {Subject = "Math", QuestionDescr = "Чему эквивалентна функция y = a ^(x-2) - 1 при x - > 2 ?",
            //  Answers = new List<string> { "xlna", "(x-2)lna", "xlna-2" } , CorrectAnswerNo = 2},
            //  new Question {Subject = "Math", QuestionDescr = "Сколько будет 2 + 2 * 3 = ?",
            //  Answers = new List<string> { "7", "15", "1", "8", "20" } , CorrectAnswerNo = 4},
            //  new Question {Subject = "Physics", QuestionDescr = "Каким выражением определяется импульс фотона с энергией E?",
            //  Answers = new List<string> { "c / E", "hv / E", "E / hc", "E / c" } , CorrectAnswerNo = 4}

            //};

            XmlSerializer myserialize = new XmlSerializer(typeof(List<Question>));
            //using (FileStream fs = new FileStream("questions.xml", FileMode.OpenOrCreate))
            //{
            //    myserialize.Serialize(fs, questions);
            //}

            using (FileStream fs = new FileStream("questions.xml", FileMode.Open))
            {
                List<Question> incomeQuestions = (List<Question>)myserialize.Deserialize(fs);
                foreach(Question q in incomeQuestions)
                {
                    Console.WriteLine($"{ q.Subject} { q.QuestionDescr} {q.Answers[0]} {q.Answers[1]}  {q.Answers[2]} {q.CorrectAnswerNo}");
                }
            }


                Console.ReadKey();

        }
    }
}
