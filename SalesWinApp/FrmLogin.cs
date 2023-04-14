using BusinessObject.Service;
using Microsoft.Extensions.Configuration;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class FrmLogin : Form
    {
       
        IMemberService memberService = new MemberService();
        
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to quit ?", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Please enter email!");
            }
            else if (txtPass.Text == "")
            {
                MessageBox.Show("Please enter password!");
            }
            else
            {
                IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
                var email = config["DefaultAdmin:email"];
                var password = config["DefaultAdmin:password"];
                if (txtEmail.Text == email && txtPass.Text == password)
                {
                    Management form = new Management();
                    form.LogoutHandle = () =>
                    {
                        form.Close();
                        txtEmail.Clear();
                        txtPass.Clear();
                        this.Show();
                    };
                    this.Hide();
                    form.Show();
                }
                else
                {
                    var member = memberService.FindAll().Where(mem =>
                    {
                        return txtEmail.Text == mem.Email && txtPass.Text == mem.Password;
                    }).FirstOrDefault();
                    if (member is not null)
                    {
                        Member memForm = new Member();
                        memForm.Tag = member;
                        memForm.LogoutHandle = () =>
                        {
                            memForm.Close();
                            txtEmail.Clear();
                            txtPass.Clear();
                            this.Show();
                        };
                        this.Hide();
                        memForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect email or password");
                    }
                }
            }
        }
    }
}