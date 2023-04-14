namespace SalesWinApp
{
    partial class Management
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
            this.dgvOrder = new System.Windows.Forms.TabControl();
            this.tabProduct = new System.Windows.Forms.TabPage();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboSearchProdOpt = new System.Windows.Forms.ComboBox();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchProd = new System.Windows.Forms.TextBox();
            this.panelAction = new System.Windows.Forms.Panel();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.tabMember = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMemDelete = new System.Windows.Forms.Button();
            this.txtMemUpdate = new System.Windows.Forms.Button();
            this.txtMemAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmailSearch = new System.Windows.Forms.TextBox();
            this.dgvMember = new System.Windows.Forms.DataGridView();
            this.tabOrder = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.btnOrderUpdate = new System.Windows.Forms.Button();
            this.btnViewOrder = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvOrder.SuspendLayout();
            this.tabProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelAction.SuspendLayout();
            this.tabMember.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
            this.tabOrder.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOrder
            // 
            this.dgvOrder.Controls.Add(this.tabProduct);
            this.dgvOrder.Controls.Add(this.tabMember);
            this.dgvOrder.Controls.Add(this.tabOrder);
            this.dgvOrder.Location = new System.Drawing.Point(17, 45);
            this.dgvOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.SelectedIndex = 0;
            this.dgvOrder.Size = new System.Drawing.Size(1109, 710);
            this.dgvOrder.TabIndex = 0;
            // 
            // tabProduct
            // 
            this.tabProduct.Controls.Add(this.dgvProduct);
            this.tabProduct.Controls.Add(this.panel1);
            this.tabProduct.Controls.Add(this.panelAction);
            this.tabProduct.Location = new System.Drawing.Point(4, 34);
            this.tabProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabProduct.Name = "tabProduct";
            this.tabProduct.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabProduct.Size = new System.Drawing.Size(1101, 672);
            this.tabProduct.TabIndex = 0;
            this.tabProduct.Text = "Product";
            this.tabProduct.UseVisualStyleBackColor = true;
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(20, 10);
            this.dgvProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 62;
            this.dgvProduct.RowTemplate.Height = 25;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(1043, 462);
            this.dgvProduct.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboSearchProdOpt);
            this.panel1.Controls.Add(this.btnSearchProduct);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSearchProd);
            this.panel1.Location = new System.Drawing.Point(20, 482);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 75);
            this.panel1.TabIndex = 1;
            // 
            // cboSearchProdOpt
            // 
            this.cboSearchProdOpt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearchProdOpt.FormattingEnabled = true;
            this.cboSearchProdOpt.Items.AddRange(new object[] {
            "Name",
            "ID",
            "Unit Price",
            "Unit In Stock"});
            this.cboSearchProdOpt.Location = new System.Drawing.Point(639, 30);
            this.cboSearchProdOpt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboSearchProdOpt.Name = "cboSearchProdOpt";
            this.cboSearchProdOpt.Size = new System.Drawing.Size(191, 33);
            this.cboSearchProdOpt.TabIndex = 3;
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Location = new System.Drawing.Point(840, 25);
            this.btnSearchProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(107, 45);
            this.btnSearchProduct.TabIndex = 2;
            this.btnSearchProduct.Text = "Search";
            this.btnSearchProduct.UseVisualStyleBackColor = true;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search product";
            // 
            // txtSearchProd
            // 
            this.txtSearchProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchProd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchProd.Location = new System.Drawing.Point(219, 25);
            this.txtSearchProd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchProd.Name = "txtSearchProd";
            this.txtSearchProd.Size = new System.Drawing.Size(410, 37);
            this.txtSearchProd.TabIndex = 0;
            // 
            // panelAction
            // 
            this.panelAction.Controls.Add(this.btnDeleteProduct);
            this.panelAction.Controls.Add(this.btnUpdateProduct);
            this.panelAction.Controls.Add(this.btnAddProduct);
            this.panelAction.Location = new System.Drawing.Point(20, 567);
            this.panelAction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelAction.Name = "panelAction";
            this.panelAction.Size = new System.Drawing.Size(1043, 80);
            this.panelAction.TabIndex = 0;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(656, 20);
            this.btnDeleteProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(124, 55);
            this.btnDeleteProduct.TabIndex = 0;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(446, 20);
            this.btnUpdateProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(124, 55);
            this.btnUpdateProduct.TabIndex = 0;
            this.btnUpdateProduct.Text = "Update";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(244, 20);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(124, 55);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Add New";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // tabMember
            // 
            this.tabMember.Controls.Add(this.panel3);
            this.tabMember.Controls.Add(this.panel2);
            this.tabMember.Controls.Add(this.dgvMember);
            this.tabMember.Location = new System.Drawing.Point(4, 34);
            this.tabMember.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabMember.Name = "tabMember";
            this.tabMember.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabMember.Size = new System.Drawing.Size(1101, 672);
            this.tabMember.TabIndex = 1;
            this.tabMember.Text = "Member";
            this.tabMember.UseVisualStyleBackColor = true;
            this.tabMember.Click += new System.EventHandler(this.tabMember_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtMemDelete);
            this.panel3.Controls.Add(this.txtMemUpdate);
            this.panel3.Controls.Add(this.txtMemAdd);
            this.panel3.Location = new System.Drawing.Point(4, 573);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1089, 80);
            this.panel3.TabIndex = 3;
            // 
            // txtMemDelete
            // 
            this.txtMemDelete.Location = new System.Drawing.Point(656, 20);
            this.txtMemDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMemDelete.Name = "txtMemDelete";
            this.txtMemDelete.Size = new System.Drawing.Size(124, 55);
            this.txtMemDelete.TabIndex = 0;
            this.txtMemDelete.Text = "Delete";
            this.txtMemDelete.UseVisualStyleBackColor = true;
            this.txtMemDelete.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtMemUpdate
            // 
            this.txtMemUpdate.Location = new System.Drawing.Point(446, 20);
            this.txtMemUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMemUpdate.Name = "txtMemUpdate";
            this.txtMemUpdate.Size = new System.Drawing.Size(124, 55);
            this.txtMemUpdate.TabIndex = 0;
            this.txtMemUpdate.Text = "Update";
            this.txtMemUpdate.UseVisualStyleBackColor = true;
            this.txtMemUpdate.Click += new System.EventHandler(this.txtMemUpdate_Click);
            // 
            // txtMemAdd
            // 
            this.txtMemAdd.Location = new System.Drawing.Point(244, 20);
            this.txtMemAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMemAdd.Name = "txtMemAdd";
            this.txtMemAdd.Size = new System.Drawing.Size(124, 55);
            this.txtMemAdd.TabIndex = 0;
            this.txtMemAdd.Text = "Add New";
            this.txtMemAdd.UseVisualStyleBackColor = true;
            this.txtMemAdd.Click += new System.EventHandler(this.txtMemAdd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtEmailSearch);
            this.panel2.Location = new System.Drawing.Point(4, 472);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1089, 75);
            this.panel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(606, 25);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search member";
            // 
            // txtEmailSearch
            // 
            this.txtEmailSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmailSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmailSearch.Location = new System.Drawing.Point(164, 25);
            this.txtEmailSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmailSearch.Name = "txtEmailSearch";
            this.txtEmailSearch.PlaceholderText = "email";
            this.txtEmailSearch.Size = new System.Drawing.Size(410, 37);
            this.txtEmailSearch.TabIndex = 0;
            // 
            // dgvMember
            // 
            this.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMember.Location = new System.Drawing.Point(4, 5);
            this.dgvMember.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMember.Name = "dgvMember";
            this.dgvMember.RowHeadersWidth = 62;
            this.dgvMember.RowTemplate.Height = 25;
            this.dgvMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMember.Size = new System.Drawing.Size(1089, 457);
            this.dgvMember.TabIndex = 0;
            // 
            // tabOrder
            // 
            this.tabOrder.Controls.Add(this.panel5);
            this.tabOrder.Controls.Add(this.panel4);
            this.tabOrder.Controls.Add(this.dataGridView2);
            this.tabOrder.Location = new System.Drawing.Point(4, 34);
            this.tabOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabOrder.Name = "tabOrder";
            this.tabOrder.Size = new System.Drawing.Size(1101, 672);
            this.tabOrder.TabIndex = 2;
            this.tabOrder.Text = "Order";
            this.tabOrder.UseVisualStyleBackColor = true;
            this.tabOrder.Click += new System.EventHandler(this.tabOrder_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button6);
            this.panel5.Controls.Add(this.btnOrderUpdate);
            this.panel5.Controls.Add(this.btnViewOrder);
            this.panel5.Location = new System.Drawing.Point(4, 578);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1080, 80);
            this.panel5.TabIndex = 5;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(656, 20);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(124, 55);
            this.button6.TabIndex = 0;
            this.button6.Text = "Delete";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnOrderUpdate
            // 
            this.btnOrderUpdate.Location = new System.Drawing.Point(446, 20);
            this.btnOrderUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOrderUpdate.Name = "btnOrderUpdate";
            this.btnOrderUpdate.Size = new System.Drawing.Size(124, 55);
            this.btnOrderUpdate.TabIndex = 0;
            this.btnOrderUpdate.Text = "Update";
            this.btnOrderUpdate.UseVisualStyleBackColor = true;
            this.btnOrderUpdate.Click += new System.EventHandler(this.btnOrderUpdate_Click);
            // 
            // btnViewOrder
            // 
            this.btnViewOrder.Location = new System.Drawing.Point(244, 20);
            this.btnViewOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewOrder.Name = "btnViewOrder";
            this.btnViewOrder.Size = new System.Drawing.Size(124, 55);
            this.btnViewOrder.TabIndex = 0;
            this.btnViewOrder.Text = "View";
            this.btnViewOrder.UseVisualStyleBackColor = true;
            this.btnViewOrder.Click += new System.EventHandler(this.btnViewOrder_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.btnReport);
            this.panel4.Controls.Add(this.dtTo);
            this.panel4.Controls.Add(this.dtFrom);
            this.panel4.Location = new System.Drawing.Point(4, 468);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1080, 100);
            this.panel4.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(487, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "From";
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(899, 33);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(107, 38);
            this.btnReport.TabIndex = 1;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // dtTo
            // 
            this.dtTo.Location = new System.Drawing.Point(543, 30);
            this.dtTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(284, 31);
            this.dtTo.TabIndex = 0;
            // 
            // dtFrom
            // 
            this.dtFrom.Location = new System.Drawing.Point(119, 30);
            this.dtFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(284, 31);
            this.dtFrom.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(4, 5);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1080, 453);
            this.dataGridView2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1143, 35);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(171, 34);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 787);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Management";
            this.Load += new System.EventHandler(this.Management_Load);
            this.dgvOrder.ResumeLayout(false);
            this.tabProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelAction.ResumeLayout(false);
            this.tabMember.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).EndInit();
            this.tabOrder.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl dgvOrder;
        private TabPage tabProduct;
        private Panel panel1;
        private Button btnSearchProduct;
        private Label label1;
        private TextBox txtSearchProd;
        private Panel panelAction;
        private Button btnDeleteProduct;
        private Button btnUpdateProduct;
        private Button btnAddProduct;
        private TabPage tabMember;
        private Panel panel3;
        private Button txtMemDelete;
        private Button txtMemUpdate;
        private Button txtMemAdd;
        private Panel panel2;
        private Button button1;
        private Label label2;
        private TextBox txtEmailSearch;
        private DataGridView dgvMember;
        private TabPage tabOrder;
        private Panel panel5;
        private Button button6;
        private Button btnOrderUpdate;
        private Button btnViewOrder;
        private Panel panel4;
        private DataGridView dataGridView2;
        private DataGridView dgvProduct;
        private Button btnReport;
        private DateTimePicker dtTo;
        private DateTimePicker dtFrom;
        private Label label4;
        private Label label3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem profileToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ComboBox cboSearchProdOpt;
    }
}