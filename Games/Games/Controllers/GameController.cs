using Games.Models;
using Microsoft.AspNetCore.Mvc;

namespace Games.Controllers
{
    public class GameController : Controller
    {
        private static IList<Game> _lista = new List<Game>();
        private static int _id = 0;
        public IActionResult Index()
        {
            return View(_lista);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Game game)
        {
            game.Id = ++_id;
            _lista.Add(game);
            TempData["mensagem"] = "Jogo cadastrado com sucesso!";
            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var game = _lista.First(v => v.Id == id);
            return View(game);
        }

        [HttpPost]
        public IActionResult Editar(Game game)
        {
            var index = _lista.ToList().FindIndex(v => v.Id == game.Id);
            _lista[index] = game;
            TempData["mensagem"] = "Jogo atualizado com sucesso!";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Remover(int id)
        {
            _lista.Remove(_lista.First(v => v.Id == id));
            TempData["mensagem"] = "Jogo removido!";
            return RedirectToAction("Index");
        }
    }
}
