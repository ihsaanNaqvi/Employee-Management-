namespace practiceapp
{
    using Microsoft.Extensions.Logging;

    public class MyService
    {
        private readonly ILogger<MyService> _logger;

        public MyService(ILogger<MyService> logger)
        {
            _logger = logger;
        }

        public void DoSomething()
        {
            // Log an informational event
            _logger.LogInformation("Something happened!");
        }
    }

}
