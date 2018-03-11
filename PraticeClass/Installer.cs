namespace PraticeClass
{
    public class Installer
    {
        private readonly Logger _logger;
        public Installer(Logger logger)
        {
            _logger = logger;
        }

        public void Log()
        {
            _logger.Log("Hey, here is installer.");
        }
    }
}
