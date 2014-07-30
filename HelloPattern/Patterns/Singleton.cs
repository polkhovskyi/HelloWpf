namespace HelloPattern.Patterns
{
    public class Singleton<T> where T : class
    {
        private Singleton() { }

        public T Value { get; set; }

        public static Singleton<T> Instance
        {
            get { return Nested.Instance; }
        }

        private class Nested
        {
            internal static readonly Singleton<T> Instance = new Singleton<T>();

            static Nested()
            {
            }
        }
    }
}