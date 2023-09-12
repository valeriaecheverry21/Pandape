using Pandape.Application.CQRS.Commands;

namespace Pandape.Application.Validators
{
    public class UpdateRequestValidation : IRequestValidation<UpdateCandidateCommand>
    {
        public bool IRequestValid { get; set; }

        public UpdateRequestValidation(UpdateCandidateCommand command)
        {
            IRequestValid = ValidateRequest(command);
        }

        public bool ValidateRequest(UpdateCandidateCommand command)
        {
            IRequestValid = command.Id == command.Candidate.Id;

            IRequestValid = CandidateExists(command.Candidate.Id);

            return IRequestValid;
        }

        private bool CandidateExists(int id)
        {
            return false;
        }
    }
}
