namespace CostaLibrary.Validations
{
    public interface IValidationRule<in T> where T : class
    {
        bool IsValid(T entity);

        string ErrorMessage { get; set; }
    }
}