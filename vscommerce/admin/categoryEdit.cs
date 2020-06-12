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

namespace vscommerce.admin
{
    public partial class categoryEdit : MaterialForm
    {
        private Category.Category category;
        private adminPanel adminPanel;
        public categoryEdit(Category.Category category, adminPanel adminForm)
        {
            this.category = category;
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
            if (category.ID == 0)
            {
                idPlaceHolder.Text = "Nuova Categoria";
            }
            else
            {
                idPlaceHolder.Text = category.ID.ToString();
            }

            categoryName.Text = category.name;
        }

        private void update_Click(object sender, EventArgs e)
        {
            //call adminForm function to update/create category
            category.name = categoryName.Text;
            if (adminPanel.updateCategory(category))
            {
                this.Close();
            }
        }
    }
}
