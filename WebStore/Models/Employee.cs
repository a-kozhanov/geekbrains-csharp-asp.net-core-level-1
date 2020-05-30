using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebStore.Models
{
    public partial class Employee
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(20, ErrorMessage = "Длина должна быть в пределах от {2} до {1}.", MinimumLength = 3)]
        [Display(Name = "Фамилия")]
        [DisplayFormat(NullDisplayText = "-")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(20, ErrorMessage = "Длина должна быть в пределах от {2} до {1}.", MinimumLength = 3)]
        [Display(Name = "Имя")]
        [DisplayFormat(NullDisplayText = "-")]
        public string FirstName { get; set; }

        [Display(Name = "Должность")]
        [DisplayFormat(NullDisplayText = "-")]
        public string Title { get; set; }

        [Display(Name = "TitleOfCourtesy")]
        [DisplayFormat(NullDisplayText = "-")]
        public string TitleOfCourtesy { get; set; }

        [Display(Name = "Дата рождения")]
        [DisplayFormat(NullDisplayText = "-")]
        public string BirthDate { get; set; }

        [Display(Name = "Дата приема на работу")]
        [DisplayFormat(NullDisplayText = "-")]
        public string HireDate { get; set; }

        [Display(Name = "Адрес")]
        [DisplayFormat(NullDisplayText = "-")]
        public string Address { get; set; }

        [Display(Name = "Город")]
        [DisplayFormat(NullDisplayText = "-")]
        public string City { get; set; }

        [Display(Name = "Регион")]
        [DisplayFormat(NullDisplayText = "-")]
        public string Region { get; set; }

        [Display(Name = "Почтовый индекс")]
        [DisplayFormat(NullDisplayText = "-")]
        public string PostalCode { get; set; }

        [Display(Name = "Страна")]
        [DisplayFormat(NullDisplayText = "-")]
        public string Country { get; set; }

        [Display(Name = "Домашний телефон")]
        [DisplayFormat(NullDisplayText = "-")]
        public string HomePhone { get; set; }

        [Display(Name = "Расширение")]
        [DisplayFormat(NullDisplayText = "-")]
        public string Extension { get; set; }

        [Display(Name = "Фото")]
        [DisplayFormat(NullDisplayText = "-")]
        public byte[] Photo { get; set; }

        [Display(Name = "Примечание")]
        [DisplayFormat(NullDisplayText = "-")]
        public string Notes { get; set; }

        [Display(Name = "Отчеты")]
        [DisplayFormat(NullDisplayText = "-")]
        public long? ReportsTo { get; set; }

        [Display(Name = "Путь к фотографии")]
        [DisplayFormat(NullDisplayText = "-")]
        public string PhotoPath { get; set; }
    }
}