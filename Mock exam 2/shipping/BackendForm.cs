using System.Windows.Forms;
using server.BackofiiceServiceReference;
namespace backend
{
    public partial class BackendForm : Form
    {
        public BackendForm()
        {
            InitializeComponent();
            proxy = new BackofficeClient();
        }
        BackofficeClient proxy;
        private void updateOrdersBtn_Click(object sender, System.EventArgs e)
        {
            idListBox.Items.Clear();
            dateTimeBox.Items.Clear();
            foreach (var order in proxy.GetOrderList())
            {
                idListBox.Items.Add(order.OrderId.ToString() + " " + order.ProductId);
                dateTimeBox.Items.Add(order.Moment.ToString());
            }
        }
    }
}
