namespace Carparking
{
    partial class CusParking
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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parkingSpaceDbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userDataDataSet2 = new Carparking.UserDataDataSet2();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.parkingSpaceDbTableAdapter = new Carparking.UserDataDataSet2TableAdapters.ParkingSpaceDbTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingSpaceDbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataDataSet2)).BeginInit();
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView1.DataSource = this.parkingSpaceDbBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(49, 289);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(801, 244);
            this.dataGridView1.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Area";
            this.dataGridViewTextBoxColumn2.HeaderText = "Area";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn3.HeaderText = "Status";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "IDCar";
            this.dataGridViewTextBoxColumn5.HeaderText = "IDCar";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DatePark";
            this.dataGridViewTextBoxColumn6.HeaderText = "DatePark";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // parkingSpaceDbBindingSource
            // 
            this.parkingSpaceDbBindingSource.DataMember = "ParkingSpaceDb";
            this.parkingSpaceDbBindingSource.DataSource = this.userDataDataSet2;
            // 
            // userDataDataSet2
            // 
            this.userDataDataSet2.DataSetName = "UserDataDataSet2";
            this.userDataDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // parkingSpaceDbTableAdapter
            // 
            this.parkingSpaceDbTableAdapter.ClearBeforeFill = true;
            // 
            // CusParking
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
            this.Name = "CusParking";
            this.Text = "CusRequestForm";
            this.Load += new System.EventHandler(this.CusRequestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingSpaceDbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataDataSet2)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateParkDataGridViewTextBoxColumn;
        private UserDataDataSet2 userDataDataSet2;
        private System.Windows.Forms.BindingSource parkingSpaceDbBindingSource;
        private UserDataDataSet2TableAdapters.ParkingSpaceDbTableAdapter parkingSpaceDbTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}