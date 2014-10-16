using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShopApp
{
    public partial class SuperShopUI : Form
    {
        private Shop aShop;
        private Product aProduct;

        public SuperShopUI()
        {
            InitializeComponent();
        }

        private void shopSaveButton_Click(object sender, EventArgs e)
        {
            aShop = new Shop(nameTextBox.Text,addressTextBox.Text);
            MessageBox.Show(@"Shop is created");
        }

        private void productSaveButton_Click(object sender, EventArgs e)
        {
            int productId = Convert.ToInt32(productIdTextBox.Text);
            int quentity = Convert.ToInt32(quentityTextBox.Text);
            aProduct = new Product( productId, quentity);
            string msg = aShop.Add(aProduct);
            MessageBox.Show(msg);
        }

        private void showDetailsButton_Click(object sender, EventArgs e)
        {
            string msg = aShop.GetAllProduct(aProduct);
            MessageBox.Show(msg);
        }
    }
}
