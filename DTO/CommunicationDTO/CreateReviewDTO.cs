using System.ComponentModel.DataAnnotations;

namespace DTO.CommunicationDTO;

public class CreateReviewDTO
{
    [Required(ErrorMessage = $"Поле 'Оцените курс' бязательно для заполнения")]
    public long Star { get; set; }

    public long User_id { get; set; }
    public long Course_id { get; set; }
    public string Review_text { get; set; }
}