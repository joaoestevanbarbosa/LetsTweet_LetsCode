using LetsTweet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetsTweet.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<Tweet> Tweets { get; set; } //fazer a lista dos tweets publicados

        public Tweet Tweet { get; set; } // vincular ao formulário

        public string Search { get; set; } // busca simples na Index
    } 
}
