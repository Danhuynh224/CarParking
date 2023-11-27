namespace Carparking
{
    partial class AttendantForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendantForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ticket_button = new System.Windows.Forms.Button();
            this.parkCar_button = new System.Windows.Forms.Button();
            this.contentAtt_panel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1444, 44);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(681, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME ATTENDANT | CAR PARKING MANAGEMENT SYSTEM";
            // 
            // ticket_button
            // 
            this.ticket_button.Location = new System.Drawing.Point(0, 373);
            this.ticket_button.Margin = new System.Windows.Forms.Padding(4);
            this.ticket_button.Name = "ticket_button";
            this.ticket_button.Size = new System.Drawing.Size(238, 68);
            this.ticket_button.TabIndex = 3;
            this.ticket_button.Text = "Ticket";
            this.ticket_button.UseVisualStyleBackColor = true;
            // 
            // parkCar_button
            // 
            this.parkCar_button.Location = new System.Drawing.Point(0, 289);
            this.parkCar_button.Margin = new System.Windows.Forms.Padding(4);
            this.parkCar_button.Name = "parkCar_button";
            this.parkCar_button.Size = new System.Drawing.Size(238, 76);
            this.parkCar_button.TabIndex = 2;
            this.parkCar_button.Text = "Park Car";
            this.parkCar_button.UseVisualStyleBackColor = true;
            this.parkCar_button.Click += new System.EventHandler(this.parkCar_button_Click);
            // 
            // contentAtt_panel
            // 
            this.contentAtt_panel.Location = new System.Drawing.Point(238, 44);
            this.contentAtt_panel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.contentAtt_panel.Name = "contentAtt_panel";
            this.contentAtt_panel.Size = new System.Drawing.Size(1206, 842);
            this.contentAtt_panel.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.ticket_button);
            this.panel2.Controls.Add(this.parkCar_button);
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 842);
            this.panel2.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(61, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "CHECK IN";
            // 
            // AttendantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 886);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.contentAtt_panel);
            this.Controls.Add(this.panel2);
            this.Name = "AttendantForm";
            this.Text = "AttendantForm";
            this.Load += new System.EventHandler(this.AttendantForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ticket_button;
        private System.Windows.Forms.Button parkCar_button;
        private System.Windows.Forms.Panel contentAtt_panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}