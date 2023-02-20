using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

public class LibrosBLL
{
    private Contexto _contexto;

    public LibrosBLL(Contexto contexto)
    {
        _contexto = contexto;
    }
    public Libros? Buscar(int LibroId)
    {
        return _contexto.Libros
          .AsNoTracking()
          .SingleOrDefault(l => l.LibroId == LibroId);
    }

    public bool Eliminar(Libros libro)
    {
        _contexto.Entry(libro).State = EntityState.Deleted;
        return _contexto.SaveChanges() > 0;
    }


    private bool Insertar(Libros libro)
    {
        _contexto.Libros.Add(libro);
        return _contexto.SaveChanges() > 0;
    }

    public bool Existe(int LibroId)
    {
        return _contexto.Libros
 .Any(l => l.LibroId == LibroId);
    }

    private bool Modificar(Libros libro)
    {
        _contexto.Entry(libro).State = EntityState.Modified;
        return _contexto.SaveChanges() > 0;
    }

    public bool Guardar(Libros libro)
    {
        if (!Existe(libro.LibroId))
            return this.Insertar(libro);
        else
            return this.Modificar(libro);
    }

public List<Libros> GetList(Expression<Func<Libros,bool>> criterio){

           return _contexto.Libros.AsNoTracking().Where(criterio).ToList();
    }


}
