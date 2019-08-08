using FluentValidation;
using FluentValidation.Results;
using System.ComponentModel.DataAnnotations.Schema;

namespace vxTel.Domain.Bases
{    
    public abstract class EntityBaseValidator
    {
        [NotMapped]
        public bool ModelIsValid { get; private set; }

        [NotMapped]
        public ValidationResult ErrorMessages { get; private set; }

        protected EntityBaseValidator() { }

        public bool Validate<TModel>(TModel model, AbstractValidator<TModel> validator)
        {            
            ErrorMessages = validator.Validate(model);
            ModelIsValid = ErrorMessages.IsValid;
            return ErrorMessages.IsValid;
        }
    }
}
