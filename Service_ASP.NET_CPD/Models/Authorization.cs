using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Service_ASP.NET_CPD.Models
{
    public class Authorization
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Role { get; set; }
        public int? CanUploadDocument { get; set; } = default(int?);
        public int? CanViewDocument { get; set; } = default(int?);
        public int? CanDownloadDocument { get; set; } = default(int?);
        public int? CanDeleteDocument { get; set; } = default(int?);
    }
}
