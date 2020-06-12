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
using vscommerce.Brand;

namespace vscommerce.admin
{
    public partial class brandEdit : MaterialForm
    {
        private Brand.Brand brand;
        private adminPanel adminPanel;
        public brandEdit(Brand.Brand brand, adminPanel adminForm)
        {
            this.brand = brand;
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
            if (brand.ID == 0)
            {
                idPlaceHolder.Text = "Nuova Marca";
            }
            else {
                idPlaceHolder.Text = brand.ID.ToString();
            }
            
            brandName.Text = brand.name;
        }

        private void update_Click(object sender, EventArgs e)
        {
            //call adminForm function to update/create brand
            brand.name = brandName.Text;
            if (adminPanel.updateBrand(brand))
            {
                this.Close();
            }
        }
    }
}
