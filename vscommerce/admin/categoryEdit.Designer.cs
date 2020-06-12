namespace vscommerce.admin
{
    partial class categoryEdit
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
            this.update = new MaterialSkin.Controls.MaterialRaisedButton();
            this.categoryName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.idPlaceHolder = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // update
            // 
            this.update.Depth = 0;
            this.update.Location = new System.Drawing.Point(53, 242);
            this.update.MouseState = MaterialSkin.MouseState.HOVER;
            this.update.Name = "update";
            this.update.Primary = true;
            this.update.Size = new System.Drawing.Size(238, 40);
            this.update.TabIndex = 9;
            this.update.Text = "crea/aggiorna";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // categoryName
            // 
            this.categoryName.BackColor = System.Drawing.Color.White;
            this.categoryName.Depth = 0;
            this.categoryName.Hint = "";
            this.categoryName.Location = new System.Drawing.Point(52, 178);
            this.categoryName.MouseState = MaterialSkin.MouseState.HOVER;
            this.categoryName.Name = "categoryName";
            this.categoryName.PasswordChar = '\0';
            this.categoryName.SelectedText = "";
            this.categoryName.SelectionLength = 0;
            this.categoryName.SelectionStart = 0;
            this.categoryName.Size = new System.Drawing.Size(238, 23);
            this.categoryName.TabIndex = 8;
            this.categoryName.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.White;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(49, 156);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(119, 19);
            this.materialLabel3.TabIndex = 7;
            this.materialLabel3.Text = "Nome Categoria";
            // 
            // idPlaceHolder
            // 
            this.idPlaceHolder.AutoSize = true;
            this.idPlaceHolder.BackColor = System.Drawing.Color.White;
            this.idPlaceHolder.Depth = 0;
            this.idPlaceHolder.Font = new System.Drawing.Font("Roboto", 11F);
            this.idPlaceHolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.idPlaceHolder.Location = new System.Drawing.Point(49, 109);
            this.idPlaceHolder.MouseState = MaterialSkin.MouseState.HOVER;
            this.idPlaceHolder.Name = "idPlaceHolder";
            this.idPlaceHolder.Size = new System.Drawing.Size(17, 19);
            this.idPlaceHolder.TabIndex = 6;
            this.idPlaceHolder.Text = "0";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.White;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(50, 91);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(22, 18);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "ID";
            // 
            // categoryEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 306);
            this.Controls.Add(this.update);
            this.Controls.Add(this.categoryName);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.idPlaceHolder);
            this.Controls.Add(this.materialLabel1);
            this.Name = "categoryEdit";
            this.Text = "Modifica/Crea categoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton update;
        private MaterialSkin.Controls.MaterialSingleLineTextField categoryName;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel idPlaceHolder;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}