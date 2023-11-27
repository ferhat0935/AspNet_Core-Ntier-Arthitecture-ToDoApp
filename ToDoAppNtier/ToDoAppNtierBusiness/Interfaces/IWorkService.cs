using System.Collections.Generic;
using System.Threading.Tasks;
using ToDoAppNtierCommon.ResponseObjects;
using ToDoAppNtierDtos.WorkDtos;

namespace ToDoAppNtierBusiness.Interfaces
{
    public interface IWorkService
    {
        Task<IResponse<List<WorkListDto>>> GetAll();
        Task<IResponse<WorkCreateDto>> Create(WorkCreateDto dto);
        Task<IResponse<IDto>> GetById<IDto>(int id);
        Task<IResponse> Remove(int id);
        Task <IResponse<WorkUpdateDto>>Update(WorkUpdateDto dto);
    }
}
