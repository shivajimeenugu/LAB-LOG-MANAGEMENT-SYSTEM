namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTPINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sYSTEMNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEASONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERIODCOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOGDATEANDTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNDDATEANDTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logtableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logdb1DataSet = new WindowsFormsApplication1.logdb1DataSet();
            this.logtableTableAdapter = new WindowsFormsApplication1.logdb1DataSetTableAdapters.logtableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logtableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logdb1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.sTUDENTNAMEDataGridViewTextBoxColumn,
            this.sTUDENTPINDataGridViewTextBoxColumn,
            this.sYSTEMNAMEDataGridViewTextBoxColumn,
            this.iPDataGridViewTextBoxColumn,
            this.rEASONDataGridViewTextBoxColumn,
            this.pERIODCOUNTDataGridViewTextBoxColumn,
            this.lOGDATEANDTIMEDataGridViewTextBoxColumn,
            this.eNDDATEANDTIMEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.logtableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1151, 536);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(358, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(371, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "REFRESH DATA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // sTUDENTNAMEDataGridViewTextBoxColumn
            // 
            this.sTUDENTNAMEDataGridViewTextBoxColumn.DataPropertyName = "STUDENT_NAME";
            this.sTUDENTNAMEDataGridViewTextBoxColumn.HeaderText = "STUDENT_NAME";
            this.sTUDENTNAMEDataGridViewTextBoxColumn.Name = "sTUDENTNAMEDataGridViewTextBoxColumn";
            // 
            // sTUDENTPINDataGridViewTextBoxColumn
            // 
            this.sTUDENTPINDataGridViewTextBoxColumn.DataPropertyName = "STUDENT_PIN";
            this.sTUDENTPINDataGridViewTextBoxColumn.HeaderText = "STUDENT_PIN";
            this.sTUDENTPINDataGridViewTextBoxColumn.Name = "sTUDENTPINDataGridViewTextBoxColumn";
            // 
            // sYSTEMNAMEDataGridViewTextBoxColumn
            // 
            this.sYSTEMNAMEDataGridViewTextBoxColumn.DataPropertyName = "SYSTEM_NAME";
            this.sYSTEMNAMEDataGridViewTextBoxColumn.HeaderText = "SYSTEM_NAME";
            this.sYSTEMNAMEDataGridViewTextBoxColumn.Name = "sYSTEMNAMEDataGridViewTextBoxColumn";
            // 
            // iPDataGridViewTextBoxColumn
            // 
            this.iPDataGridViewTextBoxColumn.DataPropertyName = "IP";
            this.iPDataGridViewTextBoxColumn.HeaderText = "IP";
            this.iPDataGridViewTextBoxColumn.Name = "iPDataGridViewTextBoxColumn";
            // 
            // rEASONDataGridViewTextBoxColumn
            // 
            this.rEASONDataGridViewTextBoxColumn.DataPropertyName = "REASON";
            this.rEASONDataGridViewTextBoxColumn.HeaderText = "REASON";
            this.rEASONDataGridViewTextBoxColumn.Name = "rEASONDataGridViewTextBoxColumn";
            // 
            // pERIODCOUNTDataGridViewTextBoxColumn
            // 
            this.pERIODCOUNTDataGridViewTextBoxColumn.DataPropertyName = "PERIOD_COUNT";
            this.pERIODCOUNTDataGridViewTextBoxColumn.HeaderText = "PERIOD_COUNT";
            this.pERIODCOUNTDataGridViewTextBoxColumn.Name = "pERIODCOUNTDataGridViewTextBoxColumn";
            // 
            // lOGDATEANDTIMEDataGridViewTextBoxColumn
            // 
            this.lOGDATEANDTIMEDataGridViewTextBoxColumn.DataPropertyName = "LOG_DATE_AND_TIME";
            this.lOGDATEANDTIMEDataGridViewTextBoxColumn.HeaderText = "LOG_DATE_AND_TIME";
            this.lOGDATEANDTIMEDataGridViewTextBoxColumn.Name = "lOGDATEANDTIMEDataGridViewTextBoxColumn";
            // 
            // eNDDATEANDTIMEDataGridViewTextBoxColumn
            // 
            this.eNDDATEANDTIMEDataGridViewTextBoxColumn.DataPropertyName = "END_DATE_AND_TIME";
            this.eNDDATEANDTIMEDataGridViewTextBoxColumn.HeaderText = "END_DATE_AND_TIME";
            this.eNDDATEANDTIMEDataGridViewTextBoxColumn.Name = "eNDDATEANDTIMEDataGridViewTextBoxColumn";
            // 
            // logtableBindingSource
            // 
            this.logtableBindingSource.DataMember = "logtable";
            this.logtableBindingSource.DataSource = this.logdb1DataSet;
            // 
            // logdb1DataSet
            // 
            this.logdb1DataSet.DataSetName = "logdb1DataSet";
            this.logdb1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // logtableTableAdapter
            // 
            this.logtableTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1182, 632);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOG REPORT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logtableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logdb1DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private logdb1DataSet logdb1DataSet;
        private System.Windows.Forms.BindingSource logtableBindingSource;
        private logdb1DataSetTableAdapters.logtableTableAdapter logtableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUDENTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUDENTPINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sYSTEMNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEASONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERIODCOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOGDATEANDTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNDDATEANDTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}