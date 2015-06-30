namespace CostaLibrary.Validations
{
    using Entities;
    using Interfaces;

    public class ShouldbeActiveValidationRule : IValidationRule<CropEstimate>
    {
        private IContext _context;

        public ShouldbeActiveValidationRule(IContext context)
        {
            _context = context;
        }

        public bool IsValid(CropEstimate entity)
        {
            if (entity.IsValid)
            {
                return true;
            }

            return false;

        }

        public string ErrorMessage
        {
            get { throw new System.NotImplementedException(); }
            set { throw new System.NotImplementedException(); }
        }
    }
}