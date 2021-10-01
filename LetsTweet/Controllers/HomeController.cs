using LetsTweet.Models;
using LetsTweet.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LetsTweet.Controllers
{
    public class HomeController : Controller
    {
      
        private readonly AppDbContext _context;

        //passando o APPDbContext aqui por não ter criado um repositorio
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //pegar lista de Tweets pela ViewModel
            var viewModel = new IndexViewModel() 
            {
                Tweets = _context.Tweets
            };
          
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Index (IndexViewModel indexViewModel)
        {
            if (!string.IsNullOrWhiteSpace(indexViewModel.Search))
            {
                var tweets = _context.Tweets.Where(x => x.Text.Contains(indexViewModel.Search));
                indexViewModel.Tweets = tweets;
                return View(indexViewModel);
            }
            else
            { 
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult SaveTweet(Tweet tweet)
        {
            //salvar no BD
            // Retornar para a Index
            if (ModelState.IsValid)
            {
                _context.Tweets.Add(tweet);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        
    }
}
