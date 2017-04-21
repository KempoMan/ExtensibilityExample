using System;

namespace Extensibility
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {            
            _logger.LogInfo("Migration Started: " + DateTime.Now);

            // Details of migrating the database
            _logger.LogError("testing error.");

            _logger.LogInfo("Migration Ended: " + DateTime.Now);
        }
    }
}