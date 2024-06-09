using System.ComponentModel.DataAnnotations;

namespace DTO.CourseDTO;

public class CreateTheoryDTO
{
    [Required(ErrorMessage = "Поле 'Теория' обязательна для заполнения")]
    
    public string Theory_field { get; set; }
    
    public long Course_ID { get; set; }
}