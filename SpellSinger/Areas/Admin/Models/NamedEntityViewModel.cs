using System.ComponentModel.DataAnnotations;

namespace SpellSinger.Areas.Admin.Models;

public abstract class NamedEntityViewModel : EntityBaseViewModel
{
    [Required(ErrorMessage = "{0} is required.")]
    [StringLength(100, ErrorMessage = "{0} cannot be longer than {1} characters.")]
    [Display(Name = "Name")]
    public string Name { get; set; } = string.Empty;

    [DataType(DataType.MultilineText)]
    [Display(Name = "Description")]
    public string? Description { get; set; }

    [Display(Name = "Icon / Image URL")]
    [Url(ErrorMessage = "Please enter a valid URL.")]
    public string? ImageUrl { get; set; }
}
