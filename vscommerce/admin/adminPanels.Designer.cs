namespace vscommerce.admin
{
    partial class adminPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabs = new MaterialSkin.Controls.MaterialTabControl();
            this.products = new System.Windows.Forms.TabPage();
            this.createProduct = new MaterialSkin.Controls.MaterialRaisedButton();
            this.productCounter = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.productListView = new System.Windows.Forms.ListView();
            this.brandCategories = new System.Windows.Forms.TabPage();
            this.createCategory = new MaterialSkin.Controls.MaterialRaisedButton();
            this.createBrand = new MaterialSkin.Controls.MaterialRaisedButton();
            this.categoryListView = new System.Windows.Forms.ListView();
            this.brandListView = new System.Windows.Forms.ListView();
            this.orders = new System.Windows.Forms.TabPage();
            this.updateOrderList = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ordersCounter = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.ordersListView = new System.Windows.Forms.ListView();
            this.customers = new System.Windows.Forms.TabPage();
            this.customerListView = new System.Windows.Forms.ListView();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.logout = new System.Windows.Forms.TabPage();
            this.tabs.SuspendLayout();
            this.products.SuspendLayout();
            this.brandCategories.SuspendLayout();
            this.orders.SuspendLayout();
            this.customers.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.products);
            this.tabs.Controls.Add(this.brandCategories);
            this.tabs.Controls.Add(this.orders);
            this.tabs.Controls.Add(this.customers);
            this.tabs.Controls.Add(this.logout);
            this.tabs.Depth = 0;
            this.tabs.Location = new System.Drawing.Point(-1, 64);
            this.tabs.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(800, 385);
            this.tabs.TabIndex = 0;
            // 
            // products
            // 
            this.products.Controls.Add(this.createProduct);
            this.products.Controls.Add(this.productCounter);
            this.products.Controls.Add(this.materialLabel1);
            this.products.Controls.Add(this.productListView);
            this.products.Location = new System.Drawing.Point(4, 22);
            this.products.Name = "products";
            this.products.Padding = new System.Windows.Forms.Padding(3);
            this.products.Size = new System.Drawing.Size(792, 359);
            this.products.TabIndex = 0;
            this.products.Text = "prodotti";
            this.products.UseVisualStyleBackColor = true;
            // 
            // createProduct
            // 
            this.createProduct.Depth = 0;
            this.createProduct.Location = new System.Drawing.Point(518, 44);
            this.createProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.createProduct.Name = "createProduct";
            this.createProduct.Primary = true;
            this.createProduct.Size = new System.Drawing.Size(178, 37);
            this.createProduct.TabIndex = 4;
            this.createProduct.Text = "aggiungi prodotto";
            this.createProduct.UseVisualStyleBackColor = true;
            this.createProduct.Click += new System.EventHandler(this.createProduct_Click);
            // 
            // productCounter
            // 
            this.productCounter.AutoSize = true;
            this.productCounter.Depth = 0;
            this.productCounter.Font = new System.Drawing.Font("Roboto", 11F);
            this.productCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.productCounter.Location = new System.Drawing.Point(87, 62);
            this.productCounter.MouseState = MaterialSkin.MouseState.HOVER;
            this.productCounter.Name = "productCounter";
            this.productCounter.Size = new System.Drawing.Size(17, 19);
            this.productCounter.TabIndex = 3;
            this.productCounter.Text = "0";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(87, 43);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(121, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Numero Prodotti";
            // 
            // productListView
            // 
            this.productListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.productListView.FullRowSelect = true;
            this.productListView.GridLines = true;
            this.productListView.HideSelection = false;
            this.productListView.Location = new System.Drawing.Point(52, 114);
            this.productListView.Name = "productListView";
            this.productListView.Size = new System.Drawing.Size(700, 245);
            this.productListView.TabIndex = 1;
            this.productListView.UseCompatibleStateImageBehavior = false;
            this.productListView.DoubleClick += new System.EventHandler(this.productClick);
            // 
            // brandCategories
            // 
            this.brandCategories.Controls.Add(this.createCategory);
            this.brandCategories.Controls.Add(this.createBrand);
            this.brandCategories.Controls.Add(this.categoryListView);
            this.brandCategories.Controls.Add(this.brandListView);
            this.brandCategories.Location = new System.Drawing.Point(4, 22);
            this.brandCategories.Name = "brandCategories";
            this.brandCategories.Padding = new System.Windows.Forms.Padding(3);
            this.brandCategories.Size = new System.Drawing.Size(792, 359);
            this.brandCategories.TabIndex = 1;
            this.brandCategories.Text = "marche e categorie";
            this.brandCategories.UseVisualStyleBackColor = true;
            // 
            // createCategory
            // 
            this.createCategory.Depth = 0;
            this.createCategory.Location = new System.Drawing.Point(499, 52);
            this.createCategory.MouseState = MaterialSkin.MouseState.HOVER;
            this.createCategory.Name = "createCategory";
            this.createCategory.Primary = true;
            this.createCategory.Size = new System.Drawing.Size(177, 43);
            this.createCategory.TabIndex = 3;
            this.createCategory.Text = "aggiungi categoria";
            this.createCategory.UseVisualStyleBackColor = true;
            this.createCategory.Click += new System.EventHandler(this.createCategory_Click);
            // 
            // createBrand
            // 
            this.createBrand.Depth = 0;
            this.createBrand.Location = new System.Drawing.Point(114, 52);
            this.createBrand.MouseState = MaterialSkin.MouseState.HOVER;
            this.createBrand.Name = "createBrand";
            this.createBrand.Primary = true;
            this.createBrand.Size = new System.Drawing.Size(178, 43);
            this.createBrand.TabIndex = 2;
            this.createBrand.Text = "aggiungi marca";
            this.createBrand.UseVisualStyleBackColor = true;
            this.createBrand.Click += new System.EventHandler(this.createBrand_Click);
            // 
            // categoryListView
            // 
            this.categoryListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.categoryListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.categoryListView.FullRowSelect = true;
            this.categoryListView.GridLines = true;
            this.categoryListView.HideSelection = false;
            this.categoryListView.Location = new System.Drawing.Point(441, 123);
            this.categoryListView.Name = "categoryListView";
            this.categoryListView.Size = new System.Drawing.Size(283, 235);
            this.categoryListView.TabIndex = 1;
            this.categoryListView.UseCompatibleStateImageBehavior = false;
            this.categoryListView.DoubleClick += new System.EventHandler(this.categoryClick);
            // 
            // brandListView
            // 
            this.brandListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.brandListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.brandListView.FullRowSelect = true;
            this.brandListView.GridLines = true;
            this.brandListView.HideSelection = false;
            this.brandListView.Location = new System.Drawing.Point(66, 124);
            this.brandListView.Name = "brandListView";
            this.brandListView.Size = new System.Drawing.Size(283, 235);
            this.brandListView.TabIndex = 0;
            this.brandListView.UseCompatibleStateImageBehavior = false;
            this.brandListView.DoubleClick += new System.EventHandler(this.brandClick);
            // 
            // orders
            // 
            this.orders.Controls.Add(this.updateOrderList);
            this.orders.Controls.Add(this.ordersCounter);
            this.orders.Controls.Add(this.materialLabel2);
            this.orders.Controls.Add(this.ordersListView);
            this.orders.Location = new System.Drawing.Point(4, 22);
            this.orders.Name = "orders";
            this.orders.Padding = new System.Windows.Forms.Padding(3);
            this.orders.Size = new System.Drawing.Size(792, 359);
            this.orders.TabIndex = 2;
            this.orders.Text = "ordini";
            this.orders.UseVisualStyleBackColor = true;
            // 
            // updateOrderList
            // 
            this.updateOrderList.Depth = 0;
            this.updateOrderList.Location = new System.Drawing.Point(514, 29);
            this.updateOrderList.MouseState = MaterialSkin.MouseState.HOVER;
            this.updateOrderList.Name = "updateOrderList";
            this.updateOrderList.Primary = true;
            this.updateOrderList.Size = new System.Drawing.Size(170, 37);
            this.updateOrderList.TabIndex = 3;
            this.updateOrderList.Text = "aggiorna lista ordini";
            this.updateOrderList.UseVisualStyleBackColor = true;
            this.updateOrderList.Click += new System.EventHandler(this.reloadOrdes);
            // 
            // ordersCounter
            // 
            this.ordersCounter.AutoSize = true;
            this.ordersCounter.Depth = 0;
            this.ordersCounter.Font = new System.Drawing.Font("Roboto", 11F);
            this.ordersCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ordersCounter.Location = new System.Drawing.Point(86, 48);
            this.ordersCounter.MouseState = MaterialSkin.MouseState.HOVER;
            this.ordersCounter.Name = "ordersCounter";
            this.ordersCounter.Size = new System.Drawing.Size(17, 19);
            this.ordersCounter.TabIndex = 2;
            this.ordersCounter.Text = "0";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(86, 29);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(171, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Numero Ordini effettuati";
            // 
            // ordersListView
            // 
            this.ordersListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ordersListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ordersListView.FullRowSelect = true;
            this.ordersListView.GridLines = true;
            this.ordersListView.HideSelection = false;
            this.ordersListView.Location = new System.Drawing.Point(57, 99);
            this.ordersListView.Name = "ordersListView";
            this.ordersListView.Size = new System.Drawing.Size(672, 263);
            this.ordersListView.TabIndex = 0;
            this.ordersListView.UseCompatibleStateImageBehavior = false;
            this.ordersListView.DoubleClick += new System.EventHandler(this.orderClick);
            // 
            // customers
            // 
            this.customers.Controls.Add(this.customerListView);
            this.customers.Location = new System.Drawing.Point(4, 22);
            this.customers.Name = "customers";
            this.customers.Padding = new System.Windows.Forms.Padding(3);
            this.customers.Size = new System.Drawing.Size(792, 359);
            this.customers.TabIndex = 3;
            this.customers.Text = "clienti";
            this.customers.UseVisualStyleBackColor = true;
            // 
            // customerListView
            // 
            this.customerListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.customerListView.FullRowSelect = true;
            this.customerListView.GridLines = true;
            this.customerListView.HideSelection = false;
            this.customerListView.Location = new System.Drawing.Point(37, 96);
            this.customerListView.Name = "customerListView";
            this.customerListView.Size = new System.Drawing.Size(716, 262);
            this.customerListView.TabIndex = 0;
            this.customerListView.UseCompatibleStateImageBehavior = false;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.tabs;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(227, 24);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(572, 38);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(4, 22);
            this.logout.Name = "logout";
            this.logout.Padding = new System.Windows.Forms.Padding(3);
            this.logout.Size = new System.Drawing.Size(792, 359);
            this.logout.TabIndex = 4;
            this.logout.Text = "LOGOUT";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Enter += new System.EventHandler(this.logoutTab);
            // 
            // adminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.tabs);
            this.Name = "adminPanel";
            this.Text = "adminPanels";
            this.tabs.ResumeLayout(false);
            this.products.ResumeLayout(false);
            this.products.PerformLayout();
            this.brandCategories.ResumeLayout(false);
            this.orders.ResumeLayout(false);
            this.orders.PerformLayout();
            this.customers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tabs;
        private System.Windows.Forms.TabPage products;
        private System.Windows.Forms.TabPage brandCategories;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.TabPage orders;
        private MaterialSkin.Controls.MaterialRaisedButton createProduct;
        private MaterialSkin.Controls.MaterialLabel productCounter;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ListView productListView;
        private MaterialSkin.Controls.MaterialRaisedButton createCategory;
        private MaterialSkin.Controls.MaterialRaisedButton createBrand;
        private System.Windows.Forms.ListView categoryListView;
        private System.Windows.Forms.ListView brandListView;
        private System.Windows.Forms.ListView ordersListView;
        private System.Windows.Forms.TabPage customers;
        private System.Windows.Forms.ListView customerListView;
        private MaterialSkin.Controls.MaterialRaisedButton updateOrderList;
        private MaterialSkin.Controls.MaterialLabel ordersCounter;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.TabPage logout;
    }
}