using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CentralMonitoring.Models
{
    [Table("tbl_strip")]
    public class Strip
    {
        [Key]
        public int Id { get; set; }
        public List<StripData> StripDatas { get; set; }
    }
}