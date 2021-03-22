using CourseSignUp.Services.Dto.Lecturers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CourseSignUp.Services.DomainServices.Contracts
{
    public interface ILecturerService
    {
        Task<bool> CreateLecturer(LecturerDto lecturer);
    }
}
