namespace MobileShopManagementSystem
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MobilesButton = new System.Windows.Forms.Button();
            this.AccessoriesButton = new System.Windows.Forms.Button();
            this.SellingButton = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(255, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(563, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mobile Management System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1020, 443);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MobilesButton
            // 
            this.MobilesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MobilesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MobilesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MobilesButton.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MobilesButton.Location = new System.Drawing.Point(12, 540);
            this.MobilesButton.Name = "MobilesButton";
            this.MobilesButton.Size = new System.Drawing.Size(300, 57);
            this.MobilesButton.TabIndex = 71;
            this.MobilesButton.Text = "Mobiles";
            this.MobilesButton.UseVisualStyleBackColor = false;
            this.MobilesButton.Click += new System.EventHandler(this.MobilesButton_Click);
            // 
            // AccessoriesButton
            // 
            this.AccessoriesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AccessoriesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AccessoriesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccessoriesButton.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccessoriesButton.Location = new System.Drawing.Point(370, 540);
            this.AccessoriesButton.Name = "AccessoriesButton";
            this.AccessoriesButton.Size = new System.Drawing.Size(300, 57);
            this.AccessoriesButton.TabIndex = 72;
            this.AccessoriesButton.Text = "Accessories";
            this.AccessoriesButton.UseVisualStyleBackColor = false;
            this.AccessoriesButton.Click += new System.EventHandler(this.AccessoriesButton_Click);
            // 
            // SellingButton
            // 
            this.SellingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SellingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SellingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SellingButton.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SellingButton.Location = new System.Drawing.Point(732, 540);
            this.SellingButton.Name = "SellingButton";
            this.SellingButton.Size = new System.Drawing.Size(300, 57);
            this.SellingButton.TabIndex = 73;
            this.SellingButton.Text = "Selling";
            this.SellingButton.UseVisualStyleBackColor = false;
            this.SellingButton.Click += new System.EventHandler(this.SellingButton_Click);
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(1002, -5);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(45, 42);
            this.Exit.TabIndex = 74;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1044, 609);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.SellingButton);
            this.Controls.Add(this.AccessoriesButton);
            this.Controls.Add(this.MobilesButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button MobilesButton;
        private System.Windows.Forms.Button AccessoriesButton;
        private System.Windows.Forms.Button SellingButton;
        private System.Windows.Forms.Label Exit;
    }
}