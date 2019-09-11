
using System.Text.RegularExpressions;

namespace PatternsOfDesign.Behavior_patterns.Command
{
    class Editor
    {
        public string Text { get; set; }

        public string GetSelection(string regexText)
        {
            if (Regex.IsMatch(Text, regexText))
            {
                return Regex.Match(Text, regexText).Result(regexText);
            }
            else
            {
                return "Empty Match on Regex";
            }
        }

        public void DeleteSelection(string regexText)
        {
            // Удалить выбранный текст.
        }

        public void ReplaceSelection(string text)
        {
            // Вставить текст из буфера обмена в текущей позиции
        }
    }
}
