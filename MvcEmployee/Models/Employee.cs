using System.ComponentModel.DataAnnotations;

namespace MvcEmployee.Models;

public class Employee
{
    public int Id { get; set; }

    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string? Nombre  { get; set; }

    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string? Apellido { get; set; }

    [Range(1, 100)]
    public int Edad { get; set; }

    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string? Departamento { get; set; }

    [Range(1, 100000000000)]
    [DataType(DataType.Currency)]
    public decimal Salario{ get; set; }
    
}