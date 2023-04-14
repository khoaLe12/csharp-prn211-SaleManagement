using BusinessObject;
using BusinessObject.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class FrmOrder : Form
    {
        public bool UpdateOrView { get; set; } = false;
        IOrderService _orderService = new OrderService();
        IProductService _productService = new ProductService();
        public FrmOrder()
        {
            InitializeComponent();
        }

        private void FrmOrder_Load(object sender, EventArgs e)
        {
            if(!UpdateOrView)
            {
                btnSave.Enabled = false;
            }
            var order = (OrderObject) this.Tag;
            if(order is not null)
            {
                txtId.Text = order.OrderId.ToString();
                dtOrderDate.Value = order.OrderDate;
                dtRequiredDate.Value = order.RequiredDate.Value;
                dtShippedDate.Value = order.ShippedDate.Value;
                numFreight.Value = order.Freight.Value;
                dgvDetails.DataSource = order.OrderDetails.Select(d =>
                {
                    return new
                    {
                        ProductName = _productService.GetById(d.ProductId)?.ProductName,
                        UnitPrice = d.UnitPrice,
                        Quantity = d.Quantity,
                        Discount = d.Discount,
                        Total = d.UnitPrice * d.Quantity * (1-d.Discount)
                    };
                }).ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dtShippedDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var order = (OrderObject) this.Tag;
            DateTime required = dtRequiredDate.Value;
            DateTime shipping = dtShippedDate.Value;
            MessageBox.Show(shipping.ToString());
            decimal freight = numFreight.Value;
            var newOrder = new OrderObject()
            {
                OrderId = order.OrderId,
                OrderDate = order.OrderDate,
                Freight = freight,
                ShippedDate = shipping,
                RequiredDate = required,
                MemberId = order.MemberId,
                Member = null,
                OrderDetails = null
            };
            _orderService.Update(newOrder);
            this.DialogResult = DialogResult.OK;
        }
    }
}
