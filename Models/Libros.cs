

using System.ComponentModel.DataAnnotations;

public class Libros
{
    [Key]
    public int LibroId { get; set; }
    
        
    public string? Titulo { get; set; }
    public double precio { get; set; }
}