using MediatR;
using Pandape.Application.CQRS.Responses;
using Pandape.Domain.Entities;
using System;
using System.Linq.Expressions;

namespace Pandape.Application.CQRS.Queries
{
    public class FindCandidateQuery : IRequest<FindCandidateResponse>
    {
        public Expression<Func<Candidate, bool>> Expression { get; set; }
    }
}
