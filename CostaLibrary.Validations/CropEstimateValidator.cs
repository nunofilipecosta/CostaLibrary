namespace CostaLibrary.Validations
{
    using Entities;
    using Interfaces;

    public class CropEstimateValidator : BaseValidator<CropEstimate>
    {

        public CropEstimateValidator(IContext context) : base(context)
        {
            base.Rules.Add(new ShouldbeActiveValidationRule(context));
        }
    }
}