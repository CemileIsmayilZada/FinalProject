namespace Hotel.Business.Mappers
{
	public class GallaryCatagoryMapper:Profile
	{
		public GallaryCatagoryMapper()
		{
			CreateMap<GallaryCatagoryDto,GallaryCatagory>().ReverseMap();
		}
	}
}
