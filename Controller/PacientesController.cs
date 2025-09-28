using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClinicaApp.Data;
using ClinicaApp.Models;
// Thays Lacerda Corrêa
namespace ClinicaApp.Controllers
{
    [Authorize]
    public class PacientesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public PacientesController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // ================================================================
        // LISTAR PACIENTES
        // ================================================================
        public async Task<IActionResult> Index()
        {
            IQueryable<Paciente> query = _context.Pacientes.Include(p => p.Profissional);

            if (User.IsInRole("Medico") || User.IsInRole("Nutricionista"))
            {
                // Profissional só vê seus pacientes
                var userId = _userManager.GetUserId(User);
                var profissional = await _context.Profissionais.FirstOrDefaultAsync(p => p.IdUser == userId);
                if (profissional != null)
                {
                    query = query.Where(p => p.IdProfissional == profissional.IdProfissional);
                }
                else
                {
                    query = Enumerable.Empty<Paciente>().AsQueryable();
                }
            }
            // Gerentes veem todos
            return View(await query.ToListAsync());
        }

        // ================================================================
        // DETALHES DO PACIENTE
        // ================================================================
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var paciente = await _context.Pacientes
                .Include(p => p.Profissional)
                .FirstOrDefaultAsync(m => m.IdPaciente == id);

            if (paciente == null) return NotFound();

            // Profissional só pode ver paciente dele
            if ((User.IsInRole("Medico") || User.IsInRole("Nutricionista")) &&
                paciente.Profissional.IdUser != _userManager.GetUserId(User))
            {
                return Forbid();
            }

            return View(paciente);
        }

        // ================================================================
        // CRIAR PACIENTE (apenas profissionais podem criar)
        // ================================================================
        [Authorize(Roles = "Medico,Nutricionista")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Medico,Nutricionista")]
        public async Task<IActionResult> Create([Bind("Nome,Email,Telefone")] Paciente paciente)
        {
            if (ModelState.IsValid)
            {
                var userId = _userManager.GetUserId(User);
                var profissional = await _context.Profissionais.FirstOrDefaultAsync(p => p.IdUser == userId);

                if (profissional == null) return Unauthorized();

                paciente.IdProfissional = profissional.IdProfissional;

                _context.Add(paciente);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(paciente);
        }

        // ================================================================
        // EDITAR PACIENTE
        // ================================================================
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var paciente = await _context.Pacientes.FindAsync(id);
            if (paciente == null) return NotFound();

            // Profissional só edita paciente dele
            if ((User.IsInRole("Medico") || User.IsInRole("Nutricionista")) &&
                paciente.Profissional?.IdUser != _userManager.GetUserId(User))
            {
                return Forbid();
            }

            return View(paciente);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdPaciente,Nome,Email,Telefone")] Paciente paciente)
        {
            if (id != paciente.IdPaciente) return NotFound();

            var original = await _context.Pacientes.AsNoTracking().FirstOrDefaultAsync(p => p.IdPaciente == id);
            if (original == null) return NotFound();

            // Profissional só pode editar paciente dele
            var profissional = await _context.Profissionais.FirstOrDefaultAsync(p => p.IdProfissional == original.IdProfissional);
            if ((User.IsInRole("Medico") || User.IsInRole("Nutricionista")) &&
                profissional.IdUser != _userManager.GetUserId(User))
            {
                return Forbid();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    paciente.IdProfissional = original.IdProfissional; // Mantém vínculo original
                    _context.Update(paciente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Pacientes.Any(e => e.IdPaciente == paciente.IdPaciente))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(paciente);
        }

        // ================================================================
        // EXCLUIR PACIENTE
        // ================================================================
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var paciente = await _context.Pacientes
                .Include(p => p.Profissional)
                .FirstOrDefaultAsync(m => m.IdPaciente == id);

            if (paciente == null) return NotFound();

            // Profissional só pode excluir paciente dele
            if ((User.IsInRole("Medico") || User.IsInRole("Nutricionista")) &&
                paciente.Profissional.IdUser != _userManager.GetUserId(User))
            {
                return Forbid();
            }

            return View(paciente);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var paciente = await _context.Pacientes
                .Include(p => p.Profissional)
                .FirstOrDefaultAsync(p => p.IdPaciente == id);

            if (paciente == null) return NotFound();

            // Profissional só pode excluir paciente dele
            if ((User.IsInRole("Medico") || User.IsInRole("Nutricionista")) &&
                paciente.Profissional.IdUser != _userManager.GetUserId(User))
            {
                return Forbid();
            }

            _context.Pacientes.Remove(paciente);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}