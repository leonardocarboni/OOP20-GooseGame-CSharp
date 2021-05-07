using System;
using System.Collections.Generic;

namespace OOP20_GooseGame_Domi
{
    public class MemoryController
    {
        private readonly MemoryView view;
        private readonly ISecretCode secretCode;
        private readonly List<int> inputCode;

        public MemoryController()
        {
        view = new MemoryView();
        secretCode = new SecretCodeImpl();
        secretCode.GenerateSecretCode();
        inputCode = new List<int>();
        }

        // public class CheckHandler : EventHandler
        // {
            
        // }

        // public class ButtonHandler : EventHandler
        // {

        // }
    }
    
}