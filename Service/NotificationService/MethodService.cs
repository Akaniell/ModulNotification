using DTO.NotificationDTO;
using Microsoft.AspNetCore.Mvc;
using Repository.NotificationRepository;

namespace Service.NotificationService;

public class MethodService(IMethodRepository methodRepository) : IMethodService
{
    private IMethodRepository _methodRepository = methodRepository;
    
    public async Task<MethodDTO> GetMethod(long id) 
    {
        return await _methodRepository.Get(id);
    }

    public async Task<List<MethodDTO>> GetMethods() 
    {
        return await _methodRepository.GetAll(); 
    }
    
    public async Task<IActionResult> InsertMethod(CreateMethodDTO dto)
    {
        return await _methodRepository.Insert(dto);
    }

    public async Task<IActionResult> UpdateMethod(UpdateMethodDTO dto)
    {
        return await _methodRepository.Update(dto);
    }

    public void DeleteMethod(long id)
    {
        _methodRepository.Delete(id);
    }
}