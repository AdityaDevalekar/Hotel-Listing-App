using System.ComponentModel.DataAnnotations.Schema;

namespace Universtiy_Portal.Data
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }


        [ForeignKey(nameof(College))]
        public int CollegeId { get; set; }
        public College college { get; set; }


        
    }
}
