namespace SingeltonPatternTest.Logger
{
    public class NativeCustomLogger
    {
        private long logIndex { get; set; }
        public NativeCustomLogger()
        {
            logIndex = -1;
        }

        public long AssignLogIndex()
        {
            logIndex++;
            return logIndex;
        }
    }
}
