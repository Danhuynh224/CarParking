namespace Carparking
{
    partial class CusRequestForm
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
            this.idcar_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.carbrand_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.color_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.arearq_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.idpark_textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sendreq_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.userDataDataSet16 = new Carparking.UserDataDataSet16();
            this.parkingSpaceDbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parkingSpaceDbTableAdapter = new Carparking.UserDataDataSet16TableAdapters.ParkingSpaceDbTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateParkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingSpaceDbBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idcar_textbox
            // 
            this.idcar_textbox.Location = new System.Drawing.Point(182, 95);
            this.idcar_textbox.Name = "idcar_textbox";
            this.idcar_textbox.Size = new System.Drawing.Size(125, 22);
            this.idcar_textbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "IDCar";
            // 
            // carbrand_textbox
            // 
            this.carbrand_textbox.Location = new System.Drawing.Point(182, 149);
            this.carbrand_textbox.Name = "carbrand_textbox";
            this.carbrand_textbox.Size = new System.Drawing.Size(125, 22);
            this.carbrand_textbox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "CarBrand";
            // 
            // color_textbox
            // 
            this.color_textbox.Location = new System.Drawing.Point(650, 38);
            this.color_textbox.Name = "color_textbox";
            this.color_textbox.Size = new System.Drawing.Size(139, 22);
            this.color_textbox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(517, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Color";
            // 
            // arearq_textbox
            // 
            this.arearq_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arearq_textbox.Location = new System.Drawing.Point(650, 95);
            this.arearq_textbox.Name = "arearq_textbox";
            this.arearq_textbox.Size = new System.Drawing.Size(139, 22);
            this.arearq_textbox.TabIndex = 9;
            this.arearq_textbox.Text = "Optional";
            this.arearq_textbox.Click += new System.EventHandler(this.arearq_textbox_Click);
            this.arearq_textbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.arearq_textbox_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(517, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "AreaRequest";
            // 
            // idpark_textbox
            // 
            this.idpark_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idpark_textbox.Location = new System.Drawing.Point(650, 149);
            this.idpark_textbox.Name = "idpark_textbox";
            this.idpark_textbox.Size = new System.Drawing.Size(139, 22);
            this.idpark_textbox.TabIndex = 11;
            this.idpark_textbox.Text = "Optional";
            this.idpark_textbox.Click += new System.EventHandler(this.idpark_textbox_Click);
            this.idpark_textbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.idpark_textbox_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(517, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "IDParkRequest";
            // 
            // sendreq_button
            // 
            this.sendreq_button.Location = new System.Drawing.Point(386, 232);
            this.sendreq_button.Name = "sendreq_button";
            this.sendreq_button.Size = new System.Drawing.Size(159, 51);
            this.sendreq_button.TabIndex = 12;
            this.sendreq_button.Text = "Send Request";
            this.sendreq_button.UseVisualStyleBackColor = true;
            this.sendreq_button.Click += new System.EventHandler(this.sendreq_button_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(30, 300);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(801, 244);
            this.dataGridView1.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(182, 192);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(240, 22);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Date";
            // 
            // userDataDataSet16
            // 
            this.userDataDataSet16.DataSetName = "UserDataDataSet16";
            this.userDataDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parkingSpaceDbBindingSource
            // 
            this.parkingSpaceDbBindingSource.DataMember = "ParkingSpaceDb";
            this.parkingSpaceDbBindingSource.DataSource = this.userDataDataSet16;
            // 
            // parkingSpaceDbTableAdapter
            // 
            this.parkingSpaceDbTableAdapter.ClearBeforeFill = true;
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
            // CusRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 556);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sendreq_button);
            this.Controls.Add(this.idpark_textbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.arearq_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.color_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.carbrand_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idcar_textbox);
            this.Controls.Add(this.label2);
            this.Name = "CusRequestForm";
            this.Text = "CusRequestForm";
            this.Load += new System.EventHandler(this.CusRequestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingSpaceDbBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox idcar_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox carbrand_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox color_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox arearq_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idpark_textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button sendreq_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private UserDataDataSet16 userDataDataSet16;
        private System.Windows.Forms.BindingSource parkingSpaceDbBindingSource;
        private UserDataDataSet16TableAdapters.ParkingSpaceDbTableAdapter parkingSpaceDbTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateParkDataGridViewTextBoxColumn;
    }
}