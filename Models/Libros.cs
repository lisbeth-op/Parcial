



using System.ComponentModel.DataAnnotations;

public class Libros
{
    [Key]
    
    [Required(ErrorMessage = "Campo obligatorio")]
         [MinLength(2, ErrorMessage = "El Id debe tener al menos {1} Caracter.")]
         [MaxLength(5, ErrorMessage = "El Id no debe pasar de {5} caracter")]
        public int LibrtoId { get; set; }
    
    [Required(ErrorMessage = "Campo obligatorio")]
         [MinLength(2, ErrorMessage = "El Titulo debe tener al menos {1} Caracter.")]
         [MaxLength(15, ErrorMessage = "El Titulo no debe pasar de {5} caracter")]

         public string?  Titulo { get; set; }
    

    [Required(ErrorMessage = "Campo obligatorio")]
         [MinLength(2, ErrorMessage = "El precio debe tener al menos {1} Caracter.")]
         [MaxLength(15, ErrorMessage = "El precio no debe pasar de {5} caracter")]

         public double  Precio { get; set; }

}