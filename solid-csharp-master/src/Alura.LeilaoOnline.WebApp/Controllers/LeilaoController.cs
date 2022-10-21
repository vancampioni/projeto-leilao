using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Alura.LeilaoOnline.WebApp.Dados;
using Alura.LeilaoOnline.WebApp.Models;
using System;
using System.Collections.Generic;

namespace Alura.LeilaoOnline.WebApp.Controllers
{
    public class LeilaoController : Controller
    {

        AppDbContext _context;
        LeilaoDao _dao;

        public LeilaoController()
        {
            _context = new AppDbContext();
            _dao = new LeilaoDao();
        }

        
    }
}
