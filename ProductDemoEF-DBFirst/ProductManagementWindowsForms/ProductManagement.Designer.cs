namespace ProductManagementWindowsForms
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnSave = new Button();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            cboCategory = new ComboBox();
            dgvProducts = new DataGridView();
            txtProductId = new TextBox();
            txtProductName = new TextBox();
            txtUnitsInStock = new TextBox();
            txtUnitPrice = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 39);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "ProductID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 75);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 1;
            label2.Text = "Product name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 110);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 2;
            label3.Text = "Unit in stock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 149);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 3;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 192);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 4;
            label5.Text = "Category";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(5, 248);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(86, 248);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 6;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(167, 248);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(248, 248);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(106, 189);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(217, 23);
            cboCategory.TabIndex = 9;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(348, 31);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.Size = new Size(429, 240);
            dgvProducts.TabIndex = 10;
            // 
            // txtProductId
            // 
            txtProductId.Enabled = false;
            txtProductId.Location = new Point(106, 31);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(217, 23);
            txtProductId.TabIndex = 11;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(106, 72);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(217, 23);
            txtProductName.TabIndex = 12;
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new Point(106, 107);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new Size(217, 23);
            txtUnitsInStock.TabIndex = 13;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(106, 149);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(217, 23);
            txtUnitPrice.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 286);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtUnitsInStock);
            Controls.Add(txtProductName);
            Controls.Add(txtProductId);
            Controls.Add(dgvProducts);
            Controls.Add(cboCategory);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(btnSave);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnSave;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private ComboBox cboCategory;
        private DataGridView dgvProducts;
        private TextBox txtProductId;
        private TextBox txtProductName;
        private TextBox txtUnitsInStock;
        private TextBox txtUnitPrice;
    }
}
