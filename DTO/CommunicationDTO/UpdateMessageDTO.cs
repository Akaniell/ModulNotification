namespace DTO.CommunicationDTO;

public class UpdateMessageDTO
{
    public long Id { get; set; }
    public string Mess_text { get; set; }
    public long Forum_id { get; set; }
    public long User_id { get; set; }
    public long Personal_id { get; set; }
    public long Appeal_id { get; set; }
}
