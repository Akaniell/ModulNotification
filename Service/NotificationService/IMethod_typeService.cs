using DTO.NotificationDTO;

namespace Service.NotificationService;

public interface IMethod_typeService
{
    Task<Method_typeDTO> GetMethod_type(long id); 
    Task<List<Method_typeDTO>> GetMethod_types(); 
}