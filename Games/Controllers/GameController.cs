using Games.Database;
using Games.Models;
using Microsoft.AspNetCore.Mvc;
using static Azure.Core.HttpHeader;

namespace Games.Controllers
{
    public class GameController : Controller
    {
        private GameStoreContext _context;
        private static IList<Game> _lista = new List<Game>();
        private static int _id = 0;

        public GameController(GameStoreContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index(String title)
        {
            var lista = _context.Games.ToList();

            if (string.IsNullOrEmpty(title))
            {
                return View(lista);
            } else
            {
                var list = new List<Game>();
                foreach (var item in lista)
                {
                    if(item.Title.Contains(title))
                    {
                        list.Add(item);
                    }
                }
                return View(list);
            }
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Game game)
        {
            _context.Games.Add(game);
            _context.SaveChanges();
            TempData["mensagem"] = "Jogo cadastrado com sucesso!";
            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var game = _context.Games.Find(id);
            return View(game);
        }

        [HttpPost]
        public IActionResult Editar(Game game)
        {
            _context.Games.Update(game);
            _context.SaveChanges();
            TempData["mensagem"] = "Jogo alterado com sucesso!";
            return RedirectToAction("Index");
        }

        [HttpPost, ActionName("Remover")]
        public IActionResult Remover(int id)
        {
            var game = _context.Games.Find(id);

            _context.Games.Remove(game);
            _context.SaveChanges();
            TempData["mensagem"] = "Jogo removido!";
            return RedirectToAction("Index");
        }
    }
}
