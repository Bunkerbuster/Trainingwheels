
namespace DesignPatterns_InterfaceSegregationPrinciple
{
    public interface IAudioBook : ILibraryItem
    {
        int RunTimeInMinutes { get; set; }
    }
}
