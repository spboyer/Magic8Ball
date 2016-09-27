using System;
using System.Linq;

namespace Magic8Ball
{
    public class Program
    {
        static Random _r = new Random();
        public static void Main(string[] question)
        {
            EightBallAnswers answers = new EightBallAnswers();
            int rInt = _r.Next(0, answers.Count() - 1);
            string response;
            if (question.Length == 0)
            {
                response = "You must ask a question to be provided an answer.";
            }
            else
            {
                response = string.Format("The answer to your question: '{0}' is {1} ({2})", question[0], answers[rInt], Environment.MachineName);
            }
            Console.WriteLine(response);
        }
    }
}
