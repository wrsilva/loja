using System.Collections.Generic;
using wr.LojaVirtual.Dominio.Entidade;

namespace wr.LojaVirtual.Dominio.Repositorio
{
   public class ProdutosRepositorio
   {
       private readonly EfDbContext _context = new EfDbContext();

       public IEnumerable<Produto> Produtos
       {
           get { return _context.Produtos; }

       }

      
   }
}
