namespace Pandape.Application.Validators
{
    public interface IRequestValidation<TRequest> where TRequest : class
    {
        public bool IRequestValid { get; set; }

        bool ValidateRequest(TRequest request);
    }
}
