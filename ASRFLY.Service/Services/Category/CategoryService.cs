using ASRFLY.Application.Interfaces;
using ASRFLY.Application.Services.Base;
using ASRFLY.Application.Services.Category.Inerfaces;

namespace ASRFLY.Application.Services.Category
{
    public class CategoryService : BaseService, ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
