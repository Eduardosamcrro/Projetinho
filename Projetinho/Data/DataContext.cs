

using Microsoft.EntityFrameworkCore;
using Projetinho.Models;

namespace Projetinho.Data
{
    //quando coloca os : na frente da classe esta se aplicando HERANÇA.
    public class DataContext : DbContext
    {
        //Toda vez que for fazer uma conection com banco de dados seguir esse padrao.
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }


        public DbSet<JogadorModel> Jogadores { get; set; }
    }
}
// data base ou no portuga banco de dados.