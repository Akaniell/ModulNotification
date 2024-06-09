using System.ComponentModel.DataAnnotations;

namespace DTO.CommunicationDTO;

public class CreateForumDTO
{
    [Required(ErrorMessage = "Поле 'Название форума' обязательно для заполнения")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Поле 'Описание форума' обязательно для заполнения")]
    public string Description { get; set; }
}
