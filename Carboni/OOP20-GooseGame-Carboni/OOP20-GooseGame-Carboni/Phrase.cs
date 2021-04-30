namespace OOP20_GooseGame_Carboni
{
    internal interface IPhrase
    {
        /**
         * Generates a random sentence.
         * @return a random sentence.
        */
        string GeneratePhrase();

        /**
         * Confronts the chosen sentence to the one written by the user.
         * @param textRead - the sentence written by the user.
         * @return the number of errors in the sentence written.
         */
        int CheckText(string textRead);

        /**
         * [Test] sets a sentence as the phrase.
         * @param sentence - tha phrase.
         */
        void SetPhrase(string sentence);
    }
}