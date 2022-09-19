namespace v38mon
{
    internal class StepCounter
    {
        public int Id { get; }

        private int counter = 0;

        public void Step() => counter++;
        public void Reset() => counter = 0;
        public int Current => counter;

        public StepCounter() : this(-1) { }
        public StepCounter(int id)
        {
            Id = id;
        }

        public static List<StepCounter> GetStepCounters(int count)
        {
            List<StepCounter> list = new();

            for (int i = 0; i < count; i++)
            {
                list.Add(new StepCounter(i));
            }

            return list;
        }
    }
}
