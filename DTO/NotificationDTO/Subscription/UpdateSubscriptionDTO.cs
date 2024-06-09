namespace DTO.NotificationDTO;

public class UpdateSubscriptionDTO
{
    public long Id { get; set; }
    public string UserName { get; set; }
    public string TypeName { get; set; }
    public byte Status { get; set; }
}