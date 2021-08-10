
namespace Procwork.Software.SATI.COM.Windows.Teste
{
    partial class FrmViewTreinamento
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
            this.dS_Treinamento1 = new Procwork.Software.SATI.COM.Common.Treinamento.DS_Treinamento();
            this.pwLabelEdit1 = new Procwork.Software.Framework.Windows.Classes.Components.pwLabelEdit();
            this.pwLabelEdit2 = new Procwork.Software.Framework.Windows.Classes.Components.pwLabelEdit();
            this.pwLabelEdit3 = new Procwork.Software.Framework.Windows.Classes.Components.pwLabelEdit();
            this.pwLabelEdit4 = new Procwork.Software.Framework.Windows.Classes.Components.pwLabelEdit();
            this.DefaultTabPage.SuspendLayout();
            this.pnlControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DBDefaultBinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DefaultRemote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppTopLogo)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFavoritos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Treinamento1)).BeginInit();
            this.SuspendLayout();
            // 
            // tspMenu
            // 
            this._drag.SetDraggable(this.tspMenu, false);
            this.tspMenu.Size = new System.Drawing.Size(469, 41);
            // 
            // DefaultTabControl
            // 
            this._drag.SetDraggable(this.DefaultTabControl, false);
            this.DefaultTabControl.Size = new System.Drawing.Size(469, 162);
            // 
            // DefaultTabPage
            // 
            this._drag.SetDraggable(this.DefaultTabPage, false);
            this.DefaultTabPage.Size = new System.Drawing.Size(467, 160);
            // 
            // pnlControles
            // 
            this.pnlControles.Controls.Add(this.pwLabelEdit4);
            this.pnlControles.Controls.Add(this.pwLabelEdit3);
            this._drag.SetDraggable(this.pnlControles, false);
            this.pnlControles.Size = new System.Drawing.Size(467, 160);
            // 
            // pnlHideBar
            // 
            this._drag.SetDraggable(this.pnlHideBar, false);
            // 
            // DBDefaultBinding
            // 
            this.DBDefaultBinding.DataMember = "TREINAMENTO";
            this.DBDefaultBinding.DataSource = this.dS_Treinamento1;
            // 
            // DefaultRemote
            // 
            this.DefaultRemote.BusinessObject = "TREINAMENTO";
            this.DefaultRemote.BusinessServer = "Procwork.Software.SATI.COM.Servers.Treinamento.CtmTreinamentoController.soap";
            // 
            // ppTopLogo
            // 
            this._drag.SetDraggable(this.ppTopLogo, false);
            // 
            // lblTitulo
            // 
            this._drag.SetDraggable(this.lblTitulo, false);
            // 
            // ProcTransactionControl
            // 
            this.ProcTransactionControl.DeleteConfirmation = true;
            this.ProcTransactionControl.DeleteWarning = true;
            this.ProcTransactionControl.TsbFirst = false;
            this.ProcTransactionControl.TsbLast = false;
            this.ProcTransactionControl.TsbNext = false;
            this.ProcTransactionControl.TsbPrevious = false;
            // 
            // dS_Treinamento1
            // 
            this.dS_Treinamento1.DataSetName = "DS_Treinamento";
            this.dS_Treinamento1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pwLabelEdit1
            // 
            this.pwLabelEdit1.BackcolorText = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pwLabelEdit1.ControlText = "";
            this._drag.SetDraggable(this.pwLabelEdit1, false);
            this.pwLabelEdit1.ForecolorText = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.pwLabelEdit1.LabelText = "Text";
            this.pwLabelEdit1.Location = new System.Drawing.Point(12, 65);
            this.pwLabelEdit1.Name = "pwLabelEdit1";
            this.pwLabelEdit1.PasswordChar = '\0';
            this.pwLabelEdit1.ReadOnly = false;
            this.pwLabelEdit1.Size = new System.Drawing.Size(170, 45);
            this.pwLabelEdit1.TabIndex = 26;
            // 
            // pwLabelEdit2
            // 
            this.pwLabelEdit2.BackcolorText = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pwLabelEdit2.ControlText = "";
            this._drag.SetDraggable(this.pwLabelEdit2, false);
            this.pwLabelEdit2.ForecolorText = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.pwLabelEdit2.LabelText = "Text";
            this.pwLabelEdit2.Location = new System.Drawing.Point(12, 116);
            this.pwLabelEdit2.Name = "pwLabelEdit2";
            this.pwLabelEdit2.PasswordChar = '\0';
            this.pwLabelEdit2.ReadOnly = false;
            this.pwLabelEdit2.Size = new System.Drawing.Size(170, 45);
            this.pwLabelEdit2.TabIndex = 27;
            // 
            // pwLabelEdit3
            // 
            this.pwLabelEdit3.BackcolorText = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pwLabelEdit3.ControlText = "";
            this.pwLabelEdit3.DataBindings.Add(new System.Windows.Forms.Binding("ControlText", this.DBDefaultBinding, "NOME", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, ""));
            this._drag.SetDraggable(this.pwLabelEdit3, false);
            this.pwLabelEdit3.ForecolorText = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.pwLabelEdit3.LabelText = "Nome";
            this.pwLabelEdit3.Location = new System.Drawing.Point(11, 23);
            this.pwLabelEdit3.Name = "pwLabelEdit3";
            this.pwLabelEdit3.PasswordChar = '\0';
            this.pwLabelEdit3.ReadOnly = false;
            this.pwLabelEdit3.Size = new System.Drawing.Size(155, 34);
            this.pwLabelEdit3.TabIndex = 0;
            // 
            // pwLabelEdit4
            // 
            this.pwLabelEdit4.BackcolorText = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pwLabelEdit4.ControlText = "";
            this.pwLabelEdit4.DataBindings.Add(new System.Windows.Forms.Binding("ControlText", this.DBDefaultBinding, "DATA", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, ""));
            this._drag.SetDraggable(this.pwLabelEdit4, false);
            this.pwLabelEdit4.ForecolorText = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.pwLabelEdit4.LabelText = "Data";
            this.pwLabelEdit4.Location = new System.Drawing.Point(11, 85);
            this.pwLabelEdit4.Name = "pwLabelEdit4";
            this.pwLabelEdit4.PasswordChar = '\0';
            this.pwLabelEdit4.ReadOnly = false;
            this.pwLabelEdit4.Size = new System.Drawing.Size(155, 34);
            this.pwLabelEdit4.TabIndex = 1;
            // 
            // FrmViewTreinamento
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 231);
            this.Controls.Add(this.pwLabelEdit2);
            this.Controls.Add(this.pwLabelEdit1);
            this._drag.SetDraggable(this, false);
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.LookAndFeel.SkinName = "Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "FrmViewTreinamento";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "FrmViewTreinamento";
            this.Controls.SetChildIndex(this.pwLabelEdit1, 0);
            this.Controls.SetChildIndex(this.pwLabelEdit2, 0);
            this.Controls.SetChildIndex(this.DefaultTabControl, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.pnlHideBar, 0);
            this.Controls.SetChildIndex(this.tspMenu, 0);
            this.DefaultTabPage.ResumeLayout(false);
            this.pnlControles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DBDefaultBinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DefaultRemote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppTopLogo)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFavoritos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Treinamento1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Common.Treinamento.DS_Treinamento dS_Treinamento1;
        private Framework.Windows.Classes.Components.pwLabelEdit pwLabelEdit1;
        private Framework.Windows.Classes.Components.pwLabelEdit pwLabelEdit2;
        private Framework.Windows.Classes.Components.pwLabelEdit pwLabelEdit4;
        private Framework.Windows.Classes.Components.pwLabelEdit pwLabelEdit3;
    }
}