
namespace databaseprojlast
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.masterDataSet2 = new databaseprojlast.masterDataSet2();
            this.AIRCRAFTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AIRCRAFTTableAdapter = new databaseprojlast.masterDataSet2TableAdapters.AIRCRAFTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AIRCRAFTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.AIRCRAFTBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "databaseprojlast.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(62, 46);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(691, 297);
            this.reportViewer1.TabIndex = 0;
            // 
            // masterDataSet2
            // 
            this.masterDataSet2.DataSetName = "masterDataSet2";
            this.masterDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AIRCRAFTBindingSource
            // 
            this.AIRCRAFTBindingSource.DataMember = "AIRCRAFT";
            this.AIRCRAFTBindingSource.DataSource = this.masterDataSet2;
            // 
            // AIRCRAFTTableAdapter
            // 
            this.AIRCRAFTTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AIRCRAFTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource AIRCRAFTBindingSource;
        private masterDataSet2 masterDataSet2;
        private masterDataSet2TableAdapters.AIRCRAFTTableAdapter AIRCRAFTTableAdapter;
    }
}