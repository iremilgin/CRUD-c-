namespace Assignment14_CRUD
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboxEmployee = new System.Windows.Forms.ComboBox();
            this.txtShipCity = new System.Windows.Forms.TextBox();
            this.cboxShipper = new System.Windows.Forms.ComboBox();
            this.btnform2 = new System.Windows.Forms.Button();
            this.dtpOrder = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 62);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Order Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ship City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Shipper";
            // 
            // cboxEmployee
            // 
            this.cboxEmployee.FormattingEnabled = true;
            this.cboxEmployee.Location = new System.Drawing.Point(119, 54);
            this.cboxEmployee.Name = "cboxEmployee";
            this.cboxEmployee.Size = new System.Drawing.Size(182, 23);
            this.cboxEmployee.TabIndex = 4;
            // 
            // txtShipCity
            // 
            this.txtShipCity.Location = new System.Drawing.Point(119, 163);
            this.txtShipCity.Name = "txtShipCity";
            this.txtShipCity.Size = new System.Drawing.Size(182, 23);
            this.txtShipCity.TabIndex = 5;
            // 
            // cboxShipper
            // 
            this.cboxShipper.FormattingEnabled = true;
            this.cboxShipper.Location = new System.Drawing.Point(119, 218);
            this.cboxShipper.Name = "cboxShipper";
            this.cboxShipper.Size = new System.Drawing.Size(182, 23);
            this.cboxShipper.TabIndex = 6;
            // 
            // btnform2
            // 
            this.btnform2.Location = new System.Drawing.Point(119, 277);
            this.btnform2.Name = "btnform2";
            this.btnform2.Size = new System.Drawing.Size(182, 31);
            this.btnform2.TabIndex = 7;
            this.btnform2.Text = "Add";
            this.btnform2.UseVisualStyleBackColor = true;
            this.btnform2.Click += new System.EventHandler(this.btnform2_Click);
            // 
            // dtpOrder
            // 
            this.dtpOrder.Location = new System.Drawing.Point(119, 112);
            this.dtpOrder.Name = "dtpOrder";
            this.dtpOrder.Size = new System.Drawing.Size(182, 23);
            this.dtpOrder.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 365);
            this.Controls.Add(this.dtpOrder);
            this.Controls.Add(this.btnform2);
            this.Controls.Add(this.cboxShipper);
            this.Controls.Add(this.txtShipCity);
            this.Controls.Add(this.cboxEmployee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cboxEmployee;
        private TextBox txtShipCity;
        private ComboBox cboxShipper;
        private Button btnform2;
        private DateTimePicker dtpOrder;
    }
}