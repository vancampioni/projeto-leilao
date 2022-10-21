using Alura.LeilaoOnline.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Alura.LeilaoOnline.WebApp.Dados.EfCore
{
    public class LeilaoDAOComEfCore : ILeilaoDAO
    {
        AppDbContext _context;

        public LeilaoDAOComEfCore()
        {
            _context = new AppDbContext();
        }

        public IEnumerable<Categoria> BuscarCategorias() // Método que extrai repetição de código
        {
            return _context.Categorias.ToList();
        }

        public IEnumerable<Leilao> BuscarLeiloes() // Método que extrai repetição de código
        {
            return _context.Leiloes
                .Include(l => l.Categoria)
            .ToList();
        }

        public Leilao BuscarPorId(int id)
        {
            return _context.Leiloes.First(l => l.Id == id); // Outra opção => Find
        }

        public void Incluir(Leilao leilao)
        {
            _context.Leiloes.Add(leilao);
            _context.SaveChanges();
        }

        public void Alterar(Leilao leilao)
        {
            _context.Leiloes.Update(leilao);
            _context.SaveChanges();
        }

        public void Excluir(Leilao leilao)
        {
            _context.Leiloes.Remove(leilao);
            _context.SaveChanges();
        }
    }
}
