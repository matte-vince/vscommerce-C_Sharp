namespace vscommerce.admin
{
    partial class brandEdit
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.idPlaceHolder = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.brandName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.update = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.White;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(48, 86);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(23, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "ID";
            // 
            // idPlaceHolder
            // 
            this.idPlaceHolder.AutoSize = true;
            this.idPlaceHolder.BackColor = System.Drawing.Color.White;
            this.idPlaceHolder.Depth = 0;
            this.idPlaceHolder.Font = new System.Drawing.Font("Roboto", 11F);
            this.idPlaceHolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.idPlaceHolder.Location = new System.Drawing.Point(48, 105);
            this.idPlaceHolder.MouseState = MaterialSkin.MouseState.HOVER;
            this.idPlaceHolder.Name = "idPlaceHolder";
            this.idPlaceHolder.Size = new System.Drawing.Size(17, 19);
            this.idPlaceHolder.TabIndex = 1;
            this.idPlaceHolder.Text = "0";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.White;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(48, 151);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(93, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "nome marca";
            // 
            // brandName
            // 
            this.brandName.BackColor = System.Drawing.Color.White;
            this.brandName.Depth = 0;
            this.brandName.Hint = "";
            this.brandName.Location = new System.Drawing.Point(52, 176);
            this.brandName.MouseState = MaterialSkin.MouseState.HOVER;
            this.brandName.Name = "brandName";
            this.brandName.PasswordChar = '\0';
            this.brandName.SelectedText = "";
            this.brandName.SelectionLength = 0;
            this.brandName.SelectionStart = 0;
            this.brandName.Size = new System.Drawing.Size(238, 23);
            this.brandName.TabIndex = 3;
            this.brandName.UseSystemPasswordChar = false;
            // 
            // update
            // 
            this.update.Depth = 0;
            this.update.Location = new System.Drawing.Point(55, 233);
            this.update.MouseState = MaterialSkin.MouseState.HOVER;
            this.update.Name = "update";
            this.update.Primary = true;
            this.update.Size = new System.Drawing.Size(235, 40);
            this.update.TabIndex = 4;
            this.update.Text = "crea/aggiorna";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // brandEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 306);
            this.Controls.Add(this.update);
            this.Controls.Add(this.brandName);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.idPlaceHolder);
            this.Controls.Add(this.materialLabel1);
            this.Name = "brandEdit";
            this.Text = "Modifica Marca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel idPlaceHolder;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField brandName;
        private MaterialSkin.Controls.MaterialRaisedButton update;
    }
}