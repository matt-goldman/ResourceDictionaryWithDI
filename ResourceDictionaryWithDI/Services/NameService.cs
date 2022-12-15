namespace ResourceDictionaryWithDI.Services;

public interface INameService
{
    string GetName();
}

public class NameService : INameService
{
    public string GetName()
    {
        return "Matt";
    }
}
