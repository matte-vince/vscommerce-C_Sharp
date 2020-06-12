namespace vscommerce.admin
{
    partial class orderDetail
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
            this.orderLineListView = new System.Windows.Forms.ListView();
            this.totalPlaceHolder = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.datePlaceHolder = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.IDOrderPlaceHolder = new MaterialSkin.Controls.MaterialLabel();
            this.customerPlaceHolder = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.deleteOrder = new MaterialSkin.Controls.MaterialRaisedButton();
            this.closeButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // orderLineListView
            // 
            this.orderLineListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderLineListView.GridLines = true;
            this.orderLineListView.HideSelection = false;
            this.orderLineListView.Location = new System.Drawing.Point(25, 215);
            this.orderLineListView.Name = "orderLineListView";
            this.orderLineListView.Size = new System.Drawing.Size(506, 164);
            this.orderLineListView.TabIndex = 17;
            this.orderLineListView.UseCompatibleStateImageBehavior = false;
            // 
            // totalPlaceHolder
            // 
            this.totalPlaceHolder.AutoSize = true;
            this.totalPlaceHolder.Depth = 0;
            this.totalPlaceHolder.Font = new System.Drawing.Font("Roboto", 11F);
            this.totalPlaceHolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.totalPlaceHolder.Location = new System.Drawing.Point(355, 163);
            this.totalPlaceHolder.MouseState = MaterialSkin.MouseState.HOVER;
            this.totalPlaceHolder.Name = "totalPlaceHolder";
            this.totalPlaceHolder.Size = new System.Drawing.Size(108, 19);
            this.totalPlaceHolder.TabIndex = 16;
            this.totalPlaceHolder.Text = "materialLabel5";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(355, 144);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(52, 19);
            this.materialLabel4.TabIndex = 15;
            this.materialLabel4.Text = "Totale";
            // 
            // datePlaceHolder
            // 
            this.datePlaceHolder.AutoSize = true;
            this.datePlaceHolder.Depth = 0;
            this.datePlaceHolder.Font = new System.Drawing.Font("Roboto", 11F);
            this.datePlaceHolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.datePlaceHolder.Location = new System.Drawing.Point(52, 163);
            this.datePlaceHolder.MouseState = MaterialSkin.MouseState.HOVER;
            this.datePlaceHolder.Name = "datePlaceHolder";
            this.datePlaceHolder.Size = new System.Drawing.Size(108, 19);
            this.datePlaceHolder.TabIndex = 14;
            this.datePlaceHolder.Text = "materialLabel4";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(52, 144);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(87, 19);
            this.materialLabel2.TabIndex = 13;
            this.materialLabel2.Text = "Data Ordine";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.White;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(355, 78);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(56, 19);
            this.materialLabel3.TabIndex = 12;
            this.materialLabel3.Text = "Cliente";
            // 
            // IDOrderPlaceHolder
            // 
            this.IDOrderPlaceHolder.AutoSize = true;
            this.IDOrderPlaceHolder.BackColor = System.Drawing.Color.White;
            this.IDOrderPlaceHolder.Depth = 0;
            this.IDOrderPlaceHolder.Font = new System.Drawing.Font("Roboto", 11F);
            this.IDOrderPlaceHolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.IDOrderPlaceHolder.Location = new System.Drawing.Point(52, 97);
            this.IDOrderPlaceHolder.MouseState = MaterialSkin.MouseState.HOVER;
            this.IDOrderPlaceHolder.Name = "IDOrderPlaceHolder";
            this.IDOrderPlaceHolder.Size = new System.Drawing.Size(108, 19);
            this.IDOrderPlaceHolder.TabIndex = 11;
            this.IDOrderPlaceHolder.Text = "materialLabel2";
            // 
            // customerPlaceHolder
            // 
            this.customerPlaceHolder.AutoSize = true;
            this.customerPlaceHolder.Depth = 0;
            this.customerPlaceHolder.Font = new System.Drawing.Font("Roboto", 11F);
            this.customerPlaceHolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.customerPlaceHolder.Location = new System.Drawing.Point(357, 97);
            this.customerPlaceHolder.MouseState = MaterialSkin.MouseState.HOVER;
            this.customerPlaceHolder.Name = "customerPlaceHolder";
            this.customerPlaceHolder.Size = new System.Drawing.Size(54, 19);
            this.customerPlaceHolder.TabIndex = 10;
            this.customerPlaceHolder.Text = "cliente";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.White;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(52, 78);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(69, 19);
            this.materialLabel1.TabIndex = 9;
            this.materialLabel1.Text = "ID ordine";
            // 
            // deleteOrder
            // 
            this.deleteOrder.Depth = 0;
            this.deleteOrder.Location = new System.Drawing.Point(387, 417);
            this.deleteOrder.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteOrder.Name = "deleteOrder";
            this.deleteOrder.Primary = true;
            this.deleteOrder.Size = new System.Drawing.Size(144, 37);
            this.deleteOrder.TabIndex = 18;
            this.deleteOrder.Text = "elimina ordine";
            this.deleteOrder.UseVisualStyleBackColor = true;
            this.deleteOrder.Click += new System.EventHandler(this.deleteOrderClick);
            // 
            // closeButton
            // 
            this.closeButton.Depth = 0;
            this.closeButton.Location = new System.Drawing.Point(232, 418);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.closeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.closeButton.Name = "closeButton";
            this.closeButton.Primary = false;
            this.closeButton.Size = new System.Drawing.Size(144, 36);
            this.closeButton.TabIndex = 19;
            this.closeButton.Text = "annulla";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeClick);
            // 
            // orderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 480);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.deleteOrder);
            this.Controls.Add(this.orderLineListView);
            this.Controls.Add(this.totalPlaceHolder);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.datePlaceHolder);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.IDOrderPlaceHolder);
            this.Controls.Add(this.customerPlaceHolder);
            this.Controls.Add(this.materialLabel1);
            this.Name = "orderDetail";
            this.Text = "orderDetail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView orderLineListView;
        private MaterialSkin.Controls.MaterialLabel totalPlaceHolder;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel datePlaceHolder;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel IDOrderPlaceHolder;
        private MaterialSkin.Controls.MaterialLabel customerPlaceHolder;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton deleteOrder;
        private MaterialSkin.Controls.MaterialFlatButton closeButton;
    }
}