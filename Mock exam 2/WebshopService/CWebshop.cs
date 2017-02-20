using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace WebshopService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Reentrant)]

    public class CWebshop : IWebshop, IBackoffice
    {
        public CWebshop()
        {
            WebshopName = "Dickson's store";
            orderList = new List<Order>();
            productsList = new List<Product>();
            productsList.Add(new Product("Dracula", "Very scary book", 10.5m, 12.5, 5));
            productsList.Add(new Product("Ali baba", "Very funny book", 22m, 1.5, 9));
            productsList.Add(new Product("Don Quihote", "Very angry book", 30.5m, 2.5, 4));
        }
        public List<Product> productsList;
        public List<Order> orderList;
        private int orderIdGenerator = 1;
        private Action<Product[]> StockChanged = delegate { };

        public string WebshopName { get; set; }

        public string GetWebshopName()
        {
            return WebshopName;
        }

        public List<Product> GetAllProducts()
        {
            return productsList;
        }

        public string GetProductInfo(string productName)
        {
            foreach (Product product in productsList)
            {
                if (product.Name == productName)
                {
                    return product.Description;
                }
            }
            return "No such product";
        }

        public bool BuyProduct(string productName)
        {
            foreach (Product product in productsList)
            {
                if (product.Name == productName)
                {

                    if (product.Stock > 0)
                    {
                        // New order for the last task
                        Order newOrder = new Order(orderIdGenerator++, product.Name, DateTime.Now);
                        orderList.Add(newOrder);

                        product.Stock--;

                        // Instance of the current client
                        IWebshopEvents clientCallback = OperationContext.Current.GetCallbackChannel<IWebshopEvents>();
                        // We remove it to prevent dealock
                        StockChanged -= clientCallback.OnStockChanged;
                        // Add the new full course
                        StockChanged(GetAllProducts().ToArray());
                        // Add the current cliet back 
                        StockChanged += clientCallback.OnStockChanged;

                        return true;
                    }
                }
            }
            return false;
        }

        public void SubscribeEvent()
        {
            IWebshopEvents clientCallback = OperationContext.Current.GetCallbackChannel<IWebshopEvents>();
            StockChanged += clientCallback.OnStockChanged;
        }

        public void UnsubscribeEvent()
        {
            IWebshopEvents clientCallback = OperationContext.Current.GetCallbackChannel<IWebshopEvents>();
            StockChanged -= clientCallback.OnStockChanged;
        }

        public List<Order> GetOrderList()
        {
            return orderList;
        }
    }
}
