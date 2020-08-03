namespace CSharp_InterfacesLibrary
{
    public interface IDigitalProductModel : IProductModel
    {
        int TotalDownLoadsLeft { get; }
    }
}