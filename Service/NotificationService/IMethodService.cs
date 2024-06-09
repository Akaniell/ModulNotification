using DTO.NotificationDTO;
using Microsoft.AspNetCore.Mvc;

namespace Service.NotificationService;

public interface IMethodService
{
    Task<MethodDTO> GetMethod(long id);
    Task<List<MethodDTO>> GetMethods();
    Task<IActionResult> InsertMethod(CreateMethodDTO dto);
    Task<IActionResult> UpdateMethod(UpdateMethodDTO dto);
    void DeleteMethod(long id);
}