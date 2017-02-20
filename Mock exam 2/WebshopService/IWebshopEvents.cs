using System.ServiceModel;

namespace WebshopService
{
    public interface IWebshopEvents
    {
        [OperationContract(IsOneWay = true)]
        void OnStockChanged(Product[] productList);
    }
}
