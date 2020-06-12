using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using vscommerce.Product;
using vscommerce.Order;
using vscommerce.User;
using vscommerce.Brand;
using vscommerce.Category;
namespace vscommerce.admin
{
    public partial class adminPanel : MaterialForm
    {
        private User.User loggedUser;
        private ProductManagerClient productManager;
        private OrderManagerClient orderManager;
        private UserManagerClient userManager;
        private BrandManagerClient BrandManager;
        private CategoryManagerClient CategoryManager;
 
        public adminPanel(User.User loggedUser)
        {
            this.loggedUser = loggedUser;
            //manager refs
            this.productManager = new ProductManagerClient();
            this.orderManager = new OrderManagerClient();
            this.userManager = new UserManagerClient();
            this.BrandManager = new BrandManagerClient();
            this.CategoryManager = new CategoryManagerClient();
            InitializeComponent();

            //materialskin stuff
            MaterialSkinManager materialUIManager = MaterialSkinManager.Instance;
            materialUIManager.AddFormToManage(this);
            materialUIManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialUIManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.Orange200,
                TextShade.WHITE
                );

            //product list
            productListView.Clear();
            productListView.View = View.Details;
            productListView.Columns.Add("ID", 150, HorizontalAlignment.Left);
            productListView.Columns.Add("Nome", 250, HorizontalAlignment.Left);
            productListView.Columns.Add("Barcode", 200, HorizontalAlignment.Left);
            productListView.Columns.Add("prezzo", 150, HorizontalAlignment.Left);
            productListView.Columns.Add("quantita", 150, HorizontalAlignment.Left);
            
            //order list
            ordersListView.View = View.Details;
            ordersListView.Columns.Add("ID", 150, HorizontalAlignment.Left);
            ordersListView.Columns.Add("Cliente", 150, HorizontalAlignment.Left);
            ordersListView.Columns.Add("Data Ordine", 300, HorizontalAlignment.Center);
            ordersListView.Columns.Add("Totale", 200, HorizontalAlignment.Left);

            //customer list
            customerListView.View = View.Details;
            customerListView.Columns.Add("ID", 150, HorizontalAlignment.Left);
            customerListView.Columns.Add("Cognome", 150, HorizontalAlignment.Left);
            customerListView.Columns.Add("Nome", 300, HorizontalAlignment.Center);
            customerListView.Columns.Add("Data Nascita", 200, HorizontalAlignment.Left);
            customerListView.Columns.Add("Codice Fiscale", 200, HorizontalAlignment.Left);
            customerListView.Columns.Add("Ruolo", 200, HorizontalAlignment.Left);

            brandListView.View = View.Details;
            brandListView.Columns.Add("ID", 150, HorizontalAlignment.Left);
            brandListView.Columns.Add("Nome", 300, HorizontalAlignment.Center);

            categoryListView.View = View.Details;
            categoryListView.Columns.Add("ID", 150, HorizontalAlignment.Left);
            categoryListView.Columns.Add("Nome", 300, HorizontalAlignment.Center);

            this.loadProducts();
            this.loadOrders();
            this.loadCustomers();
            this.loadBrands();
            this.loadCategories();
        }

        private void loadProducts()
        {
            productListView.Items.Clear();
           
            try
            {
                var products = this.productManager.getProducts(this.loggedUser.email, this.loggedUser.password);
                productCounter.Text = products.Length.ToString();
                foreach (var p in products)
                {
                    productListView.Items.Add(new ListViewItem(new string[] { p.ID.ToString(), p.name, p.barcode, p.price.ToString(), p.qty.ToString()}));
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Errore connessione al server.Non è possibile caricare i dati");
            }
            productListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            productListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void loadOrders()
        {
            ordersListView.Items.Clear();
            
            try
            {
                var orders = this.orderManager.getOrders(this.loggedUser.email, this.loggedUser.password);
                ordersCounter.Text = orders.Length.ToString(); ;
                foreach (var order in orders)
                {
                    ordersListView.Items.Add(new ListViewItem(new string[] { order.ID.ToString(),order.customer.surname + " " + order.customer.name, order.date.ToString(), order.total.ToString() }));
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Errore connessione al server.Non è possibile caricare i dati");
            }
            ordersListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            ordersListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void loadCustomers()
        {
            customerListView.Items.Clear();

            try
            {
                var customers = this.userManager.getUsers(this.loggedUser.email, this.loggedUser.password);
                
                foreach (var customer in customers)
                {
                    string ruolo;
                    if (customer.isAdmin)
                    {
                        ruolo = "Admin";
                    }
                    else
                    {
                        ruolo = "Cliente";
                    }
                    customerListView.Items.Add(new ListViewItem(new string[] { customer.ID.ToString(), customer.surname, customer.name,
                        customer.birthday.ToString(), customer.fiscalCode, ruolo}));
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Errore connessione al server.Non è possibile caricare i dati");
            }
            customerListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            customerListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void loadBrands()
        {
            brandListView.Items.Clear();

            try
            {
                var brands = this.BrandManager.getBrands(this.loggedUser.email, this.loggedUser.password);
                foreach (var brand in brands)
                {
                    brandListView.Items.Add(new ListViewItem(new string[] { brand.ID.ToString(), brand.name }));
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Errore connessione al server.Non è possibile caricare i dati");
            }
            brandListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            brandListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void loadCategories()
        {
            categoryListView.Items.Clear();

            try
            {
                var categories = this.CategoryManager.getCategories(this.loggedUser.email, this.loggedUser.password);
                foreach (var category in categories)
                {
                    categoryListView.Items.Add(new ListViewItem(new string[] { category.ID.ToString(), category.name }));
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Errore connessione al server. Non è possibile caricare i dati");
            }
            categoryListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            categoryListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        //double click on brand row and opens details form
        private void brandClick(object sender, EventArgs e)
        {
            brandEdit editBrandForm = new brandEdit(BrandManager.getBrandById(loggedUser.email, loggedUser.password,
                int.Parse(brandListView.SelectedItems[0].SubItems[0].Text)), this);
            editBrandForm.Show();
        }

        //create brand button
        private void createBrand_Click(object sender, EventArgs e)
        {
            Brand.Brand newBrand = new Brand.Brand();
            newBrand.ID = 0;
            newBrand.name = "";
            brandEdit editBrandForm = new brandEdit(newBrand, this);
            editBrandForm.Show();
        }

        //if id is 0 then i'm going to create a new brand. if id != 0 then i update the selected brand
        //called from brandEdit form 
        public bool updateBrand(Brand.Brand brand)
        {
            bool result;
            if(brand.ID != 0)
            {
                result = this.BrandManager.updateBrand(this.loggedUser.email, this.loggedUser.password, brand);
            }
            else
            {
                result = this.BrandManager.createBrand(this.loggedUser.email, this.loggedUser.password, brand);
            }
            if (result)
            {
                this.loadBrands();
            }
            else
            {
                MessageBox.Show("Errore all'aggiornameto/creazione della marca");
            }
            return result;
        }

        //create category button 
        private void createCategory_Click(object sender, EventArgs e)
        {
            Category.Category newCategory = new Category.Category();
            newCategory.ID = 0;
            newCategory.name = "";
            categoryEdit editCategoryForm = new categoryEdit(newCategory, this);
            editCategoryForm.Show();
        }

        //if id is 0 then i'm going to create a new category. if id != 0 then i update the selected category
        //called from categoryEdit form
        public bool updateCategory(Category.Category category)
        {
            bool result;
            if (category.ID != 0)
            {
                result = this.CategoryManager.updateCategory(this.loggedUser.email, this.loggedUser.password, category);
            }
            else
            {
                result = this.CategoryManager.createCategory(this.loggedUser.email, this.loggedUser.password, category);
            }
            if (result)
            {
                this.loadCategories();
            }
            else
            {
                MessageBox.Show("Errore all'aggiornameto/creazione della categoria");
            }
            return result;
        }

        //double click on category row and opens details form
        private void categoryClick(object sender, EventArgs e)
        {
            categoryEdit editCategoryForm = new categoryEdit(CategoryManager.getCategoryById(loggedUser.email, loggedUser.password,
                int.Parse(categoryListView.SelectedItems[0].SubItems[0].Text)), this);
            editCategoryForm.Show();
        }

        //double click on order row and opens details form
        private void orderClick(object sender, EventArgs e)
        {
            int orderId = int.Parse(ordersListView.SelectedItems[0].SubItems[0].Text);
            Order.Order order = orderManager.getOrderById(loggedUser.email, loggedUser.password, orderId);
            orderDetail detail = new orderDetail(order, this);
            detail.Show();
        }

        private void reloadOrdes(object sender, EventArgs e)
        {
            this.loadOrders();
        }

        // open order details and click on delete order button
        public bool deleteOrder(int ID)
        {

            return orderManager.deleteOrder(loggedUser.email, loggedUser.password, ID);
        }

        public Brand.Brand[] getBrands()
        {
            return this.BrandManager.getBrands(loggedUser.email, loggedUser.password);
        }

        public Category.Category[] getCategories()
        {
            return this.CategoryManager.getCategories(loggedUser.email, loggedUser.password);
        }

        //double click on product row and opens details form
        private void productClick(object sender, EventArgs e)
        {
            int productId = int.Parse(productListView.SelectedItems[0].SubItems[0].Text);
            Product.Product product = productManager.getProductById(productId, loggedUser.email, loggedUser.password);
            productEdit detail = new productEdit(product, this);
            detail.Show();
        }

        //if id is 0 then i'm going to create a new product. if id != 0 then i update the selected product
        public bool updateProduct(Product.Product product)
        {
            bool result;
            if (product.ID != 0)
            {
                result = this.productManager.updateProduct(this.loggedUser.email, this.loggedUser.password, product);
            }
            else
            {
                result = this.productManager.createProduct(this.loggedUser.email, this.loggedUser.password, product);
            }
            if (result)
            {
                this.loadProducts();
            }
            else
            {
                MessageBox.Show("Errore all'aggiornameto/creazione del prodotto");
            }
            return result;
        }

        //product create button
        private void createProduct_Click(object sender, EventArgs e)
        {
            //create empty product
            Product.Product newProduct = new Product.Product();
            newProduct.ID = 0;
            newProduct.brand = new Product.Brand();
            newProduct.brand.ID = 0;
            newProduct.category = new Product.Category();
            newProduct.category.ID = 0;
            productEdit editProductForm = new productEdit(newProduct, this);
            editProductForm.Show();
        }

        private void logoutTab(object sender, EventArgs e)
        {
            this.Close();
            login loginForm = new login();
            loginForm.Show();
        }
    }
}
