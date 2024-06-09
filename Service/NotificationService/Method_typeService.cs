using DTO.NotificationDTO;
using Repository.NotificationRepository;

namespace Service.NotificationService;

public class Method_typeService(IMethod_typeRepository method_typeRepository) : IMethod_typeService
{
    private IMethod_typeRepository _method_typeRepository = method_typeRepository;
    
    public async Task<Method_typeDTO> GetMethod_type(long id) 
    {
        return await _method_typeRepository.Get(id);
    }

    public async Task<List<Method_typeDTO>> GetMethod_types() 
    {
        return await _method_typeRepository.GetAll(); 
    }
}