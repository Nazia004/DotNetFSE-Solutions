using System;

namespace SupportDesk
{
    public class Level1Support : SupportHandler
    {
        public override void HandleRequest(int level)
        {
            if (level == 1)
            {
                Console.WriteLine("Level 1 Support handled the request.");
            }
            else if (nextHandler != null)
            {
                nextHandler.HandleRequest(level);
            }
        }
    }
}