namespace MobileShopManagementSystem
{
    partial class SellingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellingForm));
            this.MobileGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.AccessoriesGridView = new System.Windows.Forms.DataGridView();
            this.Exit = new System.Windows.Forms.Label();
            this.QuantityField = new System.Windows.Forms.TextBox();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.PriceField = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.ModelField = new System.Windows.Forms.TextBox();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.BrandField = new System.Windows.Forms.TextBox();
            this.BrandLabel = new System.Windows.Forms.Label();
            this.BillGridView = new System.Windows.Forms.DataGridView();
            this.AddButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.PrintBill_InPDF = new System.Windows.Forms.Button();
            this.PrintBill_InWord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MobileGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccessoriesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MobileGridView
            // 
            this.MobileGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MobileGridView.Location = new System.Drawing.Point(358, 140);
            this.MobileGridView.Name = "MobileGridView";
            this.MobileGridView.RowHeadersWidth = 51;
            this.MobileGridView.RowTemplate.Height = 24;
            this.MobileGridView.Size = new System.Drawing.Size(530, 275);
            this.MobileGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(472, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(563, 53);
            this.label1.TabIndex = 37;
            this.label1.Text = "Mobile Management System";
            // 
            // AccessoriesGridView
            // 
            this.AccessoriesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccessoriesGridView.Location = new System.Drawing.Point(921, 140);
            this.AccessoriesGridView.Name = "AccessoriesGridView";
            this.AccessoriesGridView.RowHeadersWidth = 51;
            this.AccessoriesGridView.RowTemplate.Height = 24;
            this.AccessoriesGridView.Size = new System.Drawing.Size(530, 275);
            this.AccessoriesGridView.TabIndex = 38;
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(1421, -3);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(45, 42);
            this.Exit.TabIndex = 75;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // QuantityField
            // 
            this.QuantityField.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuantityField.Location = new System.Drawing.Point(172, 301);
            this.QuantityField.Margin = new System.Windows.Forms.Padding(4);
            this.QuantityField.Name = "QuantityField";
            this.QuantityField.Size = new System.Drawing.Size(160, 45);
            this.QuantityField.TabIndex = 83;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuantityLabel.Location = new System.Drawing.Point(21, 301);
            this.QuantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(132, 37);
            this.QuantityLabel.TabIndex = 82;
            this.QuantityLabel.Text = "Quantity";
            // 
            // PriceField
            // 
            this.PriceField.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceField.Location = new System.Drawing.Point(172, 229);
            this.PriceField.Margin = new System.Windows.Forms.Padding(4);
            this.PriceField.Name = "PriceField";
            this.PriceField.Size = new System.Drawing.Size(160, 45);
            this.PriceField.TabIndex = 81;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceLabel.Location = new System.Drawing.Point(70, 233);
            this.PriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(83, 37);
            this.PriceLabel.TabIndex = 80;
            this.PriceLabel.Text = "Price";
            // 
            // ModelField
            // 
            this.ModelField.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModelField.Location = new System.Drawing.Point(172, 149);
            this.ModelField.Margin = new System.Windows.Forms.Padding(4);
            this.ModelField.Name = "ModelField";
            this.ModelField.Size = new System.Drawing.Size(160, 45);
            this.ModelField.TabIndex = 79;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModelLabel.Location = new System.Drawing.Point(52, 153);
            this.ModelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(101, 37);
            this.ModelLabel.TabIndex = 78;
            this.ModelLabel.Text = "Model";
            // 
            // BrandField
            // 
            this.BrandField.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BrandField.Location = new System.Drawing.Point(172, 67);
            this.BrandField.Margin = new System.Windows.Forms.Padding(4);
            this.BrandField.Name = "BrandField";
            this.BrandField.Size = new System.Drawing.Size(160, 45);
            this.BrandField.TabIndex = 77;
            // 
            // BrandLabel
            // 
            this.BrandLabel.AutoSize = true;
            this.BrandLabel.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BrandLabel.Location = new System.Drawing.Point(56, 71);
            this.BrandLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BrandLabel.Name = "BrandLabel";
            this.BrandLabel.Size = new System.Drawing.Size(97, 37);
            this.BrandLabel.TabIndex = 76;
            this.BrandLabel.Text = "Brand";
            // 
            // BillGridView
            // 
            this.BillGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillGridView.Location = new System.Drawing.Point(358, 459);
            this.BillGridView.Name = "BillGridView";
            this.BillGridView.RowHeadersWidth = 51;
            this.BillGridView.RowTemplate.Height = 24;
            this.BillGridView.Size = new System.Drawing.Size(737, 254);
            this.BillGridView.TabIndex = 84;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(28, 374);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(304, 41);
            this.AddButton.TabIndex = 85;
            this.AddButton.Text = "ADD";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(529, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 46);
            this.label2.TabIndex = 88;
            this.label2.Text = "Mobiles Stok";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1066, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 46);
            this.label3.TabIndex = 89;
            this.label3.Text = "Accessories Stok";
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(28, 445);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(298, 41);
            this.BackButton.TabIndex = 90;
            this.BackButton.Text = "BACK";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // PrintBill_InPDF
            // 
            this.PrintBill_InPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PrintBill_InPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrintBill_InPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintBill_InPDF.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrintBill_InPDF.Location = new System.Drawing.Point(1129, 459);
            this.PrintBill_InPDF.Name = "PrintBill_InPDF";
            this.PrintBill_InPDF.Size = new System.Drawing.Size(300, 100);
            this.PrintBill_InPDF.TabIndex = 91;
            this.PrintBill_InPDF.Text = "Print Bill In PDF";
            this.PrintBill_InPDF.UseVisualStyleBackColor = false;
            this.PrintBill_InPDF.Click += new System.EventHandler(this.PrintBill_InPDF_Click);
            // 
            // PrintBill_InWord
            // 
            this.PrintBill_InWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PrintBill_InWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrintBill_InWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintBill_InWord.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrintBill_InWord.Location = new System.Drawing.Point(1129, 613);
            this.PrintBill_InWord.Name = "PrintBill_InWord";
            this.PrintBill_InWord.Size = new System.Drawing.Size(300, 100);
            this.PrintBill_InWord.TabIndex = 92;
            this.PrintBill_InWord.Text = "Print Bill In Word";
            this.PrintBill_InWord.UseVisualStyleBackColor = false;
            this.PrintBill_InWord.Click += new System.EventHandler(this.PrintBill_InWord_Click);
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1463, 801);
            this.Controls.Add(this.PrintBill_InWord);
            this.Controls.Add(this.PrintBill_InPDF);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.BillGridView);
            this.Controls.Add(this.QuantityField);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.PriceField);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.ModelField);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.BrandField);
            this.Controls.Add(this.BrandLabel);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.AccessoriesGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MobileGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SellingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellingForm";
            ((System.ComponentModel.ISupportInitialize)(this.MobileGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccessoriesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MobileGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView AccessoriesGridView;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.TextBox QuantityField;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.TextBox PriceField;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox ModelField;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.TextBox BrandField;
        private System.Windows.Forms.Label BrandLabel;
        private System.Windows.Forms.DataGridView BillGridView;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button PrintBill_InPDF;
        private System.Windows.Forms.Button PrintBill_InWord;
    }
}