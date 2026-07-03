namespace SupportDesk
{
    public abstract class SupportHandler
    {
        protected SupportHandler? nextHandler;

        public void SetNext(SupportHandler handler)
        {
            nextHandler = handler;
        }

        public abstract void HandleRequest(int level);
    }
}