using DTO.NotificationDTO;

namespace Repository.NotificationRepository;

public interface IMethod_typeRepository
{
    Task<Method_typeDTO> Get(long id);
    Task<List<Method_typeDTO>> GetAll();
}