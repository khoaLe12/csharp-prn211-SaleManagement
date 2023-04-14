using BusinessObject;
using BusinessObject.Service;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SalesWinApp
{
    public partial class FrmProduct : Form

    {
        public bool UpdateOrInsert { get; set; } = false;
        IProductService productService = new ProductService();
        ICategoryService categoryService = new CategoryService();
        public FrmProduct()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnProdSave_Click(object sender, EventArgs e)
        {
            var category = categoryService.GetAll();


            var cateSelected = cboCategory.SelectedItem.ToString();
            var cateId = category.Keys.Where(x => category[x] == cateSelected).FirstOrDefault();
            string prodId = txtProdId.Text;
            string prodName = txtProdName.Text;
            string weight = numWeight.Value.ToString();
            decimal price = numUnitPrice.Value;
            int stock = int.Parse(numUnitStock.Text);

            bool isValid = true;
            string errMsg = "";
            if ( prodName.Trim() == "")
            {
                isValid = false;
                errMsg = "All field is required";
            }
            if (price < 0)
            {
                isValid = false;
                errMsg = "Price must be positive ";
            }
            if (stock < 0)
            {
                isValid = false;
                errMsg = "Stock must be positive ";
            }

            if (isValid)
            {

                ProductObject prod = new ProductObject()
                {
                    ProductName = prodName,
                    CategoryId = cateId,
                    Weight = weight,
                    UnitPrice = price,
                    UnitsInStock = stock
                    
                };
                if (UpdateOrInsert)
                {
                    prod.ProductId = int.Parse(prodId);
                    productService.Update(prod);
                }
                else
                {

                    productService.Create(prod);
                }

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(errMsg);
            }

        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            var product = (ProductObject)this.Tag;
            var category = categoryService.GetAll();
            cboCategory.Items.Clear();
            cboCategory.Items.AddRange(category.Values.ToArray());
            if (product is null)
            {
                txtProdId.Visible = false;
                lbProdId.Visible = false;
                cboCategory.SelectedIndex = 0;
            }
            else
            {
                txtProdId.Text = product.ProductId.ToString();
                txtProdId.Enabled = false;
                txtProdName.Text = product.ProductName;
                var index = category.Keys.ToList().FindIndex((ele) => ele == product.CategoryId);
                cboCategory.SelectedIndex = index;
                numUnitPrice.Text = product.UnitPrice.ToString();
                numWeight.Text = product.Weight;
                numUnitStock.Text =product.UnitsInStock.ToString();
            }
        }
    }
}
