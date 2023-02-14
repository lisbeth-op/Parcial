using Microsoft.EntityFrameworkCore;

public class LibrosBLL
{
    private Contexto contexto;

    public LibrosBLL(Contexto contexto)
    {

    }
    public Libros? Buscar(int LibroId)
    {
        return contexto.Libros
          .AsNoTracking()
          .SingleOrDefault(l => l.LibroId == LibroId);
    }

    public bool Eliminar(Libros libro)
    {
        contexto.Entry(libro).State = EntityState.Deleted;
        return contexto.SaveChanges() > 0;
    }


    private bool Insertar(Libros libro)
    {
        contexto.Libros.Add(libro);
        return contexto.SaveChanges() > 0;
    }

    public bool Existe(int LibroId)
    {
        return contexto.Libros.Any(l => l.LibroId == LibroId);
    }

    private bool Modificar(Libros libro)
    {
        contexto.Entry(libro).State = EntityState.Modified;
        return contexto.SaveChanges() > 0;
    }

    public bool Guardar(Libros libro)
    {
        if (!Existe(libro.LibroId))
            return this.Insertar(libro);
        else return this.Modificar(libro);
    }
    
    
    
    }
