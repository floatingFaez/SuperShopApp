using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperShopApp.BLL;
using SuperShopApp.DLL.DAO;

namespace SuperShopApp
{
    public partial class SuperShopUI : Form
    {
        
        ShopBll aShopBll = new ShopBll();
        private Shop aShop;
        private Product aProduct;

        public SuperShopUI()
        {
            InitializeComponent();
        }

        private void shopSaveButton_Click(object sender, EventArgs e)
        {
            aShop = new Shop(nameTextBox.Text,addressTextBox.Text);
            string msg = aShopBll.Save(aShop);
            MessageBox.Show(msg);
        }

        private void productSaveButton_Click(object sender, EventArgs e)
        {
            string productId = productIdTextBox.Text;
            int quentity = Convert.ToInt32(quentityTextBox.Text);
            aProduct = new Product( productId, quentity);
            string msg = aShop.Add(aProduct);
            MessageBox.Show(msg);
        }

        private void showDetailsButton_Click(object sender, EventArgs e)
        {
            List<Product> products = aShop.GetAllProduct();
            string msg = aShop.ShowAllProduct(products);
            MessageBox.Show(msg);
        }
    }
}
