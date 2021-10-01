using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LetsTweet.Models
{
    public class Tweet
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Não pode publicar um texto vazio")]
        public string Text { get; set; }
    }
}
