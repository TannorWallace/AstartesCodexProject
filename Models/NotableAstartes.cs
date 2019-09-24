namespace AstartesCodexProject.Models
{
  public class NotableAstartes
  {
    public int Id { get; set; }
    public string Img { get; set; }
    public string Name { get; set; }
    public string Story { get; set; }
    public string Legion { get; set; }
    public string Primarch { get; set; }
    public bool isLoyal { get; set; }
  }
}