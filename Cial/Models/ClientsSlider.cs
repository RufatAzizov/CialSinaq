using System.ComponentModel.DataAnnotations;

namespace Cial.Models
{
    public class ClientsSlider : BaseEntity
    {
        [Required, MinLength(5), MaxLength(30)]
        public string Title { get; set; }
        [Required, MinLength(10), MaxLength(30)]
        public string Description { get; set; }



    }
}
