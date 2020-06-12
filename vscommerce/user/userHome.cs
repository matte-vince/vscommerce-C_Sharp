using MaterialSkin;
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
using vscommerce.Product;
using vscommerce.Order;
using vscommerce.User;
using System.Text.RegularExpressions;

namespace vscommerce.user
{
    public partial class userHome : MaterialForm
    {
        private User.User loggedUser;
        private ProductManagerClient productManager;
        private OrderManagerClient orderManager;
        private UserManagerClient userManager;
        public userHome(User.User loggedUser)
        {
            this.loggedUser = loggedUser;
            this.productManager = new ProductManagerClient();
            this.orderManager = new OrderManagerClient();
            this.userManager = new UserManagerClient();

            InitializeComponent();
            this.Text = "Ciao " + this.loggedUser.name;

            MaterialSkinManager materialUIManager = MaterialSkinManager.Instance;
            materialUIManager.AddFormToManage(this);
            materialUIManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialUIManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.Orange200,
                TextShade.WHITE
                );

            productListView.Clear();
            productListView.View = View.Details;
            productListView.Columns.Add("ID", 150, HorizontalAlignment.Left);
            productListView.Columns.Add("Nome", 250, HorizontalAlignment.Left);
            productListView.Columns.Add("Barcode", 200, HorizontalAlignment.Left);
            productListView.Columns.Add("prezzo", 150, HorizontalAlignment.Left);


            cartListView.View = View.Details;
            cartListView.Columns.Add("ID", 150, HorizontalAlignment.Left);
            cartListView.Columns.Add("Prodotto", 300, HorizontalAlignment.Left);
            cartListView.Columns.Add("prezzo", 200, HorizontalAlignment.Left);
            cartListView.Columns.Add("Quantita", 200, HorizontalAlignment.Left);

            ordersListView.View = View.Details;
            ordersListView.Columns.Add("ID", 150, HorizontalAlignment.Left);
            ordersListView.Columns.Add("Data Ordine", 300, HorizontalAlignment.Center);
            ordersListView.Columns.Add("Totale", 200, HorizontalAlignment.Left);

            this.loadProducts();
            this.loadOrders();
            this.loadProfile();
        } 

        //load product list
        private void loadProducts()
        {
            productListView.Items.Clear();

            try
            {
                var products = this.productManager.getProducts(this.loggedUser.email, this.loggedUser.password);
                foreach (var p in products)
                {
                    productListView.Items.Add(new ListViewItem(new string[] {p.ID.ToString(), p.name, p.barcode, p.price.ToString() }));
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco ad aggiornare la lista delle macchine.", MessageBoxButtons.OK);
            }
            productListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            productListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        //load order list
        private void loadOrders()
        {
            ordersListView.Items.Clear();

            try
            {
                var orders = this.orderManager.getOrdersByPartner(this.loggedUser.email, this.loggedUser.password, this.loggedUser.ID);
                foreach (var order in orders)
                {
                    ordersListView.Items.Add(new ListViewItem(new string[] { order.ID.ToString(), order.date.ToString(), order.total.ToString()}));
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco ad aggiornare la lista delle macchine.", MessageBoxButtons.OK);
            }
            ordersListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            ordersListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        //load profile fields
        private void loadProfile()
        {
            userName.Text = loggedUser.name;
            userSurname.Text = loggedUser.surname;
            userFiscalcode.Text = loggedUser.fiscalCode;
            userEmailPlaceHolder.Text = loggedUser.email;
            userBirthday.Value = loggedUser.birthday;
        }


        private void userHome_Load(object sender, EventArgs e)
        {
            
        }

        //double click on product row and open product detail window  
        private void productClick(object sender, EventArgs e)
        {
            int productId = int.Parse(productListView.SelectedItems[0].SubItems[0].Text);
            Product.Product product = productManager.getProductById(productId, loggedUser.email, loggedUser.password);
            productDetail detail = new productDetail(product, loggedUser, this);
            detail.Show();
        }

        //add product to cart
        public void addToCart(Product.Product product)
        {
            //increase product qty or create new cart row
            bool found = false;
            foreach(ListViewItem item in cartListView.Items)
            {
                if(item.SubItems[0].Text == product.ID.ToString())
                {
                    found = true;
                    int updatedQty = int.Parse(item.SubItems[3].Text);
                    updatedQty++;
                    item.SubItems[3].Text = updatedQty.ToString();
                }
            }
            if (!found)
            {
                cartListView.Items.Add(new ListViewItem(new string[] { product.ID.ToString(), product.name, product.price.ToString(), "1"}));

            }
            this.computeCartTotal();
            cartListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            cartListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }


        //create order with orderlines
        private void orderButton_Click(object sender, EventArgs e)
        {
            Order.Order newOrder = new Order.Order();
            Order.User customer = new Order.User();
            customer.ID = this.loggedUser.ID;
            newOrder.date = DateTime.Now;
            newOrder.total = double.Parse(totalPlaceHolder.Text);
            newOrder.customer = customer;

            OrderLine[] orderLines = new OrderLine[cartListView.Items.Count];
            
            for (int i = 0; i < cartListView.Items.Count; i++)
            {
                Order.OrderLine line = new Order.OrderLine();
                Order.Product cartPoduct = new Order.Product();
                cartPoduct.ID = int.Parse(cartListView.Items[i].SubItems[0].Text);
                line.product = cartPoduct;
                line.qty = int.Parse(cartListView.Items[i].SubItems[3].Text);
                line.priceUnit = double.Parse(cartListView.Items[i].SubItems[2].Text);
                orderLines[i] = line;
            }
            if(orderManager.createOrder(loggedUser.email, loggedUser.password, newOrder, orderLines))
            {
                cartListView.Clear();
                totalPlaceHolder.Text = "0";
                this.loadOrders();
            }
            
        }


        //clear cart
        private void clearCartButton_Click(object sender, EventArgs e)
        {
           
            cartListView.Clear();
        }

        private void computeCartTotal()
        {
            double total = 0;
            foreach (ListViewItem item in cartListView.Items)
            {
                int qty = int.Parse(item.SubItems[3].Text);
                double price = Double.Parse(item.SubItems[2].Text);
                total += qty * price;
            }

            totalPlaceHolder.Text = total.ToString();
        }

        private void updateUserButton_Click(object sender, EventArgs e)
        {
            if (this.userProfileValidation())
            {
                
                if (string.IsNullOrWhiteSpace(UserPassword1.Text) && string.IsNullOrWhiteSpace(userPassword2.Text))
                {
                    User.User updateUser = new User.User();
                    updateUser.ID = loggedUser.ID;
                    updateUser.email = loggedUser.email;
                    updateUser.password = null;
                    updateUser.name = userName.Text;
                    updateUser.surname = userSurname.Text;
                    updateUser.isAdmin = false;
                    updateUser.fiscalCode = userFiscalcode.Text;
                    updateUser.birthday = userBirthday.Value;
                    if (userManager.updateUser(updateUser))
                    {
                        MessageBox.Show("Profilo aggiornato con successo.");
                    }
                    else
                    {
                        MessageBox.Show("Errore durante l'aggiornamento del profilo.");
                    }
                }
                else
                {
                    if(UserPassword1.Text == userPassword2.Text)
                    {
                        User.User updateUser = new User.User();
                        updateUser.ID = loggedUser.ID;
                        updateUser.email = loggedUser.email;
                        updateUser.password = GenerateMd5Hash(UserPassword1.Text);
                        updateUser.name = userName.Text;
                        updateUser.surname = userSurname.Text;
                        updateUser.isAdmin = false;
                        updateUser.fiscalCode = userFiscalcode.Text;
                        updateUser.birthday = userBirthday.Value;
                        if (userManager.updateUser(updateUser))
                        {
                            MessageBox.Show("Profilo aggiornato con successo.");
                        }
                        else
                        {
                            MessageBox.Show("Errore durante l'aggiornamento del profilo.");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Le password non combaciano");
                    }
                }
            }
            


        }

        private bool userProfileValidation()
        {
            
            if (string.IsNullOrWhiteSpace(userName.Text))
            {
                errorProviderApp.SetError(userName, "Non hai compilato il nome");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(userSurname.Text))
            {
                errorProviderApp.SetError(userSurname, "Non hai compilato il cognome");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(userFiscalcode.Text) || !Regex.IsMatch(userFiscalcode.Text.ToUpper() , @"^[A-Z]{6}[0-9]{2}[A-Z][0-9]{2}[A-Z][0-9]{3}[A-Z]$"))
            {
                errorProviderApp.SetError(userFiscalcode, "Non hai compilato il codice fiscale");
                return false;
            }
            else
            {
                return true;
                
            }
        }

        private static string GenerateMd5Hash(string input)
        {
            var x = new System.Security.Cryptography.MD5CryptoServiceProvider();
            var computeHash = System.Text.Encoding.UTF8.GetBytes(input);
            computeHash = x.ComputeHash(computeHash);
            var stringBuilder = new System.Text.StringBuilder();
            foreach (var str in computeHash)
            {
                stringBuilder.Append(str.ToString("x2").ToLower());
            }
            return stringBuilder.ToString();
        }

        private void logoutTab(object sender, EventArgs e)
        {
            this.Close();
            login loginForm = new login(); 
            loginForm.Show();
        }

        // double click on order row. opens order details and orderlines
        private void orderClick(object sender, EventArgs e)
        {
            int orderId = int.Parse(ordersListView.SelectedItems[0].SubItems[0].Text);
            Order.Order order = orderManager.getOrderById(loggedUser.email, loggedUser.password, orderId);
            orderDetailForm detail = new orderDetailForm(order);
            detail.Show();
        }
    }
}
