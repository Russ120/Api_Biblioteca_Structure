using DAL.Context;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    //aqui estan los metodos de la interfaz y se le va a poner funcion
    public class LibroRepository : ILibroRepository
    {
        //
        public readonly BibliotecaContext bibliotecaContext;


        //este constructor va a bregar una coneccion con la base de datos
        //se crea este constructor para la inyeccion de dependencia del context para usar acceder a sus metodos y propiedades(DbSet)
        public LibroRepository(BibliotecaContext bibliotecaContext)
        {
            this.bibliotecaContext = bibliotecaContext;
        }
        public LibroRepository()
        {
        }


        public List<Libro> GetAll()
        {
            //toList trae la lista de lo que tiene
            return this.bibliotecaContext.Libros.ToList();
        }

        public Libro GetID(int id)
        {
            // first por que tiene contron¿l de expciones si está null devuelve el tipo de error para saber que dio error
            return this.bibliotecaContext.Libros.First(l=>l.id == id);
        }

        public void Remove(int id)
        {
            var libro = this.bibliotecaContext.Libros.First(l => l.id == id);
            this.bibliotecaContext.Libros.Remove(libro);
            bibliotecaContext.SaveChanges();
        }

        public void Save(Libro libro)
        {
            this.bibliotecaContext.Libros.Add(libro);
            bibliotecaContext.SaveChanges();
        }

        public void Update(Libro libro)
        {
            this.bibliotecaContext.Libros.Update(libro);
            bibliotecaContext.SaveChanges();
        }
    }
}
