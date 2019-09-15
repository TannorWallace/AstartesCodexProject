namespace AstartesCodexProject.Models
{
  public class Legion
  {
    public int Id { get; set; }
    public string Primarch { get; set; }
    public string Img { get; set; }
    public string legionHomeWorld { get; set; }
    public string LegionStory { get; set; }
    public string LegionRole { get; set; }
    public bool isLoyal { get; set; }
  }
}