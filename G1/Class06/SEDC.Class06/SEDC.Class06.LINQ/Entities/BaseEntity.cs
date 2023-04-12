namespace SEDC.Class06.LINQ.Entities
{
	public abstract class BaseEntity
	{
		public int Id { get; set; }
		public abstract string Info();
	}
}
