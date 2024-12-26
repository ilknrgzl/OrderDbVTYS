using Core.Entity;

namespace Entities
{
	public interface ILogger : IEntity
	{
		void Log(string message);
	}
}
