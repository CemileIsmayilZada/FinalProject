namespace Hotel.Business.DTOs.FlatDTOs
{
	public class CreateFlatDto:IDto
	{
		public string? Name { get; set; }
		public float Price { get; set; }
		public int Size { get; set; }
		public int BedCount { get; set; }
		public int DiscountPercent { get; set; }
		public string? Description { get; set; }
		public int RoomCatagoryId { get; set; }
	}
}
