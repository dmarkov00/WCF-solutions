using System.Windows.Forms;
using client.WebshopServiceReference;
using System.ServiceModel;
using System;
using System.Collections.Generic;

namespace client
{
    public partial class ClientForm : Form, IWebshopCallback
    {
        public ClientForm()
        {
            InitializeComponent();
            context = new InstanceContext(this);
            proxy = new WebshopClient(context);
            proxy.SubscribeEvent();
        }
        private WebshopClient proxy;
        private InstanceContext context;


        private void GetWebShopBtn_Click(object sender, System.EventArgs e)
        {
            lblNotifications.Text = proxy.GetWebshopName();
        }

        private void GetProductListBtn_Click(object sender, System.EventArgs e)
        {
            

            Product[] productsList = proxy.GetAllProducts();
            ShowProductList(productsList);


        }

        private void GetProductInfoBtn_Click(object sender, System.EventArgs e)
        {
            lblNotifications.Text = proxy.GetProductInfo(tbProductName.Text);
        }

        private void BuyProductBtn_Click(object sender, System.EventArgs e)
        {
            string productName = idListBox.SelectedItem.ToString();
            if (proxy.BuyProduct(productName))
            {
                lblNotifications.Text = "Purchase succesfull";
                // Updating listbox
                int index = idListBox.SelectedIndex;
                int stock = Convert.ToInt32(stockListBox.Items[index]);
                stock--;
                stockListBox.Items[index] = stock.ToString();

                //GetProductListBtn.PerformClick();
            }
            else
            {
                lblNotifications.Text = "Purchase unsuccesfull, out of stock";
            }
        }

        private void ShowProductList(Product[] productsList)
        {
            idListBox.Items.Clear();
            priceListBox.Items.Clear();
            stockListBox.Items.Clear();
            foreach (var product in productsList)
            {
                idListBox.Items.Add(product.Name.ToString());
                priceListBox.Items.Add(product.Price.ToString());
                stockListBox.Items.Add(product.Stock.ToString());
            }


        }

        public void OnStockChanged(Product [] productList)
        {     
            ShowProductList(productList);
        }

        private void ClientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            proxy.UnsubscribeEvent();
        }
    }
}

