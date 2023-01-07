using asingment.Dto;
using AutoMapper;
using DataAccessLayer.Model;

namespace asingment.Helper
{
    public class MappintProfiles: Profile
    {
        public MappintProfiles()
        {
            CreateMap<StudentDto, Student>();
            CreateMap<CourseDto, Course>();
        }
    }
}
