using System.Linq;
using System.Web.Mvc;
using wr.LojaVirtual.Dominio.Repositorio;

namespace wr.LojaVirtual.Web.Controllers
{
    public class ProdutosController : Controller
    {

        private ProdutosRepositorio _repositorio;
        // GET: Produtos
        public ActionResult Index()
        {
            _repositorio = new ProdutosRepositorio();
           var produtos =  _repositorio.Produtos.Take(10);
            return View(produtos);
        }
    }
}