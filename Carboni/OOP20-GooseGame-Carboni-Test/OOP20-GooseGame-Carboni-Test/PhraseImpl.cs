using System.IO;

namespace OOP20_GooseGame_Carboni_Test
{
    internal class PhraseImpl : Phrase
    {
        readonly private static string PHRASES_FILENAME = "..\\sentences.txt";
        private string phrase;

        public string generatePhrase()
        {
            var lines = File.ReadAllLines(PHRASES_FILENAME);
            var r = new System.Random();
            var randomLineNumber = r.Next(0, lines.Length - 1);
            var line = lines[randomLineNumber];
            phrase = line;
            return line;
        }

        public int checkText(string textRead)
        {
            int errors = System.Math.Abs(phrase.Length - textRead.Length);

            for (int i = 0; i < System.Math.Min(phrase.Length, textRead.Length); i++)
            {
                if (textRead.Substring(i, 1) != phrase.Substring(i, 1))
                {
                    errors++;
                }
            }
            return errors;
        }

        public void setPhrase(string sentence)
        {
            phrase = sentence;
        }
    }
}