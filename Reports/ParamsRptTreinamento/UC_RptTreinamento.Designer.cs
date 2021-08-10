
namespace Procwork.Software.SATI.COM.Common.ParamsRptTreinamento
{
    partial class UC_RptTreinamento
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
            this.ucMatrizFilialCusBus1 = new Procwork.Software.Basic.Common.UC_Components.ucMatrizFilialCusBus();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.ucMatrizFilialCusBus1)).BeginInit();
            this.SuspendLayout();
            // 
            // ucMatrizFilialCusBus1
            // 
            this.ucMatrizFilialCusBus1.BackColor = System.Drawing.Color.Transparent;
            this.ucMatrizFilialCusBus1.CusBusAccess = false;
            this.ucMatrizFilialCusBus1.EnabledFilial = true;
            this.ucMatrizFilialCusBus1.EnabledMatriz = true;
            this.ucMatrizFilialCusBus1.Location = new System.Drawing.Point(3, 3);
            this.ucMatrizFilialCusBus1.Name = "ucMatrizFilialCusBus1";
            this.ucMatrizFilialCusBus1.ReadOnly = false;
            this.ucMatrizFilialCusBus1.SelectedItemFilial = null;
            this.ucMatrizFilialCusBus1.SelectedItemMatriz = null;
            this.ucMatrizFilialCusBus1.Size = new System.Drawing.Size(531, 100);
            this.ucMatrizFilialCusBus1.TabIndex = 0;
            this.ucMatrizFilialCusBus1.WinProcTools = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Final";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 122);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(98, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(178, 122);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(98, 20);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // UC_RptTreinamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucMatrizFilialCusBus1);
            this.Name = "UC_RptTreinamento";
            this.Size = new System.Drawing.Size(554, 181);
            this.Load += new System.EventHandler(this.UC_RptTreinamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ucMatrizFilialCusBus1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Basic.Common.UC_Components.ucMatrizFilialCusBus ucMatrizFilialCusBus1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}
