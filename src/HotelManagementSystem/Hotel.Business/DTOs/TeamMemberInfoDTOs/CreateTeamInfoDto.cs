

namespace Hotel.Business.DTOs.TeamMemberInfoDTOs
{
	public class CreateTeamInfoDto:IDto
	{
		public int TeamMemberId { get; set; }
		public string? Phone { get; set; }
		public string? Facebook { get; set; }
		public string? Instagram { get; set; }
		public string? Twitter { get; set; }
		public string? Linkedin { get; set; }
	}
}
