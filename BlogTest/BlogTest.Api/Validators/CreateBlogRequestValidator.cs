using BlogTest.Api.Models;
using BlogTest.Service.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogTest.Api.Validators
{
    public class CreateBlogRequestValidator : AbstractValidator<CreateBlogRequest>
    {
        public CreateBlogRequestValidator()
        {
            RuleFor(x => x.Title).NotEmpty();
            RuleFor(x => x.Title).MaximumLength(200);
            RuleFor(x => x.Description).MaximumLength(500);
            //RuleFor(x => x.WeightTotal).GreaterThan(0);
            //RuleFor(x => x.WeightTotal).GreaterThan(0);
            //RuleFor(x => x.WeightCar).GreaterThan(0);
        }
    }
}
