using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMS.Models
{
    [Table("DeptMaster")]
    public class DeptMaster
    {
        [Key]
        public int DeptCode { get; set; }
        public string? DeptName { get; set; }
        public ICollection<EmpProfiles>? EmpProfile { get; set; }


    }
}
