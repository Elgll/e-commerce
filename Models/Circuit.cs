using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace galli.mingucci._5i.Progetto_E_Commerce.Data;
public class Circuit{
    [Key]
    public string? Name { get; set; }
    public string? Site { get; set; }
    public string? Tipology { get; set; }
    public int Editions { get; set; }
    public int Laps { get; set; }
    public int CircuitLenght { get; set; }
    public int CurvesNumber { get; set; }
    public int RaceLenght { get; set; }
    public string? Description { get; set; }
}