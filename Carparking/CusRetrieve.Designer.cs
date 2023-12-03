namespace Carparking
{
    partial class CusRetrieve
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
            this.PrintButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ticketIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDParkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaParkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketDbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userDataDataSet6 = new Carparking.UserDataDataSet6();
            this.IdtickTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ticketDbTableAdapter = new Carparking.UserDataDataSet6TableAdapters.TicketDbTableAdapter();
            this.Retrievebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketDbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(279, 47);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(75, 44);
            this.PrintButton.TabIndex = 7;
            this.PrintButton.Text = "Print  Detail";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticketIDDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.nameCustomerDataGridViewTextBoxColumn,
            this.carIDDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.iDParkDataGridViewTextBoxColumn,
            this.areaParkDataGridViewTextBoxColumn,
            this.dateInDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ticketDbBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(966, 272);
            this.dataGridView1.TabIndex = 6;
            // 
            // ticketIDDataGridViewTextBoxColumn
            // 
            this.ticketIDDataGridViewTextBoxColumn.DataPropertyName = "TicketID";
            this.ticketIDDataGridViewTextBoxColumn.HeaderText = "TicketID";
            this.ticketIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ticketIDDataGridViewTextBoxColumn.Name = "ticketIDDataGridViewTextBoxColumn";
            this.ticketIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameCustomerDataGridViewTextBoxColumn
            // 
            this.nameCustomerDataGridViewTextBoxColumn.DataPropertyName = "NameCustomer";
            this.nameCustomerDataGridViewTextBoxColumn.HeaderText = "NameCustomer";
            this.nameCustomerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameCustomerDataGridViewTextBoxColumn.Name = "nameCustomerDataGridViewTextBoxColumn";
            this.nameCustomerDataGridViewTextBoxColumn.Width = 125;
            // 
            // carIDDataGridViewTextBoxColumn
            // 
            this.carIDDataGridViewTextBoxColumn.DataPropertyName = "CarID";
            this.carIDDataGridViewTextBoxColumn.HeaderText = "CarID";
            this.carIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carIDDataGridViewTextBoxColumn.Name = "carIDDataGridViewTextBoxColumn";
            this.carIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.Width = 125;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDParkDataGridViewTextBoxColumn
            // 
            this.iDParkDataGridViewTextBoxColumn.DataPropertyName = "IDPark";
            this.iDParkDataGridViewTextBoxColumn.HeaderText = "IDPark";
            this.iDParkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDParkDataGridViewTextBoxColumn.Name = "iDParkDataGridViewTextBoxColumn";
            this.iDParkDataGridViewTextBoxColumn.Width = 125;
            // 
            // areaParkDataGridViewTextBoxColumn
            // 
            this.areaParkDataGridViewTextBoxColumn.DataPropertyName = "AreaPark";
            this.areaParkDataGridViewTextBoxColumn.HeaderText = "AreaPark";
            this.areaParkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.areaParkDataGridViewTextBoxColumn.Name = "areaParkDataGridViewTextBoxColumn";
            this.areaParkDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateInDataGridViewTextBoxColumn
            // 
            this.dateInDataGridViewTextBoxColumn.DataPropertyName = "DateIn";
            this.dateInDataGridViewTextBoxColumn.HeaderText = "DateIn";
            this.dateInDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateInDataGridViewTextBoxColumn.Name = "dateInDataGridViewTextBoxColumn";
            this.dateInDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // ticketDbBindingSource
            // 
            this.ticketDbBindingSource.DataMember = "TicketDb";
            this.ticketDbBindingSource.DataSource = this.userDataDataSet6;
            // 
            // userDataDataSet6
            // 
            this.userDataDataSet6.DataSetName = "UserDataDataSet6";
            this.userDataDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // IdtickTextbox
            // 
            this.IdtickTextbox.Location = new System.Drawing.Point(124, 61);
            this.IdtickTextbox.Name = "IdtickTextbox";
            this.IdtickTextbox.Size = new System.Drawing.Size(100, 22);
            this.IdtickTextbox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ticket ID:";
            // 
            // ticketDbTableAdapter
            // 
            this.ticketDbTableAdapter.ClearBeforeFill = true;
            // 
            // Retrievebutton
            // 
            this.Retrievebutton.Location = new System.Drawing.Point(467, 50);
            this.Retrievebutton.Name = "Retrievebutton";
            this.Retrievebutton.Size = new System.Drawing.Size(75, 44);
            this.Retrievebutton.TabIndex = 8;
            this.Retrievebutton.Text = "Retrieve Car";
            this.Retrievebutton.UseVisualStyleBackColor = true;
            this.Retrievebutton.Click += new System.EventHandler(this.Retrievebutton_Click);
            // 
            // CusRetrieve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 535);
            this.Controls.Add(this.Retrievebutton);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.IdtickTextbox);
            this.Controls.Add(this.label1);
            this.Name = "CusRetrieve";
            this.Text = "CusRetrieve";
            this.Load += new System.EventHandler(this.CusRetrieve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketDbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox IdtickTextbox;
        private System.Windows.Forms.Label label1;
        private UserDataDataSet6 userDataDataSet6;
        private System.Windows.Forms.BindingSource ticketDbBindingSource;
        private UserDataDataSet6TableAdapters.TicketDbTableAdapter ticketDbTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDParkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaParkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Retrievebutton;
    }
}