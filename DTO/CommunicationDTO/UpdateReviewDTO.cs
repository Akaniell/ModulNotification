namespace DTO.CommunicationDTO;

public class UpdateReviewDTO
{
    public long Id { get; set; }
    public long User_id { get; set; }
    public long Course_id { get; set; }
    public long Star { get; set; }
    public string Review_text { get; set; }
}