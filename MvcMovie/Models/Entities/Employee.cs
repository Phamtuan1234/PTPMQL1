using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models.Entities
{
    [Table("Employee")]
    public class Employee : Person
    {
        public string ChucVu { get; set; }
        public DateTime ThoiGianLamViec { get; set; }
    }
}