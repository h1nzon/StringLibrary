using System.Collections.Generic;

namespace StringLibrary
{
    public class StringCheckClass
    {
        /// <summary>
        /// Возвращение букв в лист
        /// </summary>
        /// <param name="textString">
        /// В качестве параметра передается строка, которая может быть пустой или содержать некоторый текст. Текст может включать в себя произвольные символы.
        /// </param>
        /// <returns>
        /// Возвращается список символов List<char>. Список должен содержать буквы искомого текста и удовлетворять требованиям, указанным выше.
        /// </returns>
        public static List<char> GetLetters(string textString)
        {
            textString = textString.ToUpper();
            List<char> list = new List<char>();
            foreach (char c in textString)
            {
                if (!list.Contains(c) && char.IsLetter(c))
                {
                    list.Add(c);
                }
            }
            list.Sort();
            return list;
        }
    }
}
