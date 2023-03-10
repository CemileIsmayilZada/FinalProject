namespace Hotel.Business.Validations.SelectedListValidations
{
	public class SelectedListValidator:AbstractValidator<SelectedListDto>
	{
		public SelectedListValidator()
		{
			RuleFor(u => u.Id).NotNull().NotEmpty();
			RuleFor(u => u.Price).NotNull().NotEmpty();
			RuleFor(u => u.CatagoryName).NotNull().NotEmpty();
			RuleFor(u => u.FlatId).NotNull().NotEmpty();
			RuleFor(u => u.CatagoryId).NotNull().NotEmpty();
		}
	}
}
