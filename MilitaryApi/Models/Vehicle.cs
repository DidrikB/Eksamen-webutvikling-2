using System.ComponentModel.DataAnnotations;

namespace MilitaryApi.Models;

public class Vehicle
{
    [Key]    
    public int Id { get; set; }
    public String? Name { get; set; }
    public String? Image { get; set; }
}