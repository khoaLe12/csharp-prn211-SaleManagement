using System.Windows.Forms.DataVisualization.Charting;

namespace SalesWinApp
{
    partial class FrmReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbNoOrder = new System.Windows.Forms.Label();
            this.lbTotalSale = new System.Windows.Forms.Label();
            this.lbAvgSale = new System.Windows.Forms.Label();
            this.lbBestProd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(238, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orders Report Statistic";
            // 
            // dgvOrder
            // 
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(12, 50);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowTemplate.Height = 25;
            this.dgvOrder.Size = new System.Drawing.Size(667, 271);
            this.dgvOrder.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(31, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number Of Orders: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(31, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Sales:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(357, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Average Sales:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(357, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Best Seller Product:";
            // 
            // lbNoOrder
            // 
            this.lbNoOrder.AutoSize = true;
            this.lbNoOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNoOrder.Location = new System.Drawing.Point(167, 354);
            this.lbNoOrder.Name = "lbNoOrder";
            this.lbNoOrder.Size = new System.Drawing.Size(32, 17);
            this.lbNoOrder.TabIndex = 3;
            this.lbNoOrder.Text = "N/A";
            // 
            // lbTotalSale
            // 
            this.lbTotalSale.AutoSize = true;
            this.lbTotalSale.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTotalSale.Location = new System.Drawing.Point(118, 390);
            this.lbTotalSale.Name = "lbTotalSale";
            this.lbTotalSale.Size = new System.Drawing.Size(32, 17);
            this.lbTotalSale.TabIndex = 3;
            this.lbTotalSale.Text = "N/A";
            // 
            // lbAvgSale
            // 
            this.lbAvgSale.AutoSize = true;
            this.lbAvgSale.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAvgSale.Location = new System.Drawing.Point(460, 354);
            this.lbAvgSale.Name = "lbAvgSale";
            this.lbAvgSale.Size = new System.Drawing.Size(32, 17);
            this.lbAvgSale.TabIndex = 3;
            this.lbAvgSale.Text = "N/A";
            // 
            // lbBestProd
            // 
            this.lbBestProd.AutoSize = true;
            this.lbBestProd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbBestProd.Location = new System.Drawing.Point(501, 390);
            this.lbBestProd.Name = "lbBestProd";
            this.lbBestProd.Size = new System.Drawing.Size(32, 17);
            this.lbBestProd.TabIndex = 3;
            this.lbBestProd.Text = "N/A";
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 811);
            this.Controls.Add(this.lbBestProd);
            this.Controls.Add(this.lbAvgSale);
            this.Controls.Add(this.lbTotalSale);
            this.Controls.Add(this.lbNoOrder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.label1);
            this.Name = "FrmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders Report";
            this.Load += new System.EventHandler(this.FrmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dgvOrder;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lbNoOrder;
        private Label lbTotalSale;
        private Label lbAvgSale;
        private Label lbBestProd;
        private Chart chart1;
        private Chart chart2;

    }
}