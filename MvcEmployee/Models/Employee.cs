using System.ComponentModel.DataAnnotations;

namespace MvcEmployee.Models;

public class Employee
{
    public int Id { get; set; }
    public string? Nombre  { get; set; }
    public int Edad { get; set; }
    public string? Departamento { get; set; }
    public decimal Salario{ get; set; }
}