﻿using System.Collections.Generic;

namespace Magic8Ball
{
    public class EightBallAnswers : Dictionary<int, string>
    {

        private void AddValue(string value)
        {
            Add(Count, value);
        }
        public EightBallAnswers()
        {
            AddValue("It is certain");
            AddValue("It is decidedly so");
            AddValue("Without a doubt");
            AddValue("Yes, definitely");
            AddValue("You may rely on it");
            AddValue("As I see it, yes");
            AddValue("Most likely");
            AddValue("Outlook good");
            AddValue("Yes");
            AddValue("Signs point to yes");
            AddValue("Reply hazy try again");
            AddValue("Ask again later");
            AddValue("Better not tell you now");
            AddValue("Cannot predict now");
            AddValue("Concentrate and ask again");
            AddValue("Don't count on it");
            AddValue("My reply is no");
            AddValue("My sources say no");
            AddValue("Outlook not so good");
            AddValue("Very doubtful");
        }
    }
}
