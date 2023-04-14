using BusinessObject.Service;
using BusinessObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Entity;

namespace SalesWinApp
{
    public partial class FrmMember : Form
    {
        public bool UpdateOrInsert { get; set; } = false;
        IMemberService memberService = new MemberService();
        
        public FrmMember()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnProdSave_Click(object sender, EventArgs e)
        {
            string memId = txtMemId.Text;
            string email = txtEmail.Text;
            string pass = txtPassword.Text;
            string coName = txtCoName.Text;
            string city = txtCity.Text;
            string country = txtCountry.Text;

            bool isValid = true;
            string errMsg = "";
            if (email.Trim() == "" || pass.Trim() == "" || coName.Trim() == "" ||
                city.Trim() == "" || country.Trim() == ""
                )
            {
                isValid = false;
                errMsg = "All field is required";
            }
            

            if (isValid)
            {

                MemberObject mem = new MemberObject()
                {
                    Email = email,
                    Password = pass,
                    City = city,
                    CompanyName = coName,
                    Country = country

                };
                if (UpdateOrInsert)
                {
                    mem.MemberId = int.Parse(memId);
                    memberService.Update(mem);
                }
                else
                {

                    memberService.Create(mem);
                }

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(errMsg);
            }
        }

        private void FrmMember_Load(object sender, EventArgs e)
        {
            var mem = (MemberObject)this.Tag;
            if (mem is null)
            {
                txtMemId.Visible = false;
                lbMemId.Visible = false;
              
            }
            else
            {
                txtMemId.Enabled = false;
                txtMemId.Text = mem.MemberId.ToString();
                txtEmail.Text = mem.Email;
                txtCoName.Text = mem.CompanyName;
                txtCountry.Text = mem.Country;
                txtCity.Text = mem.City;
                txtPassword.Text = mem.Password;
            }
        }
    }
}
