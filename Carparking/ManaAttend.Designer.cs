namespace Carparking
{
    partial class ManaAttend
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.fullnametextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workingDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonetextBox = new System.Windows.Forms.TextBox();
            this.birthdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AreaParktextBox = new System.Windows.Forms.TextBox();
            this.WorkdaytextBox = new System.Windows.Forms.TextBox();
            this.SalarytextBox = new System.Windows.Forms.TextBox();
            this.savebutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.editbutton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.ByIDtextBox = new System.Windows.Forms.TextBox();
            this.SearchByNametextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.userDataDataSet9 = new Carparking.UserDataDataSet9();
            this.attendantDbBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.attendantDbTableAdapter4 = new Carparking.UserDataDataSet9TableAdapters.AttendantDbTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendantDbBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Full name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 264);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Birthday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(602, 83);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "AreaPark:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(606, 143);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "WorkingDay:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(606, 209);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Salary:";
            // 
            // IDtextBox
            // 
            this.IDtextBox.Location = new System.Drawing.Point(149, 83);
            this.IDtextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.Size = new System.Drawing.Size(252, 26);
            this.IDtextBox.TabIndex = 8;
            // 
            // fullnametextBox
            // 
            this.fullnametextBox.Location = new System.Drawing.Point(149, 143);
            this.fullnametextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fullnametextBox.Name = "fullnametextBox";
            this.fullnametextBox.Size = new System.Drawing.Size(252, 26);
            this.fullnametextBox.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn21,
            this.fullnameDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.workingDayDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn25});
            this.dataGridView1.DataSource = this.attendantDbBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(83, 463);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1051, 268);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn21.HeaderText = "ID";
            this.dataGridViewTextBoxColumn21.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Width = 62;
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "Fullname";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "Fullname";
            this.fullnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            this.fullnameDataGridViewTextBoxColumn.Width = 110;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn22.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn22.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.Width = 91;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "Birthday";
            this.dataGridViewTextBoxColumn23.HeaderText = "Birthday";
            this.dataGridViewTextBoxColumn23.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.Width = 103;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "AreaPark";
            this.dataGridViewTextBoxColumn24.HeaderText = "AreaPark";
            this.dataGridViewTextBoxColumn24.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.Width = 111;
            // 
            // workingDayDataGridViewTextBoxColumn
            // 
            this.workingDayDataGridViewTextBoxColumn.DataPropertyName = "WorkingDay";
            this.workingDayDataGridViewTextBoxColumn.HeaderText = "WorkingDay";
            this.workingDayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.workingDayDataGridViewTextBoxColumn.Name = "workingDayDataGridViewTextBoxColumn";
            this.workingDayDataGridViewTextBoxColumn.Width = 131;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Salary";
            this.dataGridViewTextBoxColumn25.HeaderText = "Salary";
            this.dataGridViewTextBoxColumn25.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.Width = 89;
            // 
            // phonetextBox
            // 
            this.phonetextBox.Location = new System.Drawing.Point(149, 205);
            this.phonetextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.phonetextBox.Name = "phonetextBox";
            this.phonetextBox.Size = new System.Drawing.Size(252, 26);
            this.phonetextBox.TabIndex = 11;
            // 
            // birthdateTimePicker
            // 
            this.birthdateTimePicker.Location = new System.Drawing.Point(149, 264);
            this.birthdateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.birthdateTimePicker.Name = "birthdateTimePicker";
            this.birthdateTimePicker.Size = new System.Drawing.Size(316, 26);
            this.birthdateTimePicker.TabIndex = 12;
            // 
            // AreaParktextBox
            // 
            this.AreaParktextBox.Location = new System.Drawing.Point(713, 82);
            this.AreaParktextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AreaParktextBox.Name = "AreaParktextBox";
            this.AreaParktextBox.Size = new System.Drawing.Size(119, 26);
            this.AreaParktextBox.TabIndex = 13;
            // 
            // WorkdaytextBox
            // 
            this.WorkdaytextBox.Location = new System.Drawing.Point(715, 143);
            this.WorkdaytextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WorkdaytextBox.Name = "WorkdaytextBox";
            this.WorkdaytextBox.Size = new System.Drawing.Size(117, 26);
            this.WorkdaytextBox.TabIndex = 14;
            // 
            // SalarytextBox
            // 
            this.SalarytextBox.Location = new System.Drawing.Point(713, 209);
            this.SalarytextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SalarytextBox.Name = "SalarytextBox";
            this.SalarytextBox.Size = new System.Drawing.Size(119, 26);
            this.SalarytextBox.TabIndex = 15;
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(304, 310);
            this.savebutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(86, 54);
            this.savebutton.TabIndex = 16;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(793, 310);
            this.deletebutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(86, 54);
            this.deletebutton.TabIndex = 17;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // editbutton
            // 
            this.editbutton.Location = new System.Drawing.Point(533, 310);
            this.editbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(86, 54);
            this.editbutton.TabIndex = 18;
            this.editbutton.Text = "Edit";
            this.editbutton.UseVisualStyleBackColor = true;
            this.editbutton.Click += new System.EventHandler(this.editbutton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(80, 400);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Search By ID";
            // 
            // ByIDtextBox
            // 
            this.ByIDtextBox.Location = new System.Drawing.Point(190, 395);
            this.ByIDtextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ByIDtextBox.Name = "ByIDtextBox";
            this.ByIDtextBox.Size = new System.Drawing.Size(86, 26);
            this.ByIDtextBox.TabIndex = 21;
            this.ByIDtextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ByIDtextBox_KeyUp);
            // 
            // SearchByNametextBox
            // 
            this.SearchByNametextBox.Location = new System.Drawing.Point(514, 395);
            this.SearchByNametextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchByNametextBox.Name = "SearchByNametextBox";
            this.SearchByNametextBox.Size = new System.Drawing.Size(280, 26);
            this.SearchByNametextBox.TabIndex = 23;
            this.SearchByNametextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchByNametextBox_KeyUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(361, 400);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Search By Name";
            // 
            // userDataDataSet9
            // 
            this.userDataDataSet9.DataSetName = "UserDataDataSet9";
            this.userDataDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attendantDbBindingSource3
            // 
            this.attendantDbBindingSource3.DataMember = "AttendantDb";
            this.attendantDbBindingSource3.DataSource = this.userDataDataSet9;
            // 
            // attendantDbTableAdapter4
            // 
            this.attendantDbTableAdapter4.ClearBeforeFill = true;
            // 
            // ManaAttend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1262, 745);
            this.Controls.Add(this.SearchByNametextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ByIDtextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.editbutton);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.SalarytextBox);
            this.Controls.Add(this.WorkdaytextBox);
            this.Controls.Add(this.AreaParktextBox);
            this.Controls.Add(this.birthdateTimePicker);
            this.Controls.Add(this.phonetextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.fullnametextBox);
            this.Controls.Add(this.IDtextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ManaAttend";
            this.Text = "ManaAttend";
            this.Load += new System.EventHandler(this.ManaAttend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendantDbBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaParkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberCarAssistedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox IDtextBox;
        private System.Windows.Forms.TextBox fullnametextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox phonetextBox;
        private System.Windows.Forms.DateTimePicker birthdateTimePicker;
        private System.Windows.Forms.TextBox AreaParktextBox;
        private System.Windows.Forms.TextBox WorkdaytextBox;
        private System.Windows.Forms.TextBox SalarytextBox;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button editbutton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ByIDtextBox;
        private System.Windows.Forms.TextBox SearchByNametextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn workingDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private UserDataDataSet9 userDataDataSet9;
        private System.Windows.Forms.BindingSource attendantDbBindingSource3;
        private UserDataDataSet9TableAdapters.AttendantDbTableAdapter attendantDbTableAdapter4;
    }
}