using System.ComponentModel.DataAnnotations;

namespace FitnessStation.Models.BindingModels
{
    public class EditUserBm
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
