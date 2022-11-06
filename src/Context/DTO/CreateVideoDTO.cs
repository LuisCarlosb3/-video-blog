using System.ComponentModel.DataAnnotations;

namespace workspace.Context.DTO
{
  public class CreateVideoDTO
  {
    [Required]
    [MinLength(3)]
    [MaxLength(100)]
    public string Tittle { get; set; }
    public string Description { get; set; }
    [Required]
    [Url]
    public string URL { get; set; }
  }

}