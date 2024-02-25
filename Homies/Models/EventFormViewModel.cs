using System.ComponentModel.DataAnnotations;
using static Homies.Data.DataConstants;

namespace Homies.Models
{
    public class EventFormViewModel
    {
        [Required(ErrorMessage = RequireErrorMessage)]
        [StringLength(EventNameMaximumLength, 
            MinimumLength = EventNameMinimumLength,
            ErrorMessage = StringLengthErrorMessage)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = StringLengthErrorMessage)]
        [StringLength(EventDescriptionMaximumLength,
            MinimumLength = EventDescriptionMinimumLength,
            ErrorMessage = StringLengthErrorMessage)]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = StringLengthErrorMessage)]
        public string Start { get; set; } = string.Empty;

        [Required(ErrorMessage = StringLengthErrorMessage)]
        public string End { get; set; } = string.Empty;

        [Required(ErrorMessage = StringLengthErrorMessage)]
        public int TypeId { get; set; }

        public IEnumerable<TypeViewModel> Types { get; set; } = null!;
    }
}
