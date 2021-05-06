namespace OOP20_GooseGame_Carboni
{
    internal interface IPhrase
    {
        ///<summary>Generates a random sentence.</summary>
        ///<returns>a random sentence.</returns>
        string GeneratePhrase();

        ///<summary>Confronts the chosen sentence to the one written by the user.</summary>
        ///<param name="textRead">the sentence written by the user.</param>
        ///<returns>the number of errors in the sentence written.</returns>
        int CheckText(string textRead);

        ///<summary>[Test] sets a sentence as the phrase.</summary>
        ///<param name="sentence">the phrase.</param>
        void SetPhrase(string sentence);
    }
}