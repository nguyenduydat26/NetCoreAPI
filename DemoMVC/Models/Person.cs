using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models
{
    [Table("Person")]
    public class Person 
    {
        [Key]
        public String PersonID { get; set;}= string.Empty;
        [Required]
        public String FullName { get;set;}= string.Empty;
        [Required]
        public String Address { get; set;}= string.Empty;
    }
}