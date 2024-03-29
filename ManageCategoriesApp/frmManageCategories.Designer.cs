namespace ManageCategoriesApp
{
    partial class frmManageCategories
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
            dgvCategories = new DataGridView();
            txtCategoryID = new TextBox();
            txtCategoryName = new TextBox();
            lbCategoryID = new Label();
            lbCategoryName = new Label();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            SuspendLayout();
            // 
            // dgvCategories
            // 
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Location = new Point(103, 162);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.ReadOnly = true;
            dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategories.Size = new Size(601, 204);
            dgvCategories.TabIndex = 0;
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(290, 43);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.ReadOnly = true;
            txtCategoryID.Size = new Size(414, 23);
            txtCategoryID.TabIndex = 1;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(290, 83);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(414, 23);
            txtCategoryName.TabIndex = 2;
            // 
            // lbCategoryID
            // 
            lbCategoryID.AutoSize = true;
            lbCategoryID.Location = new Point(165, 43);
            lbCategoryID.Name = "lbCategoryID";
            lbCategoryID.Size = new Size(60, 15);
            lbCategoryID.TabIndex = 3;
            lbCategoryID.Text = "CatogryID";
            // 
            // lbCategoryName
            // 
            lbCategoryName.AutoSize = true;
            lbCategoryName.Location = new Point(165, 83);
            lbCategoryName.Name = "lbCategoryName";
            lbCategoryName.Size = new Size(87, 15);
            lbCategoryName.TabIndex = 4;
            lbCategoryName.Text = "CategoryName";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(103, 401);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(137, 23);
            btnInsert.TabIndex = 5;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(332, 401);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(137, 23);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(567, 401);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(137, 23);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // frmManageCategories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(lbCategoryName);
            Controls.Add(lbCategoryID);
            Controls.Add(txtCategoryName);
            Controls.Add(txtCategoryID);
            Controls.Add(dgvCategories);
            Name = "frmManageCategories";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Categories";
            Load += frmManageCategories_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCategories;
        private TextBox txtCategoryID;
        private TextBox txtCategoryName;
        private Label lbCategoryID;
        private Label lbCategoryName;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
    }
}