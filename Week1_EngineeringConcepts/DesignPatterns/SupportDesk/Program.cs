namespace SupportDesk
{
    class Program
    {
        static void Main(string[] args)
        {
            SupportHandler level1 = new Level1Support();
            SupportHandler level2 = new Level2Support();
            SupportHandler level3 = new Level3Support();

            level1.SetNext(level2);
            level2.SetNext(level3);

            level1.HandleRequest(1);
            level1.HandleRequest(2);
            level1.HandleRequest(3);
            level1.HandleRequest(4);
        }
    }
}
