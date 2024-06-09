using System.ComponentModel.DataAnnotations;

namespace DTO.CommunicationDTO;

public class CreateAppealDTO
{
    public long User_id { get; set; }

    [Required(ErrorMessage = "Поле 'Пробдема' обязательно для заполнения")]
    public string Problem { get; set; }
}
