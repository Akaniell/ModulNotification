using System.ComponentModel.DataAnnotations;

namespace DTO.UserDTO;

public class CreateUserDTO
{
    //public long UserId { get; set; }
    public string First_name { get; set;  }
    public string Last_name { get; set; }
    public string Login { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Password { get; set; }
    /*public string created_at { get; set; }*/ 
    /*[Required(ErrorMessage = $"Поле 'Имя' обязательно для заполнения")]
    public string first_name { get; set;  }
    [Required(ErrorMessage = $"Поле 'Фамилия' обязательно для заполнения")]
    public string last_name { get; set; }
    [Required(ErrorMessage = $"Поле 'Логин' обязательно для заполнения")]
    public string login { get; set; }
    [Required(ErrorMessage = $"Поле 'Пароль' обязательно для заполнения")]
    public string password { get; set; }
    [Required(ErrorMessage = $"Поле 'E-mail' обязательно для заполнения")]
    /*[RegularExpression("^\\W+@\\W+\\.\\W{2,3}$", ErrorMessage = "Неверно введен E-mail")]#1#
    public string email { get; set; }
    //created_at время создания же человек не вводит так что хз что с ним делать*/
}