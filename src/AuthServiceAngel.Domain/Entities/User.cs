using System.ComponentModel.DataAnnotations;

namespace AuthServiceAngel.Domain.Entities;
public class User
{
    [Key]
    [MaxLength(16)]
    public string Id { get; set; } = string.Empty;

    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [MaxLength(25, ErrorMessage = "El nombre no puede exceder los 25 caracteres.")]
    public string Name { get; set; } = string.Empty;
    

    [Required(ErrorMessage = "El apellido es obligatorio.")]
    [MaxLength(25, ErrorMessage = "El apellido no puede exceder los 25 caracteres.")]
    public string SurName { get; set; } = string.Empty;

    [Required(ErrorMessage = "El nombre de usuario es obligatorio.")]
    [MaxLength(25, ErrorMessage = "El nombre de usuario no puede exceder los 25 caracteres.")]
    public string UserName { get; set; } = string.Empty;

    [Required(ErrorMessage = "El correo electrónico es obligatorio.")]
    [EmailAddress(ErrorMessage = "El correo electrónico no es válido.")]
    [MaxLength(150, ErrorMessage = "El correo electrónico no puede exceder los 150 caracteres.")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "La contraseña es obligatoria.")]
    [MinLength(8, ErrorMessage = "La contraseña debe tener al menos 8 caracteres.")]
    [MaxLength(255, ErrorMessage = "La contraseña no puede exceder los 255 caracteres.")]

    public string Password { get; set; } = string.Empty;

    public bool Status { get; set; } = false;

    [Required]
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public UserProfile UserProfile { get; set;  } = null!;

    public ICollection<UserRole> UserRoles { get; set; } = [];

    public UserEmail UserEmail { get; set; } = null!;
    
    public UserPasswordReset UserPasswordReset { get; set; } = null!; 
}