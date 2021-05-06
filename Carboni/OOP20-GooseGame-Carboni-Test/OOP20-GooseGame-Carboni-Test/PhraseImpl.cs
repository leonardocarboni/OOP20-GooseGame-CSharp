using System.IO;

namespace OOP20_GooseGame_Carboni_Test
{
    internal class PhraseImpl : IPhrase
    {
        readonly private static string PHRASES_FILENAME = "..\\sentences.txt";
        private string phrase;

        public string GeneratePhrase()
        {
            var lines = File.ReadAllLines(PHRASES_FILENAME);
            var r = new System.Random();
            var randomLineNumber = r.Next(0, lines.Length - 1);
            var line = lines[randomLineNumber];
            phrase = line;
            return line;
        }

        public int CheckText(string textRead)
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

        public void SetPhrase(string sentence)
        {
            phrase = sentence;
        }
    }
}