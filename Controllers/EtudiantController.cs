using Microsoft.AspNetCore.Mvc;
using EvaluationDeC_.Data;
using Microsoft.EntityFrameworkCore;

namespace EvaluationDeC_.Controllers
{
    public class EtudiantController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EtudiantController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Liste des cours d'un étudiant
        [HttpGet("Etudiant/Cours/{id}")]
        public async Task<IActionResult> Cours(int id)
        {
            var etudiant = await _context.Etudiants
                .Include(e => e.Cours)
                .FirstOrDefaultAsync(e => e.Id == id);

            if (etudiant == null)
            {
                return NotFound("Étudiant introuvable.");
            }

            return View(etudiant);
        }

        // Liste des absences d'un étudiant
        [HttpGet("Etudiant/Absences/{id}")]
        public async Task<IActionResult> Absences(int id)
        {
            var etudiant = await _context.Etudiants
                .Include(e => e.Absences)
                .ThenInclude(a => a.Cours)
                .FirstOrDefaultAsync(e => e.Id == id);

            if (etudiant == null)
            {
                return NotFound("Étudiant introuvable.");
            }

            return View(etudiant);
        }
    }
}