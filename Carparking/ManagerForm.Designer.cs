namespace Carparking
{
    partial class ManagerForm
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
            this.carparingbutton = new System.Windows.Forms.Button();
            this.Attendent_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.content_panel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // carparingbutton
            // 
            this.carparingbutton.Location = new System.Drawing.Point(0, 168);
            this.carparingbutton.Name = "carparingbutton";
            this.carparingbutton.Size = new System.Drawing.Size(198, 63);
            this.carparingbutton.TabIndex = 2;
            this.carparingbutton.Text = "Manage Carparking";
            this.carparingbutton.UseVisualStyleBackColor = true;
            this.carparingbutton.Click += new System.EventHandler(this.carparingbutton_Click);
            // 
            // Attendent_button
            // 
            this.Attendent_button.Location = new System.Drawing.Point(0, 238);
            this.Attendent_button.Name = "Attendent_button";
            this.Attendent_button.Size = new System.Drawing.Size(198, 57);
            this.Attendent_button.TabIndex = 3;
            this.Attendent_button.Text = "Manage \r\nAttendant";
            this.Attendent_button.UseVisualStyleBackColor = true;
            this.Attendent_button.Click += new System.EventHandler(this.Attendent_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1203, 37);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(556, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME MANAGER | CAR PARKING MANAGEMENT SYSTEM";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.Attendent_button);
            this.panel2.Controls.Add(this.carparingbutton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 701);
            this.panel2.TabIndex = 5;
            // 
            // content_panel
            // 
            this.content_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content_panel.Location = new System.Drawing.Point(198, 37);
            this.content_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.content_panel.Name = "content_panel";
            this.content_panel.Size = new System.Drawing.Size(1005, 701);
            this.content_panel.TabIndex = 6;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1203, 738);
            this.Controls.Add(this.content_panel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button carparingbutton;
        private System.Windows.Forms.Button Attendent_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel content_panel;
        private System.Windows.Forms.Label label1;
    }
}