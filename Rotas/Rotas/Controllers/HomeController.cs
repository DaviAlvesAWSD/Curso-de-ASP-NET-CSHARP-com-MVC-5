using Rotas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rotas.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEnumerable<News> todasAsNoticias;

        public HomeController()
        {
            todasAsNoticias = new News().TodasAsNoticias().OrderByDescending(x => x.Data);
        }
       
        public ActionResult Index()
        {
            var ultimasNoticias = todasAsNoticias.Take(3);
            var todasAsCategorias = todasAsNoticias.Select(x => x.Categoria).Distinct().ToList();

            ViewBag.Categorias = todasAsCategorias;

            return View(ultimasNoticias);
        }

        public ActionResult TodasAsNoticias()
        {
            return View(todasAsNoticias);
        }

        public ActionResult MostraNoticia(string categoria, string titulo, int noticiaId)
        {
            return View(todasAsNoticias.FirstOrDefault(x => x.NoticiaId == noticiaId));
        }

        public ActionResult MostraCategoria(string categoria)
        {
            var categoriaEspecifica = todasAsNoticias.Where(x => x.Categoria.ToLower() == categoria.ToLower()).ToList();
            ViewBag.Categoria = categoria;
            return View(categoriaEspecifica);
        }
    }
}