
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectCrudMVC.Models
{

    [Table("Product")]
    public class Product
    {
        [Column("Id")]
        [Display(Name = "Id")]
        public int Id { get; set; }


        [Column("Name")]
       [Display(Name= "Name")]
        public string Name { get; set; }

        [Column("Ean")]
        [Display(Name = "Ean")]
        public int Ean { get; set; }

    }
}
