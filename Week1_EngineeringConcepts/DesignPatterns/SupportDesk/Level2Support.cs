using System;

namespace SupportDesk
{
    public class Level2Support : SupportHandler
    {
        public override void HandleRequest(int level)
        {
            if (level == 2)
            {
                Console.WriteLine("Level 2 Support handled the request.");
            }
            else if (nextHandler != null)
            {
                nextHandler.HandleRequest(level);
            }
        }
    }
}