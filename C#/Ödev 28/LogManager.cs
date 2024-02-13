public class LogManager:ILogger{
    public ILogger _logger;
    public LogManager(ILogger logger)
    {
        _logger =logger;
    }

    public void WriteLog()
    {
        //throw new NotImplementedException();
        _logger.WriteLog();
    }

    // ILogger a gelen nesnenin Log'unu döndürür.
}