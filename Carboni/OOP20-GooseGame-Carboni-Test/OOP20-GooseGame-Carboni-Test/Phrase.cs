namespace OOP20_GooseGame_Carboni_Test
{
    internal interface Phrase
    {
        /**
         * Generates a random sentence.
         * @return a random sentence.
        */
        string generatePhrase();

        /**
         * Confronts the chosen sentence to the one written by the user.
         * @param textRead - the sentence written by the user.
         * @return the number of errors in the sentence written.
         */
        int checkText(string textRead);

        /**
         * [Test] sets a sentence as the phrase.
         * @param sentence - tha phrase.
         */
        void setPhrase(string sentence);
    }
}