using System.Collections.Generic;
using System.ServiceModel;

namespace WebshopService
{
    [ServiceContract(Namespace = "WebshopService")]
    public interface IBackoffice
    {
        [OperationContract]
        List<Order> GetOrderList();

    }
}
