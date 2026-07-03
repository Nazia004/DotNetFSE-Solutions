using System;

namespace SupportDesk
{
    public class Level3Support : SupportHandler
    {
        public override void HandleRequest(int level)
        {
            if (level == 3)
            {
                Console.WriteLine("Level 3 Support handled the request.");
            }
            else
            {
                Console.WriteLine("No support level available for this request.");
            }
        }
    }
}