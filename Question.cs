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
        private Random random = new Random();

        public Question(string questionDescription_p, List<string> choices_p, string answer_p,string answerDescription_p)
        {
            QuestionDescription = questionDescription_p;
            AnswerDescription = answerDescription_p;
            Answer = answer_p;
            Choices = new List<string>();
            Choices = choices_p;
        }

        public void RandomizeChoices()
        {
            List<string> newChoices = new List<string>();
            while(Choices.Count > 0)
            {
                int choiceToMove = random.Next(Choices.Count);
                newChoices.Add(Choices[choiceToMove]);
                Choices.RemoveAt(choiceToMove);
            }
            Choices = newChoices;
        }
    }
}
