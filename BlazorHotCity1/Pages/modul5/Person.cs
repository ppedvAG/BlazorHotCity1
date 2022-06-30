using System.ComponentModel.DataAnnotations;

namespace BlazorHotCity1.Pages.modul5
{
    public class Person
    {
        [Required(ErrorMessage ="Bitte ID")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Bitte Name")]
        [StringLength(10,ErrorMessage ="zu lange")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Bitte Gross")]
        [Range(140,199, ErrorMessage ="keine Achterbahn")]
        public int Gross { get; set; }
        [Required(ErrorMessage = "Bitte GebDat")]
        public DateTime GebDat { get; set; }
    }
}
