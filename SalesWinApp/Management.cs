
using BusinessObject;
using BusinessObject.Service;
using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class Management : Form
    {
        public delegate void Logout();
        public Logout LogoutHandle { get; set; } = null;
        IProductService productService;
        IMemberService memberService;
        IOrderService orderService;
        ICategoryService categoryService = new CategoryService();
        public Management()
        {
            InitializeComponent();
        }
        private void LoadMember(string term = null)
        {
            IEnumerable<MemberObject> members;
            memberService = new MemberService();
            if (term is not null)
            {
                 members = memberService.FindAll(term);

            }
            else
            {
                 members = memberService.FindAll();
               
            }
            dgvMember.DataSource = null;
            dgvMember.DataSource = members.Select(mem => new
            {
                MemberID = mem.MemberId,
                Email = mem.Email,
                
                CompanyName = mem.CompanyName,
                Conntry = mem.Country,
                City = mem.City,
                Password = "***"
            }).ToList();
        }
        
        private void LoadProduct(string term = null)
        {
            productService = new ProductService();
            var categories = categoryService.GetAll();
            IEnumerable<ProductObject> products;
            if (term is not null)
            {
                products = productService.FindAll(term);

            }
            else
            {
                products = productService.FindAll();
            }
            dgvProduct.DataSource = null;
            dgvProduct.DataSource = products.Select(prod => new
            {
                ProductID = prod.ProductId,
                ProductName = prod.ProductName,
                Category = categories[prod.CategoryId],
                Weight = prod.Weight,
                UnitPrice = prod.UnitPrice,
                UnitsInStock = prod.UnitsInStock
            }).ToList();


        }
        private void Management_Load(object sender, EventArgs e)
        {

            //this.IsMdiContainer = true;
            //var productForm = new FrmProduct();
            //productForm.MdiParent = this;

            //productForm.Show();
            LoadProduct();
            LoadMember();
            LoadOrder();


        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            FrmProduct product = new()
            {
                UpdateOrInsert = false,
            };

            if (product.ShowDialog() == DialogResult.OK)
            {
                product.Hide();
                product.Text = "";
                LoadProduct();
            }

        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            string term = txtSearchProd.Text.Trim();
            var option = cboSearchProdOpt.SelectedItem.ToString();
            switch (option)
            {
                case "Name" :
                    {
                        LoadProduct(term);
                        break;
                    }
                case "ID":
                    {
                        dgvProduct.DataSource = null;
                        dgvProduct.DataSource = productService.FindAll().Where(prod => prod.ProductId.ToString().Contains(term)).ToList();
                        break;
                    }
                case "Unit Price":
                    {
                        dgvProduct.DataSource = null;
                        dgvProduct.DataSource = productService.FindAll().Where(prod => prod.UnitPrice.ToString().Contains(term)).ToList();
                        break;
                      
                    }
                case "Unit In Stock":
                    {
                        dgvProduct.DataSource = null;
                        dgvProduct.DataSource = productService.FindAll().Where(prod => prod.UnitsInStock.ToString().Contains(term)).ToList();
                        break;
                    }
                default:
                    break;
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            FrmProduct product = new()
            {
                UpdateOrInsert = true,
            };
            var index = dgvProduct.CurrentCell.RowIndex;
            var selected = dgvProduct.Rows[index].Cells[0].Value.ToString();
            product.Tag = (ProductObject)productService.GetById(int.Parse(selected));

            if (product.ShowDialog() == DialogResult.OK)
            {
                product.Hide();
                product.Text = "";
                LoadProduct();
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            DialogResult diaResult = MessageBox.Show("Are you sure to delete this product?", "Delete Warning", MessageBoxButtons.OKCancel);
            if (diaResult == DialogResult.OK)
            {
                var index = dgvProduct.CurrentCell.RowIndex;
                var selected = dgvProduct.Rows[index].Cells[0].Value.ToString();
                productService.Delete(int.Parse(selected));
                LoadProduct();
            }
          
        }

        private void tabMember_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult diaResult = MessageBox.Show("Are you sure to delete this member?", "Delete Warning", MessageBoxButtons.OKCancel);
            if (diaResult == DialogResult.OK)
            {
                var index = dgvMember.CurrentCell.RowIndex;
                var selected = dgvMember.Rows[index].Cells[0].Value.ToString();
                memberService.Delete(int.Parse(selected));
                LoadMember();
            }
            
        }


        private void txtMemUpdate_Click(object sender, EventArgs e)
        {
            FrmMember memberForm = new()
            {
                UpdateOrInsert = true,
            };
            var index = dgvMember.CurrentCell.RowIndex;
            var selected = dgvMember.Rows[index].Cells[0].Value.ToString();
            memberForm.Tag = memberService.GetById(int.Parse(selected));

            if (memberForm.ShowDialog() == DialogResult.OK)
            {
                memberForm.Hide();
                memberForm.Text = "";
                LoadMember();
            }
        }

        private void txtMemAdd_Click(object sender, EventArgs e)
        {
            FrmMember memberForm = new()
            {
                UpdateOrInsert = false,
            };

            if (memberForm.ShowDialog() == DialogResult.OK)
            {
                memberForm.Hide();
                memberForm.Text = "";
                LoadMember();
            }
        }

        private void LoadOrder()
        {
            orderService = new OrderService();

            var orders = orderService.FindAll();
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = orders.Select(order =>
            {
                double sales = 0;

                order.OrderDetails?.ToList().ForEach(detail =>
                    sales = sales + detail.UnitPrice * detail.Quantity * (1 - detail.Discount)
                ); ;

                return new
                {
                    OrderId = order.OrderId,
                    MemberId = order.MemberId,
                    OrderDate = order.OrderDate,
                    RequiredDate = order.RequiredDate,
                    ShippedDate = order.ShippedDate,
                    Freight = order.Freight,
                    Items = order.OrderDetails?.ToArray()?.Length??0,
                    Sales = sales
                };
            }).ToList();
        }
        private void tabOrder_Click(object sender, EventArgs e)
        {
            LoadOrder();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            DateTime from = dtFrom.Value;
            DateTime to = dtTo.Value;
            if(from > to)
            {
                MessageBox.Show("Invalid Start Date and End Date.");
            }else
            {
                var orders = orderService.FindAll().Where(order => order.OrderDate.Date >= from.Date && order.OrderDate.Date <= to.Date);
                var reportForm = new FrmReport();
                reportForm.Tag = orders;
                reportForm.ShowDialog();
            }
           
            // TODO populate Order Detail

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadMember(txtEmailSearch.Text.Trim());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult diaResult = MessageBox.Show("Are you sure to delete this member?", "Delete Warning", MessageBoxButtons.OKCancel);
            if (diaResult == DialogResult.OK)
            {
                var index = dataGridView2.CurrentCell.RowIndex;
                var selected = dataGridView2.Rows[index].Cells[0].Value.ToString();
                orderService.Delete(int.Parse(selected));
                LoadMember();
            }
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            var index = dataGridView2.CurrentCell.RowIndex;
            var selected = dataGridView2.Rows[index].Cells[0].Value.ToString();
            FrmOrder orderFrom = new FrmOrder();
            orderFrom.Tag = orderService.GetById(int.Parse(selected));
            if(orderFrom.ShowDialog() == DialogResult.OK)
            {
                LoadOrder();
            }
        }

        private void btnOrderUpdate_Click(object sender, EventArgs e)
        {
            var index = dataGridView2.CurrentCell.RowIndex;
            var selected = dataGridView2.Rows[index].Cells[0].Value.ToString();
            FrmOrder orderFrom = new FrmOrder() {  UpdateOrView = true};
            orderFrom.Tag = orderService.GetById(int.Parse(selected));
            if (orderFrom.ShowDialog() == DialogResult.OK)
            {
                LoadOrder();
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogoutHandle?.Invoke();
        }
    }
}
