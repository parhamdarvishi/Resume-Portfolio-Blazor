namespace Resume_Portfolio_Blazor.Models;

public class Resume
{
    public Info Info { get; set; }
    public List<string> Languages { get; set; }
    public List<AccessLink> AccessLinks { get; set; }
    public List<SkillCatgeory> SkillCatgeories { get; set; }
    public List<Skill> Skills { get; set; }
    public List<WorkExperience> WorkExperiences { get; set; }
    public List<Education> Educations { get; set; }
    public List<Course> Courses { get; set; }
    public List<FreelanceProject> FreelanceProjects { get; set; }
    public List<Blog> Blogs { get; set; }
}