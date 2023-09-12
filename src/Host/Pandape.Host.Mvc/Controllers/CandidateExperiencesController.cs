using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pandape.Domain.Entities;
using Pandape.Infrastructure.Persistence.DataBase;
using System.Linq;
using System.Threading.Tasks;

namespace Pandape.Host.Mvc.Controllers
{
    public class CandidateExperiencesController : Controller
    {
        private readonly PandapeContext _context;

        public CandidateExperiencesController(PandapeContext context)
        {
            _context = context;
        }

        // GET: CandidateExperiences
        public async Task<IActionResult> Index()
        {
            var candidateExperiences = await _context
                .CandidateExperiences
                .Include(c => c.Candidate)
                .ToListAsync();

            return View(candidateExperiences);
        }

        // GET: CandidateExperiences/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var candidateExperience = await _context
                .CandidateExperiences
                .Include(c => c.Candidate)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (candidateExperience == null)
                return NotFound();

            return View(candidateExperience);
        }

        // GET: CandidateExperiences/Create
        public async Task<IActionResult> Create(int? id)
        {
            if (id == null)
                return View();

            var candidate = await _context.Candidates.FirstOrDefaultAsync(m => m.Id == id);

            return View(candidate);
        }

        // POST: CandidateExperiences/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
            int id,
            [Bind("Id,CandidateId,Company,Job,Description,Salary,BeginDate,EndDate,InsertDate,ModifyDate")] CandidateExperience candidateExperience)
        {
            if (ModelState.IsValid)
            {
                _context.Add(candidateExperience);

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(candidateExperience);
        }

        // GET: CandidateExperiences/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var candidateExperience = await _context
                .CandidateExperiences
                .Include(c => c.Candidate)
                .FirstAsync(c => c.Id == id);
            
            if (candidateExperience == null)
                return NotFound();

            return View(candidateExperience);
        }

        // POST: CandidateExperiences/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(
            int id, 
            [Bind("Id,CandidateId,Company,Job,Description,Salary,BeginDate,EndDate,InsertDate,ModifyDate")] CandidateExperience candidateExperience)
        {
            if (id != candidateExperience.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(candidateExperience);

                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CandidateExperienceExists(candidateExperience.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction(nameof(Index));
            }

            return View(candidateExperience);
        }

        // GET: CandidateExperiences/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var candidateExperience = await _context
                .CandidateExperiences
                .Include(c => c.Candidate)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (candidateExperience == null)
                return NotFound();

            return View(candidateExperience);
        }

        // POST: CandidateExperiences/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var candidateExperience = await _context
                .CandidateExperiences
                .FindAsync(id);

            _context.CandidateExperiences.Remove(candidateExperience);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        private bool CandidateExperienceExists(int id)
        {
            return _context.CandidateExperiences.Any(e => e.Id == id);
        }
    }
}
