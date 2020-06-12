using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vscommerce.user
{
    public partial class productDetail : MaterialForm
    {
        private Product.Product product;
        private User.User loggedUser;
        private userHome userForm;
        public productDetail(Product.Product product, User.User loggedUser, userHome userForm)
        {
            this.userForm = userForm;
            this.product = product;
            this.loggedUser = loggedUser;
            InitializeComponent();
            MaterialSkinManager materialUIManager = MaterialSkinManager.Instance;
            materialUIManager.AddFormToManage(this);
            materialUIManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialUIManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.Orange200,
                TextShade.WHITE
                );
            namePlaceholder.Text = product.name;
            descriptionPlaceHolder.Text = product.description;
            pricePlaceHolder.Text = product.price.ToString() + " (" + product.tax.ToString()+ "%)";
            brandPlaceHolder.Text = product.brand.name;
            categoryPlaceHolder.Text = product.category.name;
            productImage.ImageLocation = product.image;
        }

        private void addToCart(object sender, EventArgs e)
        {
            this.Close();
            userForm.addToCart(this.product);
        }
    }
}
