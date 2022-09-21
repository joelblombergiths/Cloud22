namespace v38ons
{
    internal class WeightedColor
    {
        private float _red;
        private float _blue;

        public float Red
        {
            get { return _red; }
            set
            {
                _red = (float)Math.Clamp(value, 0.0, 100.0);
                _blue = 100.0f - _red;
            }
        }
        public float Blue
        {
            get { return _blue; }
            set
            {
                _blue = (float)Math.Clamp(value, 0.0, 100.0);
                _red = 100.0f - _blue;
            }
        }
    }
}
