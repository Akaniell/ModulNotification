using System.ComponentModel.DataAnnotations;

namespace DTO.CommunicationDTO;

public class CreatePersonalDTO
{
    public long User_id { get; set; }
    public bool Read_status { get; set; }
}
