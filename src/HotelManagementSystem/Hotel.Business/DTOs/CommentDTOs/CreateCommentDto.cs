namespace Hotel.Business.DTOs.CommentDTOs
{
	public class CreateCommentDto:IDto
	{
		public string? Name { get; set; }
		public string? UserId { get; set; }
		public string? Opinions { get; set; }
		public int FlatId { get; set; }
	}
}
