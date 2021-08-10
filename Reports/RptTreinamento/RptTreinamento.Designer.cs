
namespace Procwork.Software.SATI.COM.Report.RptTreinamento
{
    partial class RptTreinamento
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
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bdsReportSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // bdsReportSource
            // 
            this.bdsReportSource.DataSource = typeof(Procwork.Software.SATI.COM.Report.RptTreinamento.DataClass);
            // 
            // xrlTotalPage
            // 
            this.xrlTotalPage.StylePriority.UseFont = false;
            this.xrlTotalPage.StylePriority.UseTextAlignment = false;
            // 
            // lblDate
            // 
            this.lblDate.StylePriority.UseTextAlignment = false;
            // 
            // pnlFooter
            // 
            this.pnlFooter.StylePriority.UseBackColor = false;
            // 
            // lblCopyright
            // 
            this.lblCopyright.StylePriority.UseFont = false;
            this.lblCopyright.StylePriority.UseForeColor = false;
            // 
            // lblLicence
            // 
            this.lblLicence.StylePriority.UseFont = false;
            this.lblLicence.StylePriority.UseForeColor = false;
            // 
            // Detalhes
            // 
            this.Detalhes.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.xrLabel2});
            this.Detalhes.HeightF = 16.75F;
            // 
            // xrLabel1
            // 
            this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CodProduto")});
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(100F, 16.75F);
            this.xrLabel1.Text = "xrLabel1";
            // 
            // xrLabel2
            // 
            this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "DescProduto")});
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(110F, 0F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(229.1667F, 16.75F);
            this.xrLabel2.Text = "xrLabel2";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel4,
            this.xrLabel3});
            this.GroupHeader1.HeightF = 16.75F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // xrLabel3
            // 
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 0F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(100F, 16.75F);
            this.xrLabel3.Text = "Cód. Produto";
            // 
            // xrLabel4
            // 
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(110F, 0F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(229.1667F, 16.75F);
            this.xrLabel4.Text = "Descrição Produto";
            // 
            // RptTreinamento
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detalhes,
            this.Cabecalho,
            this.Rodape,
            this.GroupHeader1});
            this.ExportOptions.Image.Format = System.Drawing.Imaging.ImageFormat.Jpeg;
            this.Version = "13.2";
            this.DataSourceRequested += new Procwork.Software.Framework.Reports.SondaBaseReport.DataSourceRequestedEvent(this.RptTreinamento_DataSourceRequested);
            this.Controls.SetChildIndex(this.GroupHeader1, 0);
            this.Controls.SetChildIndex(this.Rodape, 0);
            this.Controls.SetChildIndex(this.Cabecalho, 0);
            this.Controls.SetChildIndex(this.Detalhes, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdsReportSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
    }
}