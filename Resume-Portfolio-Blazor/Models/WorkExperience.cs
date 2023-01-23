namespace Resume_Portfolio_Blazor.Models;

public class WorkExperience
{
    public int Order { get; set; }
    public string CompanyName { get; set; }
    public string CompanyLink { get; set; }
    public string CompanyLocation { get; set; }
    public string CompanyLogo { get; set; }
    public string JobTitle { get; set; }
    public string Duration { get; set; }
    public string Description { get; set; }
    public List<string> Achievements { get; set; }
    public List<string> Skills { get; set; }

}