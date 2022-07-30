using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModels;

public class EditorCategoryViewModel
{
    [Required]
    [StringLength(40, MinimumLength = 3)]
    public string Name { get; set; }
    [Required]
    public string Slug { get; set; }
}
