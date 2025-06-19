using ASRFLY.Domain.Entities.BaseEntities;
using ASRFLY.Domain.Entities.CategoryEntity.Enums;

namespace ASRFLY.Domain.Entities.CategoryEntity
{
    public class Category : BaseEntity
    {
        public string Name { get; set; } = null!;
        public CategoryType Type { get; set; }
        public string? Details { get; set; }
        public double Balance { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
