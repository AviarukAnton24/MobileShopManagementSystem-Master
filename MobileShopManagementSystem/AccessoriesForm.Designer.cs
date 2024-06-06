namespace MobileShopManagementSystem
{
    partial class AccessoriesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccessoriesForm));
            this.Exit = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.QuantityField = new System.Windows.Forms.TextBox();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.PriceField = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.ModelField = new System.Windows.Forms.TextBox();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.BrandField = new System.Windows.Forms.TextBox();
            this.BrandLabel = new System.Windows.Forms.Label();
            this.IDField = new System.Windows.Forms.TextBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.TableToExcel = new System.Windows.Forms.Button();
            this.TableToWord = new System.Windows.Forms.Button();
            this.TableToPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(1363, -5);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(45, 42);
            this.Exit.TabIndex = 66;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(16, 257);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(739, 436);
            this.dataGridView.TabIndex = 65;
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.Location = new System.Drawing.Point(920, 191);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(138, 41);
            this.ClearButton.TabIndex = 64;
            this.ClearButton.Text = "CLEAR";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Location = new System.Drawing.Point(747, 191);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(154, 41);
            this.DeleteButton.TabIndex = 63;
            this.DeleteButton.Text = "DELETE";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.UpdateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateButton.Location = new System.Drawing.Point(576, 191);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(149, 41);
            this.UpdateButton.TabIndex = 62;
            this.UpdateButton.Text = "UPDATE";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(446, 191);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(108, 41);
            this.AddButton.TabIndex = 61;
            this.AddButton.Text = "ADD";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // QuantityField
            // 
            this.QuantityField.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuantityField.Location = new System.Drawing.Point(1227, 107);
            this.QuantityField.Margin = new System.Windows.Forms.Padding(4);
            this.QuantityField.Name = "QuantityField";
            this.QuantityField.Size = new System.Drawing.Size(160, 45);
            this.QuantityField.TabIndex = 46;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuantityLabel.Location = new System.Drawing.Point(1085, 111);
            this.QuantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(132, 37);
            this.QuantityLabel.TabIndex = 45;
            this.QuantityLabel.Text = "Quantity";
            // 
            // PriceField
            // 
            this.PriceField.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceField.Location = new System.Drawing.Point(931, 108);
            this.PriceField.Margin = new System.Windows.Forms.Padding(4);
            this.PriceField.Name = "PriceField";
            this.PriceField.Size = new System.Drawing.Size(132, 45);
            this.PriceField.TabIndex = 44;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceLabel.Location = new System.Drawing.Point(837, 113);
            this.PriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(83, 37);
            this.PriceLabel.TabIndex = 43;
            this.PriceLabel.Text = "Price";
            // 
            // ModelField
            // 
            this.ModelField.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModelField.Location = new System.Drawing.Point(660, 107);
            this.ModelField.Margin = new System.Windows.Forms.Padding(4);
            this.ModelField.Name = "ModelField";
            this.ModelField.Size = new System.Drawing.Size(160, 45);
            this.ModelField.TabIndex = 42;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModelLabel.Location = new System.Drawing.Point(547, 113);
            this.ModelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(101, 37);
            this.ModelLabel.TabIndex = 41;
            this.ModelLabel.Text = "Model";
            // 
            // BrandField
            // 
            this.BrandField.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BrandField.Location = new System.Drawing.Point(368, 107);
            this.BrandField.Margin = new System.Windows.Forms.Padding(4);
            this.BrandField.Name = "BrandField";
            this.BrandField.Size = new System.Drawing.Size(160, 45);
            this.BrandField.TabIndex = 40;
            // 
            // BrandLabel
            // 
            this.BrandLabel.AutoSize = true;
            this.BrandLabel.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BrandLabel.Location = new System.Drawing.Point(262, 113);
            this.BrandLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BrandLabel.Name = "BrandLabel";
            this.BrandLabel.Size = new System.Drawing.Size(97, 37);
            this.BrandLabel.TabIndex = 39;
            this.BrandLabel.Text = "Brand";
            // 
            // IDField
            // 
            this.IDField.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDField.Location = new System.Drawing.Point(70, 107);
            this.IDField.Margin = new System.Windows.Forms.Padding(4);
            this.IDField.Name = "IDField";
            this.IDField.Size = new System.Drawing.Size(160, 45);
            this.IDField.TabIndex = 38;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDLabel.Location = new System.Drawing.Point(9, 113);
            this.IDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(52, 37);
            this.IDLabel.TabIndex = 37;
            this.IDLabel.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(472, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(563, 53);
            this.label1.TabIndex = 36;
            this.label1.Text = "Mobile Management System";
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(811, 636);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(300, 57);
            this.BackButton.TabIndex = 70;
            this.BackButton.Text = "BACK";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // TableToExcel
            // 
            this.TableToExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TableToExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TableToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TableToExcel.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TableToExcel.Location = new System.Drawing.Point(811, 506);
            this.TableToExcel.Name = "TableToExcel";
            this.TableToExcel.Size = new System.Drawing.Size(300, 57);
            this.TableToExcel.TabIndex = 69;
            this.TableToExcel.Text = "ConvertToExcel";
            this.TableToExcel.UseVisualStyleBackColor = false;
            this.TableToExcel.Click += new System.EventHandler(this.TableToExcel_Click);
            // 
            // TableToWord
            // 
            this.TableToWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TableToWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TableToWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TableToWord.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TableToWord.Location = new System.Drawing.Point(811, 386);
            this.TableToWord.Name = "TableToWord";
            this.TableToWord.Size = new System.Drawing.Size(300, 57);
            this.TableToWord.TabIndex = 68;
            this.TableToWord.Text = "ConvertToWord";
            this.TableToWord.UseVisualStyleBackColor = false;
            this.TableToWord.Click += new System.EventHandler(this.TableToWord_Click);
            // 
            // TableToPDF
            // 
            this.TableToPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TableToPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TableToPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TableToPDF.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TableToPDF.Location = new System.Drawing.Point(811, 257);
            this.TableToPDF.Name = "TableToPDF";
            this.TableToPDF.Size = new System.Drawing.Size(300, 57);
            this.TableToPDF.TabIndex = 67;
            this.TableToPDF.Text = "ConvertToPDF";
            this.TableToPDF.UseVisualStyleBackColor = false;
            this.TableToPDF.Click += new System.EventHandler(this.TableToPDF_Click);
            // 
            // AccessoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1403, 801);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.TableToExcel);
            this.Controls.Add(this.TableToWord);
            this.Controls.Add(this.TableToPDF);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.QuantityField);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.PriceField);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.ModelField);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.BrandField);
            this.Controls.Add(this.BrandLabel);
            this.Controls.Add(this.IDField);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AccessoriesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox QuantityField;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.TextBox PriceField;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox ModelField;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.TextBox BrandField;
        private System.Windows.Forms.Label BrandLabel;
        private System.Windows.Forms.TextBox IDField;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button TableToExcel;
        private System.Windows.Forms.Button TableToWord;
        private System.Windows.Forms.Button TableToPDF;
    }
}