namespace DTO.CourseDTO;

public class UpdatePracticeDTO
{
    public long Id { get; set; }
    public string Practice_field { get; set; }
    
    public long Theory_id { get; set; }
    
    public long Type_of_practice_id { get; set; }
}