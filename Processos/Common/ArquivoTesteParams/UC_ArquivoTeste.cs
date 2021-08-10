using Procwork.Software.Framework.Windows.Forms.BaseInterfaces;
using Procwork.Software.SATI.PROC.Common.CoordenadorProcesso;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Procwork.Software.SATI.COM.Common.ArquivoTesteParams
{
    public partial class UC_ArquivoTeste : UserControl, IControleParametrizacaoCustomizada
    {
        public UC_ArquivoTeste()
        {
            InitializeComponent();
        }
        public IParametrosExecucao ParametrosExecucao { get; set; }

        public void CarregarValores(Dictionary<string, object> valores)
        {
            
        }

        public void LoadControle(IWindowsProcTools procTools)
        {
            
        }

        public Dictionary<string, object> ObterValores()
        {
            var paramsGeracao = new Dictionary<string, object>();
            if (!string.IsNullOrEmpty(txtValor.Text))
                paramsGeracao.Add("P_VALOR", txtValor.Text);
            return paramsGeracao;
        }
    }
}
