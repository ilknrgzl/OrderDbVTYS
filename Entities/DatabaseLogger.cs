using Core.Entity;
using Microsoft.Extensions.Logging;

namespace Entities
{
	public class DatabaseLogger : ILogger, IEntity
	{
		public void Log(string message)
		{
			// Log to a database (implementation depends on context)
			Console.WriteLine("Database log: " + message);
		}
	}
}
