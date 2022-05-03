using System.ComponentModel.DataAnnotations;

namespace MilitaryApi.Models;

public class Soldier
{
    [Key]    
    public int Id { get; set; }
    public String? Name { get; set; }
    public int age { get; set; }
    public Boolean? Active { get; set; }
    public String? Image { get; set; }
}