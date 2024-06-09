using System.ComponentModel.DataAnnotations;

namespace DTO.CommunicationDTO;

public class CreateMessageDTO
{
    [Required(ErrorMessage = "Поле 'Текст' обязательно для заполнения")]
    public string Mess_text { get; set; }

    public long Forum_id { get; set; }
    public long User_id { get; set; }
    public long Personal_id { get; set; }
    public long Appeal_id { get; set; }
}
