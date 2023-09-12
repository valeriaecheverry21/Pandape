using MediatR;
using Microsoft.AspNetCore.Mvc;
using Pandape.Application.CQRS.Commands;
using Pandape.Application.CQRS.Queries;
using Pandape.Host.Mvc.ViewModels;
using Pandape.Domain.Entities;
using System.Threading.Tasks;

namespace Pandape.Host.Mvc.Controllers
{
    public class CandidatesController : Controller
    {
        protected IMediator Mediator { get; }

        public ICandidateViewModelFactory ViewModelFactory { get; set; }

        public CandidatesController(IMediator mediator, ICandidateViewModelFactory viewModelFactory)
        {
            Mediator = mediator;

            ViewModelFactory = viewModelFactory;
        }

        // GET: Candidates
        public async Task<IActionResult> Index()
        {
            var response = await Mediator.Send(new GetAllCandidatesQuery());

            return View(ViewModelFactory.GetAll(response));
        }

        // GET: Candidates/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var response = await Mediator.Send(new GetDetailsCandidateAndExperiencesQuery(id));

            return View(ViewModelFactory.Details(response));
        }

        // GET: Candidates/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Candidates/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,SurName,BirthDate,Email,InsertDate,ModifyDate")] Candidate candidate)
        {
            if (ModelState.IsValid)
            {
                var response = await Mediator.Send(new InsertCandidateCommand(candidate));

                return RedirectToAction(nameof(Index));
            }

            return View(candidate);
        }

        // GET: Candidates/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var response = await Mediator.Send(new GetByIdCandidateQuery(id));

            return View(ViewModelFactory.Edit(response));
        }


        // POST: Candidates/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,SurName,BirthDate,Email,InsertDate,ModifyDate")] Candidate candidate)
        {
            if (ModelState.IsValid)
            {
                var response = await Mediator.Send(new UpdateCandidateCommand(id, candidate));

                return RedirectToAction(nameof(Index));
            }

            return View(candidate);
        }

        // GET: Candidates/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var response = await Mediator.Send(new GetByIdCandidateQuery(id));

            return View(ViewModelFactory.Delete(response));
        }


        // POST: Candidates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var response = await Mediator.Send(new DeleteCandidateCommand(id));

            return RedirectToAction(nameof(Index));
        }
    }
}
