
namespace CostaLibrary.ValidationsTests
{
    using Entities;
    using Validations;
    using Xunit;

    public class CropEstimateValidatorTests
    {
        [Fact]
        public void Instantiate()
        {
            var cropEstimate = new CropEstimate();
            var cropEstimateValidator = new CropEstimateValidator(new DatabaseContext());

            cropEstimateValidator.Validate(cropEstimate);
        }
    }
}
