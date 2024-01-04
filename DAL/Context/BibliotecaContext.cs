using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Context
{
    public class BibliotecaContext : DbContext
    {

        //esta es la conecion para el mapeo, configuracion de coneccion por inyeccion de dependencia
        //es el metodo constructor que le manda la configuracion de la bd al dbcontext
        public BibliotecaContext(DbContextOptions<BibliotecaContext> options) : base(options)
        {

        }

        //este es el dbset que en los parentesis angulares recibe la entidad o el modelo y asi busca eso en la bd y hace
        //un mapeo y se lo pasa a la tabla libros esta propiedad.
        //el dbset recibe libro para saber cual es su estructura, asi tiene las propiedades de la entidad libro y asi libros tiene todo lo que tiene la entidad libro
        public DbSet<Libro> Libros { get; set; }
    }
}
