using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Procwork.Software.SATI.COM.Report.RptTreinamento
{
    public class DataClass
    {
        public string CodProduto { get; set; }
        public string DescProduto { get; set; }
        public DataClass(string cod, string desc)
        {
            CodProduto = cod;
            DescProduto = desc;
        }
    }
}
