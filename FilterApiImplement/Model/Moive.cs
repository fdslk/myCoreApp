using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Movie")]
public class Movie: IEntity
{
    [Key]
    public Guid Id { get; set; }
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Genre is required")]
    public string Genre { get; set; }
    [Required(ErrorMessage = "Director is required", AllowEmptyStrings=true)]
    public string Director { get; set; }
}

public interface IEntity
{
}