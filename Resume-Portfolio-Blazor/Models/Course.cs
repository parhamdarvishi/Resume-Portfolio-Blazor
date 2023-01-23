namespace Resume_Portfolio_Blazor.Models;

public class Course
{
    public int Order { get; set; }
    public string Name { get; set; }
    public string Provider { get; set; }
    public string ProviderLink { get; set; }
    public bool IsCertificate { get; set; }
    public List<Master> Masters { get; set; }
}
