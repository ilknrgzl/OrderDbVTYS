using Core.Entity;

namespace Entities
{
	public class Order : BaseEntity, IEntity
	{
		public int Id { get; set; }
		public int ProductId { get; set; }
		public int Quantity { get; set; }
		public DateTime OrderDate { get; set; }
	}
}
