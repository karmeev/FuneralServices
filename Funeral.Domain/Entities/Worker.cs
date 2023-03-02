using System.ComponentModel.DataAnnotations;

namespace Funeral.Domain.Entities
{
    public class Worker
    {
        [Required]
        public int Id { get; set; }

        [Display(Name = "Имя"), Required]
        public string Name { get; set; } = null!;

        [Display(Name = "Пасспорт"), Required]
        public string Passport { get; set; } = null!;

        [Display(Name = "Телефон"), Required]
        public string Phone { get; set; } = null!;

        [Display(Name = "Реквизиты"), Required]
        public string Requisites { get; set; } = null!;

        [Display(Name = "Начал работать"), DataType(DataType.Date), Required]
        public DateTime StartWorkDate { get; set; }

        [Display(Name = "Закончил работать"), DataType(DataType.Date), Required]
        public DateTime EndWorkDate { get; set; }

        [Display(Name = "Статус"), Required]
        public string Status { get; set; } = null!;
    }
}