using Microsoft.Extensions.FileProviders;
using Newtonsoft.Json;
using Resume_Portfolio_Blazor.Models;

namespace Resume_Portfolio_Blazor.Business;

public class ResumeBusiness:IResumeBusiness
{
    private readonly IFileProvider _fileProvider;

    public ResumeBusiness(IFileProvider fileProvider)
    {
        _fileProvider = fileProvider;
    }

    public Resume GetResume()
    {
        Resume resume = null;
        var fileInfo = _fileProvider.GetFileInfo("/wwwroot/data/Resume.json");
        if (fileInfo != null)
        {
            using (var stream = fileInfo.CreateReadStream())
            using (var reader = new StreamReader(stream))
            {
                string json = reader.ReadToEnd();
                resume = JsonConvert.DeserializeObject<Resume>(json);
            }
        }
        return resume;
    }

}
