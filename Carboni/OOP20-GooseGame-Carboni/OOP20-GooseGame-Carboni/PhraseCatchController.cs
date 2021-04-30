using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP20_GooseGame_Carboni
{
    class PhraseCatchController : MinigameController
    {
        
        private readonly IPhrase phrase;
        private readonly int errors;

        public PhraseCatchController()
        {
            PhraseCatchView view = new PhraseCatchView();

            phrase = new PhraseImpl();
            
            String sentence = phrase.GeneratePhrase();
            view.SetPhrase(sentence);

            var textRead = view.GetInputPhrase();
            errors = phrase.CheckText(textRead);;

        }

        public int getResult()
        {
            /*
             * the game the result is based on the remaining time
             * and the errors made 
             * due to the fact that the timer could not be implemented
             * it returns -errors made
             */
            return -errors;
        }
    }
}