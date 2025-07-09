using ASRFLY.Domain.Entities.CategoryEntity.Enums;

namespace ASRFLY.Application.UseCases.Categories.DTOs
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public CategoryType Type { get; set; }
        public string? Details { get; set; }
        public double Balance { get; set; }
        public DateTime AddedDate { get; set; }
        
    }
}
