using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetsTweet.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        //vai fazer o migration criar a tabela Tweets com as colunas Id e Text vindas do Model Tweet
        public DbSet<Tweet> Tweets { get; set; }
    }
}
