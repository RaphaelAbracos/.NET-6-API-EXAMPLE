using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModels;

public class RegisterViewModel
{
    [Required(ErrorMessage = "O nome é obrigatório")]
    public string Name { get; set; }
    
    [Required(ErrorMessage = "o Email é obrigatório")]
    [EmailAddress(ErrorMessage = "O Email é invalido")]
    public  string Email { get; set; }
}