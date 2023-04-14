using BusinessObject;
using BusinessObject.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class FrmReport : Form
    {
        IProductService productService = new ProductService();
        public FrmReport()
        {
            InitializeComponent();
            InitChart();
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            var orders = (IEnumerable<OrderObject>)this.Tag;
            var fullOrders = orders.Select(order =>
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
                    Items = order.OrderDetails?.ToArray()?.Length ?? 0,
                    Sales = sales
                };
            }).OrderBy(order => order.Sales);
            var orderDetails = new List<OrderDetailObject>();
            orders.ToList().ForEach(order => orderDetails.AddRange(order.OrderDetails));

            fullOrders.ToList().ForEach(e =>
            {
                chart1.Series["sales"].Points.AddXY("", e.Sales);
            });
            double total = fullOrders.Sum(order => order.Sales);
            double avg = fullOrders.Average(order => order.Sales);
            int count = fullOrders.Count();
            lbAvgSale.Text = avg.ToString();
            lbNoOrder.Text = count.ToString();
            lbTotalSale.Text = total.ToString();
            lbBestProd.Text = FindBestSeller(orderDetails)?.ProductName;
            dgvOrder.DataSource = fullOrders.ToList();
        }
        private ProductObject FindBestSeller(IEnumerable<OrderDetailObject> details)
        {
            var products = productService.FindAll();
            var detailsGroup = from detail in details
                               group detail by detail.ProductId into prodGroup
                               select new
                               {
                                   ProdId = prodGroup.Key,
                                   Sum = prodGroup.Sum(d => d.Quantity)
                               };
            var fullProductsBySum = from detail in detailsGroup
                                    join prod in products
                                    on detail.ProdId equals prod.ProductId 
                                    select new
                                    {
                                        ProductId = prod.ProductId,
                                        ProductName = prod.ProductName,
                                        Sum = detail.Sum
                                    };

            fullProductsBySum.ToList().ForEach(e =>
            {
                chart2.Series["Product"].Points.AddXY(e.ProductName, e.Sum);
               
            });
            int? prodId = detailsGroup.MaxBy(e=>e.Sum)?.ProdId;
            
            return productService.FindAll().Where(prod => prod.ProductId == prodId).FirstOrDefault();
                              
    
        }
        private void InitChart() {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(24, 575);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "sales";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(350, 250);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(400, 575);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.IsValueShownAsLabel = true;
            series2.LabelBorderWidth = 2;
            series2.LabelForeColor = System.Drawing.Color.WhiteSmoke;
            series2.Legend = "Legend1";
            series2.Name = "Product";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(380, 380);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            chart2.Titles.Add("Product Selled");
            chart1.Titles.Add("Sales");
        }
    }
}
