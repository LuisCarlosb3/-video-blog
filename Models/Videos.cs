using System;
using System.ComponentModel.DataAnnotations;
namespace workspace.Models
{
  public class Videos
  {
    [Required]
    private Guid Id { get; set; }
    [Required]
    [MinLength(3)]
    [MaxLength(100)]
    private string Titulo { get; set; }
    private string Descrição { get; set; }
    [Required]
    [Url]
    private string URL { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
  }
}