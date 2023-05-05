namespace Assignment14_CRUD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOrderList = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lvwEmployee = new System.Windows.Forms.ListView();
            this.lvwShipper = new System.Windows.Forms.ListView();
            this.lvwOrder = new System.Windows.Forms.ListView();
            this.OrderID = new System.Windows.Forms.ColumnHeader();
            this.OrderDate = new System.Windows.Forms.ColumnHeader();
            this.ShipCity = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // btnOrderList
            // 
            this.btnOrderList.Location = new System.Drawing.Point(34, 23);
            this.btnOrderList.Name = "btnOrderList";
            this.btnOrderList.Size = new System.Drawing.Size(120, 39);
            this.btnOrderList.TabIndex = 0;
            this.btnOrderList.Text = "Get Order List";
            this.btnOrderList.UseVisualStyleBackColor = true;
            this.btnOrderList.Click += new System.EventHandler(this.btnOrderList_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(230, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 39);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(425, 23);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 39);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(622, 23);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 39);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lvwEmployee
            // 
            this.lvwEmployee.Location = new System.Drawing.Point(33, 88);
            this.lvwEmployee.Name = "lvwEmployee";
            this.lvwEmployee.Size = new System.Drawing.Size(121, 195);
            this.lvwEmployee.TabIndex = 4;
            this.lvwEmployee.UseCompatibleStateImageBehavior = false;
            this.lvwEmployee.View = System.Windows.Forms.View.List;
            this.lvwEmployee.SelectedIndexChanged += new System.EventHandler(this.lvwEmployee_SelectedIndexChanged);
            // 
            // lvwShipper
            // 
            this.lvwShipper.Location = new System.Drawing.Point(33, 322);
            this.lvwShipper.Name = "lvwShipper";
            this.lvwShipper.Size = new System.Drawing.Size(121, 97);
            this.lvwShipper.TabIndex = 5;
            this.lvwShipper.UseCompatibleStateImageBehavior = false;
            this.lvwShipper.View = System.Windows.Forms.View.List;
            this.lvwShipper.SelectedIndexChanged += new System.EventHandler(this.lvwShipper_SelectedIndexChanged);
            // 
            // lvwOrder
            // 
            this.lvwOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrderID,
            this.OrderDate,
            this.ShipCity});
            this.lvwOrder.FullRowSelect = true;
            this.lvwOrder.GridLines = true;
            this.lvwOrder.Location = new System.Drawing.Point(230, 88);
            this.lvwOrder.Name = "lvwOrder";
            this.lvwOrder.Size = new System.Drawing.Size(498, 331);
            this.lvwOrder.TabIndex = 6;
            this.lvwOrder.UseCompatibleStateImageBehavior = false;
            this.lvwOrder.View = System.Windows.Forms.View.Details;
            // 
            // OrderID
            // 
            this.OrderID.Text = "OrderID";
            this.OrderID.Width = 180;
            // 
            // OrderDate
            // 
            this.OrderDate.Text = "Order Date";
            this.OrderDate.Width = 180;
            // 
            // ShipCity
            // 
            this.ShipCity.Text = "Ship City";
            this.ShipCity.Width = 180;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvwOrder);
            this.Controls.Add(this.lvwShipper);
            this.Controls.Add(this.lvwEmployee);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnOrderList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnOrderList;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private ListView lvwEmployee;
        private ListView lvwShipper;
        private ListView lvwOrder;
        private ColumnHeader OrderID;
        private ColumnHeader OrderDate;
        private ColumnHeader ShipCity;
    }
}