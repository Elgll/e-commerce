using System.ComponentModel.DataAnnotations;
namespace galli.mingucci._5i.Progetto_E_Commerce.Data;
using Microsoft.EntityFrameworkCore;

public class Bike{
    
    public string?  Brand { get; set; }

    [Key]
    public string? Model { get; set; }
    public string? SetUp { get; set; }
    public DateOnly ProductionYear { get; set; }
    public string? Category { get; set; }
    public int Displacement { get; set; }
    public int Power { get; set; }
    public int Weight { get; set; }
    public int Price { get; set; }
    public int Strokes { get; set; }
    public int Cylinders { get; set; }
    public string? CylindersConfiguration { get; set; }
    public string? CylinderDisposition { get; set; }
    public string? Refrigeration { get; set; }
    public string? StartUp { get; set; }
    public string? Clutch { get; set; }
    public int ValvesNumber { get; set; }
    public string? Distribution { get; set; }
    //navigation property
    public ICollection<Circuit> Circuits  {get; set;}
}