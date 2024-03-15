using System.ComponentModel.DataAnnotations;

namespace ITMO.Course.ASPNet.FinalTask.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public List<Assessment> Assessments { get; set; } = new List<Assessment>();
    }
}
