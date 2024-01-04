

using DAL.Entities;

namespace DAL.Interfaces
{
    //esta interfaz se implementará en su respectiva clase repositorio
    public interface ILibroRepository
    {
        //estos son los metodos de la entidad para manipular los datos, estos metodos son especificamente para libros

        void Save(Libro libro);

        void Update (Libro libro);

        void Remove(int id);

        List<Libro> GetAll();

        Libro GetID(int id);
    }
}
