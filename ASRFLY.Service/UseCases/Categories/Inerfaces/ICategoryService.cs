using ASRFLY.Application.UseCases.Categories.DTOs;

namespace ASRFLY.Application.UseCases.Categories.Inerfaces
{
    public interface ICategoryService 
    {
        //Read
        Task<IEnumerable<CategoryDTO>> GetAllAsync();
    }
}
