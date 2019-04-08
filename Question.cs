using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Judah_s_Bible_Quiz
{
    class Question
    {
        public string QuestionDescription { get; set; }
        public List<string> Choices { get; set; }
        public string Answer { get; set; }
        public string AnswerDescription { get; set; }

        public Question(string questionDescription_p, List<string> choices_p, string answer_p,string answerDescription_p)
        {
            QuestionDescription = questionDescription_p;
            AnswerDescription = answerDescription_p;
            Answer = answer_p;
            Choices = new List<string>();
            Choices = choices_p;
        }
    }
}
