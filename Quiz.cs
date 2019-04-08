﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Judah_s_Bible_Quiz
{
    class Quiz
    {
        public List<Question> questions;

        public Quiz(string questionFileName)
        {
            string questionDescription;
            string answerNumber;
            string answerDescription;
            List<string> choicesList = new List<string>();
            questions = new List<Question>();
            using(StreamReader reader = new StreamReader(questionFileName))
            {
                while (!reader.EndOfStream)
                {                    
                    questionDescription = reader.ReadLine();
                    answerNumber = reader.ReadLine();
                    answerDescription = reader.ReadLine();
                    choicesList = new List<string>();
                    for (int i = 0; i < 4; i++)
                        choicesList.Add(reader.ReadLine());
                    questions.Add(new Question(questionDescription, choicesList, answerNumber, answerDescription));                    
                }
            }
        }

    }
}