using System.ComponentModel.DataAnnotations;
namespace DojoSurveyCopy.Models
{
public class survey
{
   [Required]
   [MinLength(4)]
   public string Name { get; set; }
   
   [Required]
   public string Dojo{ get; set; }
   
   [MaxLength(20)]

   public string Comment{ get; set; }

   [Required]
   public string Language{ get; set; }


}
    
}