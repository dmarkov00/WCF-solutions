using System.Collections.Generic;
using System.ServiceModel;

namespace WebshopService
{
    [ServiceContract(Namespace = "WebshopService", CallbackContract = typeof(IWebshopEvents))]
    public interface IWebshop
    {
        [OperationContract]
        string GetWebshopName();
        [OperationContract]
        List<Product> GetAllProducts();
        [OperationContract]
        string GetProductInfo(string productName);
        [OperationContract]
        bool BuyProduct(string productName);
        [OperationContract]
        void SubscribeEvent();

        [OperationContract]
        void UnsubscribeEvent();

    }
}
