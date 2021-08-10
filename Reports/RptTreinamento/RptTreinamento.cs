using Procwork.Software.Framework.Reports;
using Procwork.Software.Framework.Reports.BaseClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Procwork.Software.SATI.COM.Report.RptTreinamento
{
    [SondaReport("{9729e8d9-004d-4c19-9def-974f74946027}")]
    public partial class RptTreinamento : SondaBaseReport
    {
        public RptTreinamento()
        {
            InitializeComponent();
        }

        private void RptTreinamento_DataSourceRequested(ReportSourceEventArgs e)
        {
            string matriz = (e.ReportParameters.Find(p => p.Name == "P_MATRIZ").CurrentValue);
            string filial = (e.ReportParameters.Find(p => p.Name == "P_FILIAL").CurrentValue);
            DateTime dtInicio = Convert.ToDateTime(e.ReportParameters.Find(p => p.Name == "P_DATA_INI").Value);
            DateTime dtFim = Convert.ToDateTime(e.ReportParameters.Find(p => p.Name == "P_DATA_FIM").Value);
            List<DataClass> reportSource = new List<DataClass>();
            reportSource.Add(new DataClass("0001", "Produto 1"));
            reportSource.Add(new DataClass("0002", "Produto 2"));
            reportSource.Add(new DataClass("0003", "Produto 3"));
            reportSource.Add(new DataClass("0004", "Produto 4"));
            reportSource.Add(new DataClass("0005", "Produto 5"));

            e.DataSource = reportSource;
        }
    }
}
