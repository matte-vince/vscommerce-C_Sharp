using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
namespace vscommerce.admin
{
    public partial class productEdit : MaterialForm
    {
        private Product.Product product;
        private adminPanel adminPanel;
        public productEdit(Product.Product product, adminPanel adminForm)
        {
            this.product = product;
            this.adminPanel = adminForm;
            InitializeComponent();
            MaterialSkinManager materialUIManager = MaterialSkinManager.Instance;
            materialUIManager.AddFormToManage(this);
            materialUIManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialUIManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.Orange200,
                TextShade.WHITE
                );
            productBrand.DisplayMember = "name";
            productBrand.ValueMember = "ID";
            productCategory.DisplayMember = "name";
            productCategory.ValueMember = "ID";
            this.loadProduct();
        }

        private void loadProduct()
        {
            productBrand.DataSource = adminPanel.getBrands();
            productBrand.DisplayMember = "name";
            productBrand.ValueMember = "ID";
            productCategory.DataSource = adminPanel.getCategories();
            productCategory.DisplayMember = "name";
            productCategory.ValueMember = "ID";
            if (product.ID == 0)
            {
                idPlaceHolder.Text = "Nuovo Prodotto";
            }
            else
            {
                idPlaceHolder.Text = product.ID.ToString();
                productBrand.SelectedValue = product.brand.ID;
                productCategory.SelectedValue = product.category.ID;
            }
            productName.Text = product.name;
            productDescription.Text = product.description;
            productPrice.Text = product.price.ToString();
            productTax.Text = product.tax.ToString();
            productQty.Text = product.qty.ToString();
            product.barcode = product.barcode;
            productImageLink.Text = product.image;
            
            
            
            
            productImage.ImageLocation = product.image;
        }

        //allow only numbers and commas to create a decimal number
        // used in price textbox
        private void textBox_KeyPress_decimal(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        //allow only numbers to create a integer number
        // used in qty and tax textbox
        private void textBox1_KeyPress_integer(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        private void update_Click(object sender, EventArgs e)
        {
            //call adminForm function to update/create product
            if (this.productValidation())
            {
                product.name = productName.Text;
                product.description = productDescription.Text;
                product.price = double.Parse(productPrice.Text);
                product.tax = int.Parse(productTax.Text);
                product.qty = int.Parse(productQty.Text);
                product.image = productImageLink.Text;
                product.barcode = productBarcode.Text;
                product.brand.ID = (int)productBrand.SelectedValue;
                product.brand.name = productBrand.SelectedText;
                product.category.ID = (int)productCategory.SelectedValue;
                product.category.name = productCategory.SelectedText;
                if (this.adminPanel.updateProduct(product))
                {
                    this.Close();
                }
            }
            
        }

        // product fields validation
        private bool productValidation()
        {

            if (string.IsNullOrWhiteSpace(productName.Text))
            {

                errorProviderApp.SetError(productName, "Non hai compilato il nome");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(productPrice.Text) || productPrice.Text == "0")
            {

                errorProviderApp.SetError(productPrice, "Non hai compilato il prezzo");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(productTax.Text))
            {

                errorProviderApp.SetError(productTax, "Non hai compilato l'IVA");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(productQty.Text))
            {

                errorProviderApp.SetError(productQty, "Non hai compilato la quantità");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(productImageLink.Text))
            {

                errorProviderApp.SetError(productImageLink, "Non hai compilato il link dell'immagine");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(productBrand.Text))
            {

                errorProviderApp.SetError(productBrand, "Non hai compilato la marca");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(productCategory.Text))
            {

                errorProviderApp.SetError(productCategory, "Non hai compilato la Categoria");
                return false;
            }
            else
            {

                errorProviderApp.SetError(productName, "");
                errorProviderApp.SetError(productPrice, "");
                errorProviderApp.SetError(productTax, "");
                errorProviderApp.SetError(productQty, "");
                errorProviderApp.SetError(productImageLink, "");
                errorProviderApp.SetError(productBrand, "");
                errorProviderApp.SetError(productCategory, "");
                return true;
            }
        }

        private void loadImageFromLink(object sender, EventArgs e)
        {
            productImage.ImageLocation = productImageLink.Text;
        }
    }
}
