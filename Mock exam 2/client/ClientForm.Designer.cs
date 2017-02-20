﻿namespace client
{
    partial class ClientForm
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
            this.GetWebShopBtn = new System.Windows.Forms.Button();
            this.GetProductListBtn = new System.Windows.Forms.Button();
            this.GetProductInfoBtn = new System.Windows.Forms.Button();
            this.BuyProductBtn = new System.Windows.Forms.Button();
            this.idListBox = new System.Windows.Forms.ListBox();
            this.lblNotifications = new System.Windows.Forms.Label();
            this.priceListBox = new System.Windows.Forms.ListBox();
            this.stockListBox = new System.Windows.Forms.ListBox();
            this.idLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.stockLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GetWebShopBtn
            // 
            this.GetWebShopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetWebShopBtn.Location = new System.Drawing.Point(16, 15);
            this.GetWebShopBtn.Margin = new System.Windows.Forms.Padding(4);
            this.GetWebShopBtn.Name = "GetWebShopBtn";
            this.GetWebShopBtn.Size = new System.Drawing.Size(381, 57);
            this.GetWebShopBtn.TabIndex = 0;
            this.GetWebShopBtn.Text = "Get WebShop Name";
            this.GetWebShopBtn.UseVisualStyleBackColor = true;
            this.GetWebShopBtn.Click += new System.EventHandler(this.GetWebShopBtn_Click);
            // 
            // GetProductListBtn
            // 
            this.GetProductListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetProductListBtn.Location = new System.Drawing.Point(16, 327);
            this.GetProductListBtn.Margin = new System.Windows.Forms.Padding(4);
            this.GetProductListBtn.Name = "GetProductListBtn";
            this.GetProductListBtn.Size = new System.Drawing.Size(381, 57);
            this.GetProductListBtn.TabIndex = 1;
            this.GetProductListBtn.Text = "Get Product List";
            this.GetProductListBtn.UseVisualStyleBackColor = true;
            this.GetProductListBtn.Click += new System.EventHandler(this.GetProductListBtn_Click);
            // 
            // GetProductInfoBtn
            // 
            this.GetProductInfoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetProductInfoBtn.Location = new System.Drawing.Point(21, 63);
            this.GetProductInfoBtn.Margin = new System.Windows.Forms.Padding(4);
            this.GetProductInfoBtn.Name = "GetProductInfoBtn";
            this.GetProductInfoBtn.Size = new System.Drawing.Size(335, 57);
            this.GetProductInfoBtn.TabIndex = 2;
            this.GetProductInfoBtn.Text = "Get Product Info";
            this.GetProductInfoBtn.UseVisualStyleBackColor = true;
            this.GetProductInfoBtn.Click += new System.EventHandler(this.GetProductInfoBtn_Click);
            // 
            // BuyProductBtn
            // 
            this.BuyProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyProductBtn.Location = new System.Drawing.Point(16, 447);
            this.BuyProductBtn.Margin = new System.Windows.Forms.Padding(4);
            this.BuyProductBtn.Name = "BuyProductBtn";
            this.BuyProductBtn.Size = new System.Drawing.Size(381, 57);
            this.BuyProductBtn.TabIndex = 3;
            this.BuyProductBtn.Text = "Buy Product";
            this.BuyProductBtn.UseVisualStyleBackColor = true;
            this.BuyProductBtn.Click += new System.EventHandler(this.BuyProductBtn_Click);
            // 
            // idListBox
            // 
            this.idListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idListBox.FormattingEnabled = true;
            this.idListBox.ItemHeight = 36;
            this.idListBox.Location = new System.Drawing.Point(433, 267);
            this.idListBox.Margin = new System.Windows.Forms.Padding(4);
            this.idListBox.Name = "idListBox";
            this.idListBox.Size = new System.Drawing.Size(433, 256);
            this.idListBox.TabIndex = 6;
            // 
            // lblNotifications
            // 
            this.lblNotifications.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNotifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotifications.Location = new System.Drawing.Point(433, 22);
            this.lblNotifications.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotifications.Name = "lblNotifications";
            this.lblNotifications.Size = new System.Drawing.Size(761, 91);
            this.lblNotifications.TabIndex = 7;
            this.lblNotifications.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // priceListBox
            // 
            this.priceListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceListBox.FormattingEnabled = true;
            this.priceListBox.ItemHeight = 36;
            this.priceListBox.Location = new System.Drawing.Point(876, 267);
            this.priceListBox.Margin = new System.Windows.Forms.Padding(4);
            this.priceListBox.Name = "priceListBox";
            this.priceListBox.Size = new System.Drawing.Size(169, 256);
            this.priceListBox.TabIndex = 6;
            // 
            // stockListBox
            // 
            this.stockListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockListBox.FormattingEnabled = true;
            this.stockListBox.ItemHeight = 36;
            this.stockListBox.Location = new System.Drawing.Point(1055, 267);
            this.stockListBox.Margin = new System.Windows.Forms.Padding(4);
            this.stockListBox.Name = "stockListBox";
            this.stockListBox.Size = new System.Drawing.Size(139, 256);
            this.stockListBox.TabIndex = 6;
            // 
            // idLbl
            // 
            this.idLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLbl.Location = new System.Drawing.Point(433, 176);
            this.idLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(434, 64);
            this.idLbl.TabIndex = 7;
            this.idLbl.Text = "id";
            this.idLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // priceLbl
            // 
            this.priceLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLbl.Location = new System.Drawing.Point(876, 176);
            this.priceLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(170, 64);
            this.priceLbl.TabIndex = 7;
            this.priceLbl.Text = "price";
            this.priceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stockLbl
            // 
            this.stockLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stockLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockLbl.Location = new System.Drawing.Point(1055, 176);
            this.stockLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stockLbl.Name = "stockLbl";
            this.stockLbl.Size = new System.Drawing.Size(139, 64);
            this.stockLbl.TabIndex = 7;
            this.stockLbl.Text = "stock";
            this.stockLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbProductName);
            this.panel1.Controls.Add(this.GetProductInfoBtn);
            this.panel1.Location = new System.Drawing.Point(16, 133);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 140);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "product name:";
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(125, 22);
            this.tbProductName.Margin = new System.Windows.Forms.Padding(4);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(229, 22);
            this.tbProductName.TabIndex = 3;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 572);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.stockLbl);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.lblNotifications);
            this.Controls.Add(this.stockListBox);
            this.Controls.Add(this.priceListBox);
            this.Controls.Add(this.idListBox);
            this.Controls.Add(this.BuyProductBtn);
            this.Controls.Add(this.GetProductListBtn);
            this.Controls.Add(this.GetWebShopBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClientForm";
            this.Text = "WebshopClient";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClientForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GetWebShopBtn;
        private System.Windows.Forms.Button GetProductListBtn;
        private System.Windows.Forms.Button GetProductInfoBtn;
        private System.Windows.Forms.Button BuyProductBtn;
        private System.Windows.Forms.ListBox idListBox;
        private System.Windows.Forms.Label lblNotifications;
        private System.Windows.Forms.ListBox priceListBox;
        private System.Windows.Forms.ListBox stockListBox;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label stockLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbProductName;
    }
}

