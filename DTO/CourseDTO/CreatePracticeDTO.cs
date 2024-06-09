using System.ComponentModel.DataAnnotations;

namespace DTO.CourseDTO;

public class CreatePracticeDTO
{
    [Required(ErrorMessage = "Поле 'Практика' обязательна для заполнения")]
    public string Practice_field { get; set; }
    
    public long Theory_id { get; set; }
    
    public long Type_of_practice_id { get; set; }
}