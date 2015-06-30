
namespace CostaLibrary.Validations
{
    using System.Collections.Generic;
    using Interfaces;

    public abstract class BaseValidator<T>
    {
        protected List<IValidationRule> Rules = new List<IValidationRule>();
        protected List<string> ErrorMessageList = new List<string>();
        private readonly IContext _context;

        public BaseValidator(IContext context)
        {
            _context = context;
        }

        public void Validate(T entity)
        {
            foreach (var validationRule in Rules)
            {
                if (!validationRule.IsValid(entity))
                {
                    ErrorMessageList.Add(validationRule.ErrorMessage);
                }
            }
        }
    }
}
