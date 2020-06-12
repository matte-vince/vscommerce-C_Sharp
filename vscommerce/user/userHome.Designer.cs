namespace vscommerce.user
{
    partial class userHome
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
            this.components = new System.ComponentModel.Container();
            this.tabs = new MaterialSkin.Controls.MaterialTabControl();
            this.products = new System.Windows.Forms.TabPage();
            this.productListView = new System.Windows.Forms.ListView();
            this.cart = new System.Windows.Forms.TabPage();
            this.totalPlaceHolder = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.clearCartButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.orderButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cartListView = new System.Windows.Forms.ListView();
            this.orders = new System.Windows.Forms.TabPage();
            this.ordersListView = new System.Windows.Forms.ListView();
            this.profile = new System.Windows.Forms.TabPage();
            this.updateUserButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.userBirthday = new System.Windows.Forms.DateTimePicker();
            this.userPassword2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.UserPassword1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.userEmailPlaceHolder = new MaterialSkin.Controls.MaterialLabel();
            this.userFiscalcode = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.userName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.userSurname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.logout = new System.Windows.Forms.TabPage();
            this.tabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.errorProviderApp = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabs.SuspendLayout();
            this.products.SuspendLayout();
            this.cart.SuspendLayout();
            this.orders.SuspendLayout();
            this.profile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).BeginInit();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.products);
            this.tabs.Controls.Add(this.cart);
            this.tabs.Controls.Add(this.orders);
            this.tabs.Controls.Add(this.profile);
            this.tabs.Controls.Add(this.logout);
            this.tabs.Depth = 0;
            this.tabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabs.Location = new System.Drawing.Point(2, 62);
            this.tabs.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(797, 387);
            this.tabs.TabIndex = 1;
            // 
            // products
            // 
            this.products.Controls.Add(this.productListView);
            this.products.Location = new System.Drawing.Point(4, 22);
            this.products.Name = "products";
            this.products.Padding = new System.Windows.Forms.Padding(3);
            this.products.Size = new System.Drawing.Size(789, 361);
            this.products.TabIndex = 0;
            this.products.Text = "Prodotti";
            this.products.UseVisualStyleBackColor = true;
            // 
            // productListView
            // 
            this.productListView.AllowColumnReorder = true;
            this.productListView.BackColor = System.Drawing.SystemColors.Window;
            this.productListView.BackgroundImageTiled = true;
            this.productListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.productListView.FullRowSelect = true;
            this.productListView.GridLines = true;
            this.productListView.HideSelection = false;
            this.productListView.HoverSelection = true;
            this.productListView.Location = new System.Drawing.Point(39, 85);
            this.productListView.MultiSelect = false;
            this.productListView.Name = "productListView";
            this.productListView.Size = new System.Drawing.Size(712, 275);
            this.productListView.TabIndex = 0;
            this.productListView.UseCompatibleStateImageBehavior = false;
            this.productListView.DoubleClick += new System.EventHandler(this.productClick);
            // 
            // cart
            // 
            this.cart.Controls.Add(this.totalPlaceHolder);
            this.cart.Controls.Add(this.materialLabel1);
            this.cart.Controls.Add(this.clearCartButton);
            this.cart.Controls.Add(this.orderButton);
            this.cart.Controls.Add(this.cartListView);
            this.cart.Location = new System.Drawing.Point(4, 22);
            this.cart.Name = "cart";
            this.cart.Padding = new System.Windows.Forms.Padding(3);
            this.cart.Size = new System.Drawing.Size(789, 361);
            this.cart.TabIndex = 1;
            this.cart.Text = "Carrello";
            this.cart.UseVisualStyleBackColor = true;
            // 
            // totalPlaceHolder
            // 
            this.totalPlaceHolder.Depth = 0;
            this.totalPlaceHolder.Font = new System.Drawing.Font("Roboto", 11F);
            this.totalPlaceHolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.totalPlaceHolder.Location = new System.Drawing.Point(335, 80);
            this.totalPlaceHolder.MouseState = MaterialSkin.MouseState.HOVER;
            this.totalPlaceHolder.Name = "totalPlaceHolder";
            this.totalPlaceHolder.Size = new System.Drawing.Size(110, 19);
            this.totalPlaceHolder.TabIndex = 6;
            this.totalPlaceHolder.Text = "0 €";
            this.totalPlaceHolder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(362, 61);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(52, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Totale";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // clearCartButton
            // 
            this.clearCartButton.Depth = 0;
            this.clearCartButton.Location = new System.Drawing.Point(490, 61);
            this.clearCartButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.clearCartButton.Name = "clearCartButton";
            this.clearCartButton.Primary = true;
            this.clearCartButton.Size = new System.Drawing.Size(172, 39);
            this.clearCartButton.TabIndex = 4;
            this.clearCartButton.Text = "Svuota carrello";
            this.clearCartButton.UseVisualStyleBackColor = true;
            this.clearCartButton.Click += new System.EventHandler(this.clearCartButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.Depth = 0;
            this.orderButton.Location = new System.Drawing.Point(115, 61);
            this.orderButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.orderButton.Name = "orderButton";
            this.orderButton.Primary = true;
            this.orderButton.Size = new System.Drawing.Size(172, 38);
            this.orderButton.TabIndex = 3;
            this.orderButton.Text = "ordina";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // cartListView
            // 
            this.cartListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.cartListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cartListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cartListView.FullRowSelect = true;
            this.cartListView.GridLines = true;
            this.cartListView.HideSelection = false;
            this.cartListView.Location = new System.Drawing.Point(59, 148);
            this.cartListView.Name = "cartListView";
            this.cartListView.Size = new System.Drawing.Size(672, 216);
            this.cartListView.TabIndex = 0;
            this.cartListView.UseCompatibleStateImageBehavior = false;
            // 
            // orders
            // 
            this.orders.Controls.Add(this.ordersListView);
            this.orders.Location = new System.Drawing.Point(4, 22);
            this.orders.Name = "orders";
            this.orders.Padding = new System.Windows.Forms.Padding(3);
            this.orders.Size = new System.Drawing.Size(789, 361);
            this.orders.TabIndex = 2;
            this.orders.Text = "Ordini";
            this.orders.UseVisualStyleBackColor = true;
            // 
            // ordersListView
            // 
            this.ordersListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ordersListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ordersListView.FullRowSelect = true;
            this.ordersListView.GridLines = true;
            this.ordersListView.HideSelection = false;
            this.ordersListView.Location = new System.Drawing.Point(54, 66);
            this.ordersListView.Name = "ordersListView";
            this.ordersListView.Size = new System.Drawing.Size(684, 295);
            this.ordersListView.TabIndex = 0;
            this.ordersListView.UseCompatibleStateImageBehavior = false;
            this.ordersListView.DoubleClick += new System.EventHandler(this.orderClick);
            // 
            // profile
            // 
            this.profile.BackColor = System.Drawing.Color.White;
            this.profile.Controls.Add(this.updateUserButton);
            this.profile.Controls.Add(this.materialLabel8);
            this.profile.Controls.Add(this.userBirthday);
            this.profile.Controls.Add(this.userPassword2);
            this.profile.Controls.Add(this.materialLabel7);
            this.profile.Controls.Add(this.materialLabel6);
            this.profile.Controls.Add(this.UserPassword1);
            this.profile.Controls.Add(this.userEmailPlaceHolder);
            this.profile.Controls.Add(this.userFiscalcode);
            this.profile.Controls.Add(this.materialLabel5);
            this.profile.Controls.Add(this.materialLabel3);
            this.profile.Controls.Add(this.userName);
            this.profile.Controls.Add(this.userSurname);
            this.profile.Controls.Add(this.materialLabel4);
            this.profile.Controls.Add(this.materialLabel2);
            this.profile.Location = new System.Drawing.Point(4, 22);
            this.profile.Name = "profile";
            this.profile.Padding = new System.Windows.Forms.Padding(3);
            this.profile.Size = new System.Drawing.Size(789, 361);
            this.profile.TabIndex = 3;
            this.profile.Text = "Profilo";
            // 
            // updateUserButton
            // 
            this.updateUserButton.Depth = 0;
            this.updateUserButton.Location = new System.Drawing.Point(478, 295);
            this.updateUserButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.updateUserButton.Name = "updateUserButton";
            this.updateUserButton.Primary = true;
            this.updateUserButton.Size = new System.Drawing.Size(200, 42);
            this.updateUserButton.TabIndex = 15;
            this.updateUserButton.Text = "aggiorna";
            this.updateUserButton.UseVisualStyleBackColor = true;
            this.updateUserButton.Click += new System.EventHandler(this.updateUserButton_Click);
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(474, 124);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(114, 19);
            this.materialLabel8.TabIndex = 14;
            this.materialLabel8.Text = "Data Di Nascita";
            // 
            // userBirthday
            // 
            this.userBirthday.Location = new System.Drawing.Point(478, 157);
            this.userBirthday.Name = "userBirthday";
            this.userBirthday.Size = new System.Drawing.Size(227, 20);
            this.userBirthday.TabIndex = 13;
            // 
            // userPassword2
            // 
            this.userPassword2.Depth = 0;
            this.userPassword2.Hint = "";
            this.userPassword2.Location = new System.Drawing.Point(478, 243);
            this.userPassword2.MouseState = MaterialSkin.MouseState.HOVER;
            this.userPassword2.Name = "userPassword2";
            this.userPassword2.PasswordChar = '\0';
            this.userPassword2.SelectedText = "";
            this.userPassword2.SelectionLength = 0;
            this.userPassword2.SelectionStart = 0;
            this.userPassword2.Size = new System.Drawing.Size(227, 23);
            this.userPassword2.TabIndex = 12;
            this.userPassword2.UseSystemPasswordChar = true;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(474, 221);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(145, 19);
            this.materialLabel7.TabIndex = 11;
            this.materialLabel7.Text = "Conferma Password";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(65, 221);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(75, 19);
            this.materialLabel6.TabIndex = 10;
            this.materialLabel6.Text = "Password";
            // 
            // UserPassword1
            // 
            this.UserPassword1.Depth = 0;
            this.UserPassword1.Hint = "";
            this.UserPassword1.Location = new System.Drawing.Point(69, 243);
            this.UserPassword1.MouseState = MaterialSkin.MouseState.HOVER;
            this.UserPassword1.Name = "UserPassword1";
            this.UserPassword1.PasswordChar = '*';
            this.UserPassword1.SelectedText = "";
            this.UserPassword1.SelectionLength = 0;
            this.UserPassword1.SelectionStart = 0;
            this.UserPassword1.Size = new System.Drawing.Size(242, 23);
            this.UserPassword1.TabIndex = 9;
            this.UserPassword1.UseSystemPasswordChar = true;
            // 
            // userEmailPlaceHolder
            // 
            this.userEmailPlaceHolder.AutoSize = true;
            this.userEmailPlaceHolder.Depth = 0;
            this.userEmailPlaceHolder.Font = new System.Drawing.Font("Roboto", 11F);
            this.userEmailPlaceHolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.userEmailPlaceHolder.Location = new System.Drawing.Point(65, 318);
            this.userEmailPlaceHolder.MouseState = MaterialSkin.MouseState.HOVER;
            this.userEmailPlaceHolder.Name = "userEmailPlaceHolder";
            this.userEmailPlaceHolder.Size = new System.Drawing.Size(0, 19);
            this.userEmailPlaceHolder.TabIndex = 8;
            // 
            // userFiscalcode
            // 
            this.userFiscalcode.Depth = 0;
            this.userFiscalcode.Hint = "";
            this.userFiscalcode.Location = new System.Drawing.Point(69, 154);
            this.userFiscalcode.MouseState = MaterialSkin.MouseState.HOVER;
            this.userFiscalcode.Name = "userFiscalcode";
            this.userFiscalcode.PasswordChar = '\0';
            this.userFiscalcode.SelectedText = "";
            this.userFiscalcode.SelectionLength = 0;
            this.userFiscalcode.SelectionStart = 0;
            this.userFiscalcode.Size = new System.Drawing.Size(242, 23);
            this.userFiscalcode.TabIndex = 7;
            this.userFiscalcode.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(68, 295);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(47, 19);
            this.materialLabel5.TabIndex = 6;
            this.materialLabel5.Text = "Email";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(65, 124);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(108, 19);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Codice Fiscale";
            // 
            // userName
            // 
            this.userName.Depth = 0;
            this.userName.Hint = "";
            this.userName.Location = new System.Drawing.Point(69, 62);
            this.userName.MouseState = MaterialSkin.MouseState.HOVER;
            this.userName.Name = "userName";
            this.userName.PasswordChar = '\0';
            this.userName.SelectedText = "";
            this.userName.SelectionLength = 0;
            this.userName.SelectionStart = 0;
            this.userName.Size = new System.Drawing.Size(242, 23);
            this.userName.TabIndex = 4;
            this.userName.UseSystemPasswordChar = false;
            // 
            // userSurname
            // 
            this.userSurname.Depth = 0;
            this.userSurname.Hint = "";
            this.userSurname.Location = new System.Drawing.Point(478, 62);
            this.userSurname.MouseState = MaterialSkin.MouseState.HOVER;
            this.userSurname.Name = "userSurname";
            this.userSurname.PasswordChar = '\0';
            this.userSurname.SelectedText = "";
            this.userSurname.SelectionLength = 0;
            this.userSurname.SelectionStart = 0;
            this.userSurname.Size = new System.Drawing.Size(227, 23);
            this.userSurname.TabIndex = 3;
            this.userSurname.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(474, 29);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(74, 19);
            this.materialLabel4.TabIndex = 2;
            this.materialLabel4.Text = "Cognome";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(65, 29);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(50, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Nome";
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(4, 22);
            this.logout.Name = "logout";
            this.logout.Padding = new System.Windows.Forms.Padding(3);
            this.logout.Size = new System.Drawing.Size(789, 361);
            this.logout.TabIndex = 4;
            this.logout.Text = "logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Enter += new System.EventHandler(this.logoutTab);
            // 
            // tabSelector
            // 
            this.tabSelector.BaseTabControl = this.tabs;
            this.tabSelector.Depth = 0;
            this.tabSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tabSelector.Location = new System.Drawing.Point(298, 25);
            this.tabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelector.Name = "tabSelector";
            this.tabSelector.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabSelector.Size = new System.Drawing.Size(501, 38);
            this.tabSelector.TabIndex = 3;
            this.tabSelector.Text = "materialTabSelector1";
            // 
            // errorProviderApp
            // 
            this.errorProviderApp.ContainerControl = this;
            // 
            // userHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabSelector);
            this.Controls.Add(this.tabs);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "userHome";
            this.Text = "userHome";
            this.Load += new System.EventHandler(this.userHome_Load);
            this.tabs.ResumeLayout(false);
            this.products.ResumeLayout(false);
            this.cart.ResumeLayout(false);
            this.cart.PerformLayout();
            this.orders.ResumeLayout(false);
            this.profile.ResumeLayout(false);
            this.profile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tabs;
        private System.Windows.Forms.TabPage products;
        private System.Windows.Forms.TabPage cart;
        private MaterialSkin.Controls.MaterialTabSelector tabSelector;
        private System.Windows.Forms.TabPage orders;
        private System.Windows.Forms.TabPage profile;
        private System.Windows.Forms.TabPage logout;
        private System.Windows.Forms.ListView productListView;
        private System.Windows.Forms.ListView cartListView;
        private MaterialSkin.Controls.MaterialRaisedButton clearCartButton;
        private MaterialSkin.Controls.MaterialRaisedButton orderButton;
        private MaterialSkin.Controls.MaterialLabel totalPlaceHolder;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ListView ordersListView;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField userName;
        private MaterialSkin.Controls.MaterialSingleLineTextField userSurname;
        private MaterialSkin.Controls.MaterialSingleLineTextField userFiscalcode;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField UserPassword1;
        private MaterialSkin.Controls.MaterialLabel userEmailPlaceHolder;
        private MaterialSkin.Controls.MaterialSingleLineTextField userPassword2;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialRaisedButton updateUserButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private System.Windows.Forms.DateTimePicker userBirthday;
        private System.Windows.Forms.ErrorProvider errorProviderApp;
    }
}