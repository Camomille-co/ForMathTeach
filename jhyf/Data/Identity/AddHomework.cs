using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jhyf.Data.Identity
{
    [Table("Homeworks")]
    public class AddHomework
    {
        public int Id { get; set; }

        [Display(Name = "Задание")]
        public string? Name { get; set; }
        
        [Display(Name = "Ссылка на задание")]
        public string? Zadanie { get; set; }
    }
}
