namespace Events
{
    internal class Subscriber
    {
        private string name;

        public Subscriber(string name)
        {
            this.name = name;
        }

        public void OnMessageRecieved(object sender, MessageEvents e)
        {
            Console.WriteLine($"{name} got message: {e.Message}");
        }
    }
}
