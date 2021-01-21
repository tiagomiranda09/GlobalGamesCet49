using GlobalGamesCet49.Dados;
using GlobalGamesCet49.Dados.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalGamesCet49.Controllers
{
    public class InscricoesController : Controller
    {
        private readonly DataContext _context;

        public InscricoesController(DataContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Inscricoes.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inscricoes = await _context.Inscricoes
                .FirstOrDefaultAsync(i => i.Id == id);
            if (inscricoes == null)
            {
                return NotFound();
            }

            return View(inscricoes);
        }

        public IActionResult Create()
        {
            return View();
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Apelido,DataNascimento,Morada")] Inscricoes inscricoes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(inscricoes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(inscricoes);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inscricoes = await _context.Inscricoes.FindAsync(id);
            if (inscricoes == null)
            {
                return NotFound();
            }
            return View(inscricoes);
        }

      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Apelido,DataNascimento,Morada")] Inscricoes inscricoes)
        {
            if (id != inscricoes.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inscricoes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InscricoesExists(inscricoes.Id))
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
            return View(inscricoes);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inscricoes = await _context.Inscricoes.FirstOrDefaultAsync(m => m.Id == id);
            if (inscricoes == null)
            {
                return NotFound();
            }

            return View(inscricoes);
        }

        private bool InscricoesExists(int id)
        {
            return _context.Inscricoes.Any(e => e.Id == id);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var inscricoes = await _context.Inscricoes.FindAsync(id);
            _context.Inscricoes.Remove(inscricoes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

       
    }
}
