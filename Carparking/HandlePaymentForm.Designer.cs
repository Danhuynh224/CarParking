namespace Carparking
{
    partial class HandlePaymentForm
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
            this.cash_button = new System.Windows.Forms.Button();
            this.visa_button = new System.Windows.Forms.Button();
            this.banking_button = new System.Windows.Forms.Button();
            this.pay_panel = new System.Windows.Forms.Panel();
            this.receipt_panel = new System.Windows.Forms.Panel();
            this.PrintButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pay_button = new System.Windows.Forms.Button();
            this.idreceipt_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userDataDataSet8 = new Carparking.UserDataDataSet8();
            this.receiptDbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receiptDbTableAdapter = new Carparking.UserDataDataSet8TableAdapters.ReceiptDbTableAdapter();
            this.iDReceiptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDParkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaParkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentMethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pay_panel.SuspendLayout();
            this.receipt_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptDbBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Payment Method";
            // 
            // cash_button
            // 
            this.cash_button.Location = new System.Drawing.Point(73, 201);
            this.cash_button.Name = "cash_button";
            this.cash_button.Size = new System.Drawing.Size(152, 144);
            this.cash_button.TabIndex = 1;
            this.cash_button.Text = "Cash";
            this.cash_button.UseVisualStyleBackColor = true;
            this.cash_button.Click += new System.EventHandler(this.cash_button_Click);
            // 
            // visa_button
            // 
            this.visa_button.Location = new System.Drawing.Point(305, 201);
            this.visa_button.Name = "visa_button";
            this.visa_button.Size = new System.Drawing.Size(152, 144);
            this.visa_button.TabIndex = 2;
            this.visa_button.Text = "ViSa Card";
            this.visa_button.UseVisualStyleBackColor = true;
            this.visa_button.Click += new System.EventHandler(this.visa_button_Click);
            // 
            // banking_button
            // 
            this.banking_button.Location = new System.Drawing.Point(525, 201);
            this.banking_button.Name = "banking_button";
            this.banking_button.Size = new System.Drawing.Size(152, 144);
            this.banking_button.TabIndex = 3;
            this.banking_button.Text = "Banking";
            this.banking_button.UseVisualStyleBackColor = true;
            this.banking_button.Click += new System.EventHandler(this.banking_button_Click);
            // 
            // pay_panel
            // 
            this.pay_panel.Controls.Add(this.cash_button);
            this.pay_panel.Controls.Add(this.label1);
            this.pay_panel.Controls.Add(this.banking_button);
            this.pay_panel.Controls.Add(this.visa_button);
            this.pay_panel.Location = new System.Drawing.Point(53, 48);
            this.pay_panel.Name = "pay_panel";
            this.pay_panel.Size = new System.Drawing.Size(772, 494);
            this.pay_panel.TabIndex = 4;
            // 
            // receipt_panel
            // 
            this.receipt_panel.Controls.Add(this.PrintButton);
            this.receipt_panel.Controls.Add(this.dataGridView1);
            this.receipt_panel.Controls.Add(this.pay_button);
            this.receipt_panel.Controls.Add(this.idreceipt_textbox);
            this.receipt_panel.Controls.Add(this.label2);
            this.receipt_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.receipt_panel.Location = new System.Drawing.Point(0, 0);
            this.receipt_panel.Name = "receipt_panel";
            this.receipt_panel.Size = new System.Drawing.Size(890, 584);
            this.receipt_panel.TabIndex = 5;
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(507, 73);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(75, 44);
            this.PrintButton.TabIndex = 8;
            this.PrintButton.Text = "Print  Detail";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDReceiptDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.iDUserDataGridViewTextBoxColumn,
            this.nameUserDataGridViewTextBoxColumn,
            this.iDParkDataGridViewTextBoxColumn,
            this.areaParkDataGridViewTextBoxColumn,
            this.iDCarDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.dateInDataGridViewTextBoxColumn,
            this.dateOutDataGridViewTextBoxColumn,
            this.paymentMethodDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.receiptDbBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 282);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(890, 302);
            this.dataGridView1.TabIndex = 3;
            // 
            // pay_button
            // 
            this.pay_button.Location = new System.Drawing.Point(362, 137);
            this.pay_button.Name = "pay_button";
            this.pay_button.Size = new System.Drawing.Size(190, 39);
            this.pay_button.TabIndex = 2;
            this.pay_button.Text = "Pay";
            this.pay_button.UseVisualStyleBackColor = true;
            this.pay_button.Click += new System.EventHandler(this.pay_button_Click);
            // 
            // idreceipt_textbox
            // 
            this.idreceipt_textbox.Location = new System.Drawing.Point(293, 84);
            this.idreceipt_textbox.Name = "idreceipt_textbox";
            this.idreceipt_textbox.Size = new System.Drawing.Size(144, 22);
            this.idreceipt_textbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select No. Receipt:";
            // 
            // userDataDataSet8
            // 
            this.userDataDataSet8.DataSetName = "UserDataDataSet8";
            this.userDataDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // receiptDbBindingSource
            // 
            this.receiptDbBindingSource.DataMember = "ReceiptDb";
            this.receiptDbBindingSource.DataSource = this.userDataDataSet8;
            // 
            // receiptDbTableAdapter
            // 
            this.receiptDbTableAdapter.ClearBeforeFill = true;
            // 
            // iDReceiptDataGridViewTextBoxColumn
            // 
            this.iDReceiptDataGridViewTextBoxColumn.DataPropertyName = "IDReceipt";
            this.iDReceiptDataGridViewTextBoxColumn.HeaderText = "IDReceipt";
            this.iDReceiptDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDReceiptDataGridViewTextBoxColumn.Name = "iDReceiptDataGridViewTextBoxColumn";
            this.iDReceiptDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDReceiptDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDUserDataGridViewTextBoxColumn
            // 
            this.iDUserDataGridViewTextBoxColumn.DataPropertyName = "IDUser";
            this.iDUserDataGridViewTextBoxColumn.HeaderText = "IDUser";
            this.iDUserDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDUserDataGridViewTextBoxColumn.Name = "iDUserDataGridViewTextBoxColumn";
            this.iDUserDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDUserDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameUserDataGridViewTextBoxColumn
            // 
            this.nameUserDataGridViewTextBoxColumn.DataPropertyName = "NameUser";
            this.nameUserDataGridViewTextBoxColumn.HeaderText = "NameUser";
            this.nameUserDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameUserDataGridViewTextBoxColumn.Name = "nameUserDataGridViewTextBoxColumn";
            this.nameUserDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameUserDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDParkDataGridViewTextBoxColumn
            // 
            this.iDParkDataGridViewTextBoxColumn.DataPropertyName = "IDPark";
            this.iDParkDataGridViewTextBoxColumn.HeaderText = "IDPark";
            this.iDParkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDParkDataGridViewTextBoxColumn.Name = "iDParkDataGridViewTextBoxColumn";
            this.iDParkDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDParkDataGridViewTextBoxColumn.Width = 125;
            // 
            // areaParkDataGridViewTextBoxColumn
            // 
            this.areaParkDataGridViewTextBoxColumn.DataPropertyName = "AreaPark";
            this.areaParkDataGridViewTextBoxColumn.HeaderText = "AreaPark";
            this.areaParkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.areaParkDataGridViewTextBoxColumn.Name = "areaParkDataGridViewTextBoxColumn";
            this.areaParkDataGridViewTextBoxColumn.ReadOnly = true;
            this.areaParkDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDCarDataGridViewTextBoxColumn
            // 
            this.iDCarDataGridViewTextBoxColumn.DataPropertyName = "IDCar";
            this.iDCarDataGridViewTextBoxColumn.HeaderText = "IDCar";
            this.iDCarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDCarDataGridViewTextBoxColumn.Name = "iDCarDataGridViewTextBoxColumn";
            this.iDCarDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDCarDataGridViewTextBoxColumn.Width = 125;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.ReadOnly = true;
            this.brandDataGridViewTextBoxColumn.Width = 125;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.ReadOnly = true;
            this.colorDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateInDataGridViewTextBoxColumn
            // 
            this.dateInDataGridViewTextBoxColumn.DataPropertyName = "DateIn";
            this.dateInDataGridViewTextBoxColumn.HeaderText = "DateIn";
            this.dateInDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateInDataGridViewTextBoxColumn.Name = "dateInDataGridViewTextBoxColumn";
            this.dateInDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateInDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateOutDataGridViewTextBoxColumn
            // 
            this.dateOutDataGridViewTextBoxColumn.DataPropertyName = "DateOut";
            this.dateOutDataGridViewTextBoxColumn.HeaderText = "DateOut";
            this.dateOutDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateOutDataGridViewTextBoxColumn.Name = "dateOutDataGridViewTextBoxColumn";
            this.dateOutDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateOutDataGridViewTextBoxColumn.Width = 125;
            // 
            // paymentMethodDataGridViewTextBoxColumn
            // 
            this.paymentMethodDataGridViewTextBoxColumn.DataPropertyName = "PaymentMethod";
            this.paymentMethodDataGridViewTextBoxColumn.HeaderText = "PaymentMethod";
            this.paymentMethodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentMethodDataGridViewTextBoxColumn.Name = "paymentMethodDataGridViewTextBoxColumn";
            this.paymentMethodDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentMethodDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // HandlePaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 584);
            this.Controls.Add(this.pay_panel);
            this.Controls.Add(this.receipt_panel);
            this.Name = "HandlePaymentForm";
            this.Text = "HandlePaymentForm";
            this.Load += new System.EventHandler(this.HandlePaymentForm_Load);
            this.pay_panel.ResumeLayout(false);
            this.pay_panel.PerformLayout();
            this.receipt_panel.ResumeLayout(false);
            this.receipt_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptDbBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cash_button;
        private System.Windows.Forms.Button visa_button;
        private System.Windows.Forms.Button banking_button;
        private System.Windows.Forms.Panel pay_panel;
        private System.Windows.Forms.Panel receipt_panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button pay_button;
        private System.Windows.Forms.TextBox idreceipt_textbox;
        private System.Windows.Forms.Button PrintButton;
        private UserDataDataSet8 userDataDataSet8;
        private System.Windows.Forms.BindingSource receiptDbBindingSource;
        private UserDataDataSet8TableAdapters.ReceiptDbTableAdapter receiptDbTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDReceiptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDParkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaParkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentMethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}