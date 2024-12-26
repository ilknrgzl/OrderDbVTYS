using Core.Entity;

namespace Entities
{
	public class Customer : BaseEntity, IEntity
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
	}
}
