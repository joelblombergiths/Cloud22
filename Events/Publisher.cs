namespace Events
{
    internal class Publisher
    {
        public event EventHandler<MessageEvents> MessageSent;

        public void SendMessage(string text)
        {
            MessageSent?.Invoke(this, new MessageEvents(text));
        }
    }
}
