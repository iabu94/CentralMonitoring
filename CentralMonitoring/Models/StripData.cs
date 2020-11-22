using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CentralMonitoring.Models
{
    [Table("tbl_stripdata")]
    public class StripData
    {
        [Key]
        public int Id { get; set; }
        public double FHR1 { get; set; }
        public double FHR2 { get; set; }
        public double TOCO1 { get; set; }
        public virtual int StripID { get; set; }

        [ForeignKey("StripID")]
        public virtual Strip Strip { get; set; }
    }
}