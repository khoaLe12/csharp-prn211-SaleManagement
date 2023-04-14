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
    public partial class Member : Form
    {
        IOrderService orderService = new OrderService();
        public delegate void Logout();
        public Logout LogoutHandle { get; set; } = null;

        public Member()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void Member_Load(object sender, EventArgs e)
        {
            var user = (MemberObject)this.Tag;
            var orders = orderService.FindAll().Where(order => order.MemberId == user.MemberId);
            dgvOrder.DataSource = orders.ToList();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var memberForm = new FrmMember();
            memberForm.UpdateOrInsert = true;
            memberForm.Tag = this.Tag;
            memberForm.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogoutHandle?.Invoke();
        }
    }
}
