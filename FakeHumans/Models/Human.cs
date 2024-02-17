namespace FakeHumans.Models;

public class Human
{
    public required string FullName { get; set; }
    public required DateOnly DOB { get; set; }
    public required string Sex { get; set; }
    public required string Country { get; set; }
    public required string CIT { get; set; } 
    public required int Height { get; set; }
    public required string EyesColor { get; set; }
}
