namespace Hotel.Business.Mappers
{
	public class FaqMapper:Profile
	{
		public FaqMapper()
		{
			CreateMap<FAQ,FaqDto>().ReverseMap();
		}
	}
}
