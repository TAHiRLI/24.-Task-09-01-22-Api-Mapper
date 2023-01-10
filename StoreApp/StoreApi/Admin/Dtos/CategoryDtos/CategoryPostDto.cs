﻿using FluentValidation;

namespace StoreApi.Admin.Dtos.CategoryDtos
{
    public class CategoryPostDto
    {
        public string Name { get; set; }
    }
    public class CategoryPostDtoValidator : AbstractValidator<CategoryPostDto>
    {
        public CategoryPostDtoValidator()
        {
            RuleFor(x => x.Name).MaximumLength(25).NotEmpty().NotNull();
        }
    }

}
