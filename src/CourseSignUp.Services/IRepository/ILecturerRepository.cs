using CourseSignUp.Adapters.Repository.Entities;
using CourseSignUp.Common.Persistence;
using CourseSignUp.Services.Dto.Lecturers;
using System.Threading.Tasks;

namespace CourseSignUp.Services.IRepository
{
    public interface ILecturerRepository : IRepository<Lecturer>
    {
        Task CreateLecturer(LecturerDto lecturer);
    }
}
