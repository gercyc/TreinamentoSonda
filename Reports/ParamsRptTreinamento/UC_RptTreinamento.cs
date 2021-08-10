using Procwork.Software.Framework.BaseClasses;
using Procwork.Software.Framework.Windows.Forms;
using Procwork.Software.Framework.Windows.Forms.BaseForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Procwork.Software.SATI.COM.Common.ParamsRptTreinamento
{
    public partial class UC_RptTreinamento : JobReportParamsBuilder
    {
        public UC_RptTreinamento()
        {
            InitializeComponent();
        }
        public UC_RptTreinamento(BasicJobParams parentForm) : base(parentForm)
        {
            InitializeComponent();            
        }

        private void UC_RptTreinamento_Load(object sender, EventArgs e)
        {
            try
            {
                //Atribui o ProcTools ao UC, não retirar senão num funfa.
                ucMatrizFilialCusBus1.WinProcTools = (ParentForm as StandardTransaction).WindowsProcTools;
                ucMatrizFilialCusBus1.LoadMatrizFilial(true);
            }
            catch (Exception ex)
            {
                Utils.WriteEventLog(ex, "Params Rpt Treinamento");
            }
        }
        public override object GetParameterValue(PWDictionaryColumnInfo currentParam)
        {
            //Obtem os parâmetros informados para geração do relatório
            //A tabela de parâmetros deverá ser criada e os campos iguais aos valores do CASE.
            //
            object returnValue = string.Empty;

            switch (currentParam.ColumnId)
            {
                case "P_DATA_INI":
                    returnValue = dateTimePicker1.Value;
                    break;
                case "P_DATA_FIM":
                    returnValue = dateTimePicker2.Value;
                    break;
                case "P_MATRIZ":
                        returnValue = ucMatrizFilialCusBus1.CodMatriz;
                    break;
                case "P_FILIAL":
                        returnValue = ucMatrizFilialCusBus1.CodFilial;
                    break;
            }
            return returnValue;
        }

        public override object GetParameterText(PWDictionaryColumnInfo currentParam)
        {
            //Obtem o texto dos parâmetros, necessário implementar igual ao método GetParameterValue()
            // ou então simplesmente chamar o GetParameterValue():
            // return GetParameterValue(currentParam) <<-- As vezes pode zuar.
            object returnValue = string.Empty;

            switch (currentParam.ColumnId)
            {
                case "P_DATA_INI":
                    returnValue = dateTimePicker1.Value;
                    break;
                case "P_DATA_FIM":
                    returnValue = dateTimePicker2.Value;
                    break;
                case "P_MATRIZ":
                    returnValue = ucMatrizFilialCusBus1.CodMatriz;
                    break;
                case "P_FILIAL":
                    returnValue = ucMatrizFilialCusBus1.CodFilial;
                    break;
            }
            return returnValue;
        }


    }
}
