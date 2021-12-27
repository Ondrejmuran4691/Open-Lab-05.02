using System;

namespace Open_Lab_05._02
{
    public class StringTools
    {
        public string NoYelling(string sentence)
        {
            if(sentence.EndsWith("!!"))
            do
            {
                sentence = sentence.Remove(sentence.Length - 1);
            } while (sentence.EndsWith("!!"));
            else
            {
                if (sentence.EndsWith("??"))
                    do
                    {
                        sentence = sentence.Remove(sentence.Length - 1);
                    } while (sentence.EndsWith("??"));
                else
                {
                 
                }
            }
            return sentence;
        }
    }
}
