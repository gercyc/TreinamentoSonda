
namespace Procwork.Software.SATI.COM.Servers.Treinamento
{
    partial class CtmTreinamentoController
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.boTreinamento = new Procwork.Software.Framework.Server.BaseClasses.BusinessObject(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.boTreinamento)).BeginInit();
            // 
            // boTreinamento
            // 
            this.boTreinamento.AutoIncField = "ID";
            this.boTreinamento.BusinessListUnitAlias.AddRange(new string[] {
            "BUS_ID"});
            this.boTreinamento.BusinessObjectId = "TREINAMENTO";
            this.boTreinamento.BusinessServer = this;
            this.boTreinamento.ContinueOnError = false;
            this.boTreinamento.CustomerListAlias.AddRange(new string[] {
            "CUS_ID"});
            this.boTreinamento.DatabaseObject = "TREINAMENTO";
            this.boTreinamento.MasterBusinessObject = true;
            this.boTreinamento.ParentBusinessObject = null;
            this.boTreinamento.PrimaryKeyFields.AddRange(new string[] {
            "ID"});
            this.boTreinamento.ReadOnly = false;
            this.boTreinamento.SameTransaction = false;
            this.boTreinamento.SQLDistinct = false;
            this.boTreinamento.TableAlias = "TREINAMENTO";
            this.boTreinamento.Transaction = true;
            ((System.ComponentModel.ISupportInitialize)(this.boTreinamento)).EndInit();

        }

        #endregion

        private Framework.Server.BaseClasses.BusinessObject boTreinamento;
    }
}
