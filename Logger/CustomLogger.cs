namespace SingeltonPatternTest.Logger
{
    public class CustomLogger : ICustomLogger
    {
        private static CustomLogger _customLoggerWorker = null;
        private long _logIndex { get; set; }
        private CustomLogger()
        {
            _logIndex = -1; // retain this from a presistent storage of your choice
        }
        public long AssignLogIndex()
        {
            _logIndex++;
            return _logIndex;
        }
        public static CustomLogger AccessCustomLogger()
        {
            if (_customLoggerWorker == null)
            {
                _customLoggerWorker = new CustomLogger();
            }
            return _customLoggerWorker;
        }


    }
}
