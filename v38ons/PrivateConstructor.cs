namespace v38ons
{
    internal class PrivateConstructor
    {
        private static int _counter = 0;
        public static PrivateConstructor Create()
        {
            return new PrivateConstructor(++_counter);
        }
        public int Id { get; }
        private PrivateConstructor(int id)
        {
            Id = id;
        }
    }
}
