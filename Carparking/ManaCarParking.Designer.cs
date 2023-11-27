namespace Carparking
{
    partial class ManaCarParking
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
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parkedDaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.PricetextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AreatextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Addbutton = new System.Windows.Forms.Button();
            this.Editbutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IDsearchtextBox = new System.Windows.Forms.TextBox();
            this.AreaSearchtextBox = new System.Windows.Forms.TextBox();
            this.userDataDataSet10 = new Carparking.UserDataDataSet10();
            this.parkingSpaceDbBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.parkingSpaceDbTableAdapter1 = new Carparking.UserDataDataSet10TableAdapters.ParkingSpaceDbTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingSpaceDbBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.iDCarDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn,
            this.parkedDaysDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.parkingSpaceDbBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(102, 456);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(994, 305);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDCarDataGridViewTextBoxColumn
            // 
            this.iDCarDataGridViewTextBoxColumn.DataPropertyName = "IDCar";
            this.iDCarDataGridViewTextBoxColumn.HeaderText = "IDCar";
            this.iDCarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDCarDataGridViewTextBoxColumn.Name = "iDCarDataGridViewTextBoxColumn";
            this.iDCarDataGridViewTextBoxColumn.Width = 125;
            // 
            // areaDataGridViewTextBoxColumn
            // 
            this.areaDataGridViewTextBoxColumn.DataPropertyName = "Area";
            this.areaDataGridViewTextBoxColumn.HeaderText = "Area";
            this.areaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            this.areaDataGridViewTextBoxColumn.Width = 125;
            // 
            // parkedDaysDataGridViewTextBoxColumn
            // 
            this.parkedDaysDataGridViewTextBoxColumn.DataPropertyName = "ParkedDays";
            this.parkedDaysDataGridViewTextBoxColumn.HeaderText = "ParkedDays";
            this.parkedDaysDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parkedDaysDataGridViewTextBoxColumn.Name = "parkedDaysDataGridViewTextBoxColumn";
            this.parkedDaysDataGridViewTextBoxColumn.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // IDtextBox
            // 
            this.IDtextBox.Location = new System.Drawing.Point(226, 85);
            this.IDtextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.Size = new System.Drawing.Size(112, 26);
            this.IDtextBox.TabIndex = 2;
            // 
            // PricetextBox
            // 
            this.PricetextBox.Location = new System.Drawing.Point(226, 152);
            this.PricetextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PricetextBox.Name = "PricetextBox";
            this.PricetextBox.Size = new System.Drawing.Size(112, 26);
            this.PricetextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price:";
            // 
            // AreatextBox
            // 
            this.AreatextBox.Location = new System.Drawing.Point(558, 85);
            this.AreatextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AreatextBox.Name = "AreatextBox";
            this.AreatextBox.Size = new System.Drawing.Size(112, 26);
            this.AreatextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(502, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Area:";
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(432, 146);
            this.Addbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(90, 62);
            this.Addbutton.TabIndex = 7;
            this.Addbutton.Text = "Add";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // Editbutton
            // 
            this.Editbutton.Location = new System.Drawing.Point(593, 146);
            this.Editbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Editbutton.Name = "Editbutton";
            this.Editbutton.Size = new System.Drawing.Size(90, 62);
            this.Editbutton.TabIndex = 8;
            this.Editbutton.Text = "Edit";
            this.Editbutton.UseVisualStyleBackColor = true;
            this.Editbutton.Click += new System.EventHandler(this.Editbutton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.Location = new System.Drawing.Point(757, 146);
            this.Deletebutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(90, 62);
            this.Deletebutton.TabIndex = 9;
            this.Deletebutton.Text = "Delete";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Search By ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(555, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Search By Area";
            // 
            // IDsearchtextBox
            // 
            this.IDsearchtextBox.Location = new System.Drawing.Point(262, 319);
            this.IDsearchtextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IDsearchtextBox.Name = "IDsearchtextBox";
            this.IDsearchtextBox.Size = new System.Drawing.Size(112, 26);
            this.IDsearchtextBox.TabIndex = 12;
            this.IDsearchtextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.IDsearchtextBox_KeyUp);
            // 
            // AreaSearchtextBox
            // 
            this.AreaSearchtextBox.Location = new System.Drawing.Point(675, 319);
            this.AreaSearchtextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AreaSearchtextBox.Name = "AreaSearchtextBox";
            this.AreaSearchtextBox.Size = new System.Drawing.Size(112, 26);
            this.AreaSearchtextBox.TabIndex = 13;
            this.AreaSearchtextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AreaSearchtextBox_KeyUp);
            // 
            // userDataDataSet10
            // 
            this.userDataDataSet10.DataSetName = "UserDataDataSet10";
            this.userDataDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parkingSpaceDbBindingSource1
            // 
            this.parkingSpaceDbBindingSource1.DataMember = "ParkingSpaceDb";
            this.parkingSpaceDbBindingSource1.DataSource = this.userDataDataSet10;
            // 
            // parkingSpaceDbTableAdapter1
            // 
            this.parkingSpaceDbTableAdapter1.ClearBeforeFill = true;
            // 
            // ManaCarParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 776);
            this.Controls.Add(this.AreaSearchtextBox);
            this.Controls.Add(this.IDsearchtextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.Editbutton);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.AreatextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PricetextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDtextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ManaCarParking";
            this.Text = "ManaCarParking";
            this.Load += new System.EventHandler(this.ManaCarParking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingSpaceDbBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parkedDaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDtextBox;
        private System.Windows.Forms.TextBox PricetextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AreatextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button Editbutton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IDsearchtextBox;
        private System.Windows.Forms.TextBox AreaSearchtextBox;
        private UserDataDataSet10 userDataDataSet10;
        private System.Windows.Forms.BindingSource parkingSpaceDbBindingSource1;
        private UserDataDataSet10TableAdapters.ParkingSpaceDbTableAdapter parkingSpaceDbTableAdapter1;
    }
}