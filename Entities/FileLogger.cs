using Core.Entity;

namespace Entities
{
	public class FileLogger : ILogger, IEntity
	{
		public void Log(string message)
		{
			// Log to a file
			File.AppendAllText("log.txt", message + Environment.NewLine);
		}
	}
}
