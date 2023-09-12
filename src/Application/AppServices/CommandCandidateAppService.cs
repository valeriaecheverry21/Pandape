using AutoMapper;
using Pandape.Application.CQRS.Commands;
using Pandape.Application.CQRS.Responses;
using Pandape.Infrastructure.Persistence.Repositories;
using System.Threading.Tasks;

namespace Pandape.Application.AppServices
{
    public class CommandCandidateAppService : AppServiceBase, ICommandCandidateAppService
    {
        protected ICandidateCommandRepository CandidateCommandRepository { get; }

        public CommandCandidateAppService(ICandidateCommandRepository candidateCommandRepository, IMapper mapper) 
            : base(mapper)
        {
            CandidateCommandRepository = candidateCommandRepository;
        }

        public async Task<InsertCandidateResponse> Insert(InsertCandidateCommand command)
        {
            await CandidateCommandRepository.Insert(command.Candidate);

            var response = new InsertCandidateResponse { IsInserted = true};

            return response;
        }

        public async Task<UpdateCandidateResponse> Update(UpdateCandidateCommand command)
        {
            await CandidateCommandRepository.Update(command.Candidate);

            var response = new UpdateCandidateResponse { IsUpdated = true };

            return response;
        }

        public async Task<DeleteCandidateResponse> Delete(DeleteCandidateCommand command)
        {
            await CandidateCommandRepository.Delete(command.Id);

            var response = new DeleteCandidateResponse { IsDeleted = true };

            return response;
        }
    }
}
