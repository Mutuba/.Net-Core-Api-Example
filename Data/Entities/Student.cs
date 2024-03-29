using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class Student
{    
    [Key]
    public int Id { get; set; }
    [Required]
    [MaxLength(50)]

    public string? FirstName { get; set; }
    [Required]
    [MaxLength(50)]
    public string? LastName { get; set; }
    public int? Age {get;set;}
    [Required]
    public string? Gender{get;set;}
}
