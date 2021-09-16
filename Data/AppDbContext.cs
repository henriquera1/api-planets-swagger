using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiPlanetas.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    
        public DbSet<Planet> Planets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Planet>()
                .Property(p => p.Age)
                    .HasPrecision(10, 2);
            
            modelBuilder.Entity<Planet>()
                .HasData(
                    new Planet { Id = 1, Name = "Terra", Title = "O Planeta Terra é um dos planetas que fazem parte do Sistema Solar e é o terceiro planeta mais próximo do Sol. A sua formação ocorreu há bilhões de anos, assim como a existência de vida aqui . Algumas teorias explicam sua origem, como a teoria da nebulosa solar.", Age = 4.5M , Extra = "Sistema Solar", Images = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/97/The_Earth_seen_from_Apollo_17.jpg/300px-The_Earth_seen_from_Apollo_17.jpg" },
                    new Planet { Id = 2, Name = "Marte", Title = "Marte é o quarto planeta mais próximo do Sol e o segundo menor planeta do sistema solar, depois de Mercúrio, sendo consideravelmente menor que o planeta Terra. Apresenta uma coloração avermelhada, pela presença de óxido de ferro na sua superfície.Por isso, recebeu o nome de Marte, em homenagem ao deus romano da guerra.", Age = 4.6M, Extra = "Sistema Solar", Images = "https://img.estadao.com.br/resources/jpg/4/4/1444871841744.jpg" }
                 ) ;
        }
    
    }
}
