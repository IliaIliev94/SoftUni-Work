namespace P01._FileStream_Before
{
    public class Progress
    {
        private readonly IStream stream;

        public Progress(IStream stream)
        {
            this.stream = stream;
        }

        public int CurrentPercent()
        {
            return this.stream.Sent * 100 / this.stream.Length;
        }
    }
}
