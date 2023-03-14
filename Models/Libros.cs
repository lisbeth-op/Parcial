
using System.ComponentModel.DataAnnotations;

public class Libros
{
    [Key]
    public int LibroId { get; set; }

    [Required(ErrorMessage = "Campo obligatorio")]
    [MinLength(2, ErrorMessage = "El titulo debe tener al menos {1} Caracter.")]
    [MaxLength(15, ErrorMessage = "El titulo no debe pasar de {2} caracter")]
    public string? Titulo { get; set; }
    [Required(ErrorMessage = "Campo obligatorio")]
    public DateTime Fecha { get; set; }

    public double Precio { get; set; }
}