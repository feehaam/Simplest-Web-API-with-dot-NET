using DataAccessLayer.Model;

namespace asingment.Dto
{
    public class StudentDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; }
    }
}
