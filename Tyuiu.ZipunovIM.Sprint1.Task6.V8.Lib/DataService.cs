using System;

namespace Tyuiu.ZipunovIM.Sprint1.Task6.V8.Lib
{
    public class DataService
    {
        public string MoveFirstLetterToEnd(string value)
        {
            string[] words = value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                if (word.Length > 1)
                {
                    words[i] = word.Substring(1) + word[0];
                }
            }

            return string.Join(" ", words);
        }
    }
}