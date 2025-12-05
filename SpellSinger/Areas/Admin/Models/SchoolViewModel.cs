using System.ComponentModel.DataAnnotations;

namespace SpellSinger.Areas.Admin.Models;

public class SchoolViewModel : NamedEntityViewModel
{
    [Display(Name = "School Color")]
    [RegularExpression("^#([A-Fa-f0-9]{6}|[A-Fa-f0-9]{3})$", ErrorMessage = "Invalid Hex Color")]
    public string? Color { get; set; } = "#000000"; 
}
