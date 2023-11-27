using System;
using System.ComponentModel.DataAnnotations;

namespace mi_aplicacion_web.Models
{
    public class Model1
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}