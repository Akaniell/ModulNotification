using System.ComponentModel.DataAnnotations;

namespace DTO.AuthDTO;

public class AuthSignInDTO
{
    [Required]
    public string UserName { get; set; }
    [Required]
    public string Password { get; set; }
}