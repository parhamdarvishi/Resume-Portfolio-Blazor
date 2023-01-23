namespace Resume_Portfolio_Blazor.Business;
using Microsoft.Extensions.Hosting;

public class JsonFileReader : IJsonFileReader
{
    private readonly IHostEnvironment _environment;

    public JsonFileReader(IHostEnvironment environment)
    {
        _environment = environment;
    }

    public string ReadFile()
    {
        var path = Path.Combine(_environment.ContentRootPath, "file.json");
        return System.IO.File.ReadAllText(path);
    }

}
