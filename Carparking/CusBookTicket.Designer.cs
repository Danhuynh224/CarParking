namespace Carparking
{
    partial class CusBookTicket
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
            this.label1 = new System.Windows.Forms.Label();
            this.IDParktextBox = new System.Windows.Forms.TextBox();
            this.ParkAreatextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IDCartextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateParkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parkingSpaceDbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userDataDataSet12 = new Carparking.UserDataDataSet12();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Parkbutton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.CarBrandtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CarColortextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.parkingSpaceDbTableAdapter = new Carparking.UserDataDataSet12TableAdapters.ParkingSpaceDbTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingSpaceDbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataDataSet12)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // IDParktextBox
            // 
            this.IDParktextBox.Location = new System.Drawing.Point(200, 79);
            this.IDParktextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IDParktextBox.Name = "IDParktextBox";
            this.IDParktextBox.Size = new System.Drawing.Size(178, 22);
            this.IDParktextBox.TabIndex = 1;
            this.IDParktextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.IDParktextBox_KeyUp);
            // 
            // ParkAreatextBox
            // 
            this.ParkAreatextBox.Location = new System.Drawing.Point(200, 130);
            this.ParkAreatextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ParkAreatextBox.Name = "ParkAreatextBox";
            this.ParkAreatextBox.Size = new System.Drawing.Size(178, 22);
            this.ParkAreatextBox.TabIndex = 3;
            this.ParkAreatextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ParkAreatextBox_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Park Area";
            // 
            // IDCartextBox
            // 
            this.IDCartextBox.Location = new System.Drawing.Point(200, 170);
            this.IDCartextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IDCartextBox.Name = "IDCartextBox";
            this.IDCartextBox.Size = new System.Drawing.Size(178, 22);
            this.IDCartextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Car ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Available Slot";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.iDCarDataGridViewTextBoxColumn,
            this.dateParkDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.parkingSpaceDbBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(177, 380);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(861, 185);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // areaDataGridViewTextBoxColumn
            // 
            this.areaDataGridViewTextBoxColumn.DataPropertyName = "Area";
            this.areaDataGridViewTextBoxColumn.HeaderText = "Area";
            this.areaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            this.areaDataGridViewTextBoxColumn.Width = 125;
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
            // dateParkDataGridViewTextBoxColumn
            // 
            this.dateParkDataGridViewTextBoxColumn.DataPropertyName = "DatePark";
            this.dateParkDataGridViewTextBoxColumn.HeaderText = "DatePark";
            this.dateParkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateParkDataGridViewTextBoxColumn.Name = "dateParkDataGridViewTextBoxColumn";
            this.dateParkDataGridViewTextBoxColumn.Width = 125;
            // 
            // parkingSpaceDbBindingSource
            // 
            this.parkingSpaceDbBindingSource.DataMember = "ParkingSpaceDb";
            this.parkingSpaceDbBindingSource.DataSource = this.userDataDataSet12;
            // 
            // userDataDataSet12
            // 
            this.userDataDataSet12.DataSetName = "UserDataDataSet12";
            this.userDataDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(201, 264);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(268, 22);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.Value = new System.DateTime(2023, 11, 29, 11, 30, 0, 0);
            // 
            // Parkbutton
            // 
            this.Parkbutton.Location = new System.Drawing.Point(571, 256);
            this.Parkbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Parkbutton.Name = "Parkbutton";
            this.Parkbutton.Size = new System.Drawing.Size(166, 40);
            this.Parkbutton.TabIndex = 14;
            this.Parkbutton.Text = "Parking";
            this.Parkbutton.UseVisualStyleBackColor = true;
            this.Parkbutton.Click += new System.EventHandler(this.Parkbutton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(818, 256);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 40);
            this.button3.TabIndex = 16;
            this.button3.Text = "Log Out";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // CarBrandtextBox
            // 
            this.CarBrandtextBox.Location = new System.Drawing.Point(201, 207);
            this.CarBrandtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CarBrandtextBox.Name = "CarBrandtextBox";
            this.CarBrandtextBox.Size = new System.Drawing.Size(178, 22);
            this.CarBrandtextBox.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Car Brand";
            // 
            // CarColortextBox
            // 
            this.CarColortextBox.Location = new System.Drawing.Point(691, 85);
            this.CarColortextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CarColortextBox.Name = "CarColortextBox";
            this.CarColortextBox.Size = new System.Drawing.Size(178, 22);
            this.CarColortextBox.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(581, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Car Color";
            // 
            // parkingSpaceDbTableAdapter
            // 
            this.parkingSpaceDbTableAdapter.ClearBeforeFill = true;
            // 
            // CusBookTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 576);
            this.Controls.Add(this.CarColortextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CarBrandtextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Parkbutton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.IDCartextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ParkAreatextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDParktextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CusBookTicket";
            this.Text = "CusBookTicket";
            this.Load += new System.EventHandler(this.CusBookTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingSpaceDbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataDataSet12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDParktextBox;
        private System.Windows.Forms.TextBox ParkAreatextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IDCartextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Parkbutton;
        private System.Windows.Forms.Button button3;
        protected System.Windows.Forms.TextBox CarBrandtextBox;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.TextBox CarColortextBox;
        protected System.Windows.Forms.Label label5;
        private UserDataDataSet12 userDataDataSet12;
        private System.Windows.Forms.BindingSource parkingSpaceDbBindingSource;
        private UserDataDataSet12TableAdapters.ParkingSpaceDbTableAdapter parkingSpaceDbTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateParkDataGridViewTextBoxColumn;
    }
}