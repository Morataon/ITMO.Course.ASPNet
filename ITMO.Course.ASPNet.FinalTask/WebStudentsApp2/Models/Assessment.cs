using System.ComponentModel.DataAnnotations;

namespace ITMO.Course.ASPNet.FinalTask.Models
{
    public class Assessment
    {
        public int Id { get; set; }
        public int Value { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public int StudentId { get; set; }
        public Student? Student { get; set; }
    }
}
