using Alura.LeilaoOnline.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Alura.LeilaoOnline.WebApp.Dados
{
    // Abstração para desacoplar o código
    public interface ILeilaoDAO
    {
        public IEnumerable<Categoria> BuscarCategorias();

        public IEnumerable<Leilao> BuscarLeiloes();

        public Leilao BuscarPorId(int id);

        public void Incluir(Leilao leilao);

        public void Alterar(Leilao leilao);

        public void Excluir(Leilao leilao);
    }
}
