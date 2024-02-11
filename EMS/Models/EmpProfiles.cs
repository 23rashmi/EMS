using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMS.Models
{
    [Table("EmpProfile")]
    public class EmpProfiles
    {
        [Key]
        public int EmpCode { get; set; }
        public string? EmpName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Email { get; set; }
        [ForeignKey("DeptCode")]
        public int DeptCode { get; set; }

    }
}
