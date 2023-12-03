namespace Carparking
{
    partial class AttRetrieve
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
            this.iDRequestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carBrandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDParkRequestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaRequestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resquestDbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userDataDataSet7 = new Carparking.UserDataDataSet7();
            this.AssistButton = new System.Windows.Forms.Button();
            this.IDrequesttextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resquestDbTableAdapter = new Carparking.UserDataDataSet7TableAdapters.ResquestDbTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resquestDbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDRequestDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.iDCustomerDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.iDCarDataGridViewTextBoxColumn,
            this.carBrandDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.iDParkRequestDataGridViewTextBoxColumn,
            this.areaRequestDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.resquestDbBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 253);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1246, 202);
            this.dataGridView1.TabIndex = 9;
            // 
            // iDRequestDataGridViewTextBoxColumn
            // 
            this.iDRequestDataGridViewTextBoxColumn.DataPropertyName = "IDRequest";
            this.iDRequestDataGridViewTextBoxColumn.HeaderText = "IDRequest";
            this.iDRequestDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDRequestDataGridViewTextBoxColumn.Name = "iDRequestDataGridViewTextBoxColumn";
            this.iDRequestDataGridViewTextBoxColumn.Width = 125;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDCustomerDataGridViewTextBoxColumn
            // 
            this.iDCustomerDataGridViewTextBoxColumn.DataPropertyName = "IDCustomer";
            this.iDCustomerDataGridViewTextBoxColumn.HeaderText = "IDCustomer";
            this.iDCustomerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDCustomerDataGridViewTextBoxColumn.Name = "iDCustomerDataGridViewTextBoxColumn";
            this.iDCustomerDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDCarDataGridViewTextBoxColumn
            // 
            this.iDCarDataGridViewTextBoxColumn.DataPropertyName = "IDCar";
            this.iDCarDataGridViewTextBoxColumn.HeaderText = "IDCar";
            this.iDCarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDCarDataGridViewTextBoxColumn.Name = "iDCarDataGridViewTextBoxColumn";
            this.iDCarDataGridViewTextBoxColumn.Width = 125;
            // 
            // carBrandDataGridViewTextBoxColumn
            // 
            this.carBrandDataGridViewTextBoxColumn.DataPropertyName = "CarBrand";
            this.carBrandDataGridViewTextBoxColumn.HeaderText = "CarBrand";
            this.carBrandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carBrandDataGridViewTextBoxColumn.Name = "carBrandDataGridViewTextBoxColumn";
            this.carBrandDataGridViewTextBoxColumn.Width = 125;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDParkRequestDataGridViewTextBoxColumn
            // 
            this.iDParkRequestDataGridViewTextBoxColumn.DataPropertyName = "IDParkRequest";
            this.iDParkRequestDataGridViewTextBoxColumn.HeaderText = "IDParkRequest";
            this.iDParkRequestDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDParkRequestDataGridViewTextBoxColumn.Name = "iDParkRequestDataGridViewTextBoxColumn";
            this.iDParkRequestDataGridViewTextBoxColumn.Width = 125;
            // 
            // areaRequestDataGridViewTextBoxColumn
            // 
            this.areaRequestDataGridViewTextBoxColumn.DataPropertyName = "AreaRequest";
            this.areaRequestDataGridViewTextBoxColumn.HeaderText = "AreaRequest";
            this.areaRequestDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.areaRequestDataGridViewTextBoxColumn.Name = "areaRequestDataGridViewTextBoxColumn";
            this.areaRequestDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // resquestDbBindingSource
            // 
            this.resquestDbBindingSource.DataMember = "ResquestDb";
            this.resquestDbBindingSource.DataSource = this.userDataDataSet7;
            // 
            // userDataDataSet7
            // 
            this.userDataDataSet7.DataSetName = "UserDataDataSet7";
            this.userDataDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AssistButton
            // 
            this.AssistButton.Location = new System.Drawing.Point(323, 62);
            this.AssistButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AssistButton.Name = "AssistButton";
            this.AssistButton.Size = new System.Drawing.Size(145, 32);
            this.AssistButton.TabIndex = 12;
            this.AssistButton.Text = "Assist Parking ";
            this.AssistButton.UseVisualStyleBackColor = true;
            this.AssistButton.Click += new System.EventHandler(this.AssistButton_Click);
            // 
            // IDrequesttextBox
            // 
            this.IDrequesttextBox.Location = new System.Drawing.Point(144, 67);
            this.IDrequesttextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IDrequesttextBox.Name = "IDrequesttextBox";
            this.IDrequesttextBox.Size = new System.Drawing.Size(89, 22);
            this.IDrequesttextBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Select Request";
            // 
            // resquestDbTableAdapter
            // 
            this.resquestDbTableAdapter.ClearBeforeFill = true;
            // 
            // AttRetrieve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 528);
            this.Controls.Add(this.AssistButton);
            this.Controls.Add(this.IDrequesttextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AttRetrieve";
            this.Text = "AttRetrieve";
            this.Load += new System.EventHandler(this.AttRetrieve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resquestDbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AssistButton;
        private System.Windows.Forms.TextBox IDrequesttextBox;
        private System.Windows.Forms.Label label1;
        private UserDataDataSet7 userDataDataSet7;
        private System.Windows.Forms.BindingSource resquestDbBindingSource;
        private UserDataDataSet7TableAdapters.ResquestDbTableAdapter resquestDbTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRequestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carBrandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDParkRequestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaRequestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}