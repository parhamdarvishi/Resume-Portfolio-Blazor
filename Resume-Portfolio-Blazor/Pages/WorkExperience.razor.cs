using Microsoft.AspNetCore.Components;
using Resume_Portfolio_Blazor.Business;
using Resume_Portfolio_Blazor.Models;

namespace Resume_Portfolio_Blazor.Pages;

public partial class WorkExperience
{
    [Inject]
    public IResumeBusiness? resumeBusiness { get; set; }

    [Parameter]
    public Resume resume { get; set; }

    protected override void OnInitialized()
    {
        resume = resumeBusiness.GetResume();
    }
}
