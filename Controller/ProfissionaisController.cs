using ClinicaApp.Data; // Contexto do EF Core
using ClinicaApp.Models; // Modelo Profissional
using ClinicaApp.ViewModels; // ViewModels
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaApp.Controllers
{
    // Somente usuários com a Role "Admin" podem gerenciar profissionais
    [Authorize(Roles = "Admin")]
    public class ProfissionaisController : Controller
    {
        private readonly ApplicationDbContext _context;

        // Injeção do DbContext no Controller
        public ProfissionaisController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Profissionais
        // Lista todos os profissionais
        public async Task<IActionResult> Index()
        {
            var profissionais = await _context.Profissionais.ToListAsync();
            return View(profissionais);
        }

        // GET: Profissionais/Details/5
        // Mostra detalhes de um profissional
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var profissional = await _context.Profissionais
                .FirstOrDefaultAsync(m => m.IdProfissional == id);

            if (profissional == null)
                return NotFound();

            return View(profissional);
        }

        // GET: Profissionais/Create
        // Exibe formulário para criar um novo profissional
        public IActionResult Create()
        {
            return View();
        }

        // POST: Profissionais/Create
        // Recebe dados do formulário para criar profissional
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProfissionalViewModel model)
        {
            if (ModelState.IsValid)
            {
                var profissional = new Profissional
                {
                    Nome = model.Nome,
                    CPF = model.CPF,
                    Especialidade = model.Especialidade,
                };

                _context.Add(profissional);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }

        // GET: Profissionais/Edit/5
        // Exibe formulário para editar profissional
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var profissional = await _context.Profissionais.FindAsync(id);
            if (profissional == null)
                return NotFound();

            var model = new ProfissionalViewModel
            {
                Id = profissional.IdProfissional,
                Nome = profissional.Nome,
                CPF = profissional.CPF,
                Especialidade = profissional.Especialidade,
            };

            return View(model);
        }

        // POST: Profissionais/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ProfissionalViewModel model)
        {
            if (id != model.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                var profissional = await _context.Profissionais.FindAsync(id);
                if (profissional == null)
                    return NotFound();

                // Atualiza os campos editáveis
                profissional.Nome = model.Nome;
                profissional.Especialidade = model.Especialidade;

                try
                {
                    _context.Update(profissional);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProfissionalExists(model.Id))
                        return NotFound();
                    else
                        throw;
                }

                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }

        // GET: Profissionais/Delete/5
        // Exibe confirmação de exclusão
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var profissional = await _context.Profissionais
                .FirstOrDefaultAsync(m => m.IdProfissional == id);

            if (profissional == null)
                return NotFound();

            return View(profissional);
        }

        // POST: Profissionais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var profissional = await _context.Profissionais.FindAsync(id);
            _context.Profissionais.Remove(profissional);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // Verifica se profissional existe
        private bool ProfissionalExists(int id)
        {
            return _context.Profissionais.Any(e => e.IdProfissional == id);
        }
    }
}
