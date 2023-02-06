﻿using FluentValidation;
using Hotel.Business.DTOs.WhyUsDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Business.Validations.WhyUsValidations
{
	public class CreateWhyUsValidator:AbstractValidator<CreateWhyUsDto>
	{
		public CreateWhyUsValidator()
		{
			RuleFor(x => x.Title)
				.NotEmpty()
				.NotNull()
				.MaximumLength(70);
			RuleFor(x => x.Description)
				.NotEmpty()
				.NotNull()
				.MaximumLength(250);
			RuleFor(x => x.Image)
				.NotEmpty()
				.NotNull();
		}
	}
}
