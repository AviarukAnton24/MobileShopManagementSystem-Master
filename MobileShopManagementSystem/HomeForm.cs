using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShopManagementSystem
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MobilesButton_Click(object sender, EventArgs e)
        {
            MobileForm mobileForm = new MobileForm();
            this.Hide();
            mobileForm.Show();
        }

        private void AccessoriesButton_Click(object sender, EventArgs e)
        {
            AccessoriesForm accessoriesForm = new AccessoriesForm();
            this.Hide();
            accessoriesForm.Show();
        }

        private void SellingButton_Click(object sender, EventArgs e)
        {
            SellingForm sellingForm = new SellingForm();
            this.Hide();
            sellingForm.Show();
        }
    }
}
