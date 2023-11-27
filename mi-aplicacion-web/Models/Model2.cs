using System;
using System.ComponentModel.DataAnnotations;

namespace mi_aplicacion_web.Models
{
    public class Model2
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}