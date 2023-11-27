namespace ByteCare
{
    partial class Form_ExistingPatientData
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
            this.patientTable = new System.Windows.Forms.DataGridView();
            this.patientNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.patientTable)).BeginInit();
            this.SuspendLayout();
            // 
            // patientTable
            // 
            this.patientTable.AllowUserToAddRows = false;
            this.patientTable.AllowUserToDeleteRows = false;
            this.patientTable.AllowUserToOrderColumns = true;
            this.patientTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientTable.Location = new System.Drawing.Point(0, 0);
            this.patientTable.Name = "patientTable";
            this.patientTable.ReadOnly = true;
            this.patientTable.RowHeadersWidth = 51;
            this.patientTable.RowTemplate.Height = 24;
            this.patientTable.Size = new System.Drawing.Size(982, 653);
            this.patientTable.TabIndex = 0;
            this.patientTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientTable_CellContentClick);
            // 
            // patientNo
            // 
            this.patientNo.HeaderText = "No.";
            this.patientNo.MinimumWidth = 6;
            this.patientNo.Name = "patientNo";
            this.patientNo.ReadOnly = true;
            this.patientNo.Width = 6;
            // 
            // Form_ExistingPatientData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.patientTable);
            this.Name = "Form_ExistingPatientData";
            this.Text = "Existing Patients";
            ((System.ComponentModel.ISupportInitialize)(this.patientTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView patientTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientNo;
    }
}