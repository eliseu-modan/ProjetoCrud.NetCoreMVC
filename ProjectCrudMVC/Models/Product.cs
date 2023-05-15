
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectCrudMVC.Models
{

    [Table("Product")]
    public class Product
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }


        [Column("Name")]
       [Display(Name= "Nome")]
        public string Name { get; set; }
    }
}
