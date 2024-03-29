using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageCategoriesApp
{
    public partial class frmManageCategories : Form
    {
        public frmManageCategories()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                var category = new MyStockDBContext.Category { CategoryName = txtCategoryName.Text };
                ManageCategories.Instance.InsertCategory(category);
                LoadCategory();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert Catogory");
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var category = new MyStockDBContext.Category
                {
                    CategoryID = int.Parse(txtCategoryID.Text),
                    CategoryName = txtCategoryName.Text
                };
                ManageCategories.Instance.UpdateCategory(category);
                LoadCategory();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Category");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var category = new MyStockDBContext.Category { CategoryID = int.Parse(txtCategoryID.Text) };
                ManageCategories.Instance.DeleteCategory(category);
                LoadCategory();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Category");
            }
        }
        private void frmManageCategories_Load(object sender, EventArgs e)
        {
            LoadCategory();
        }

        private void LoadCategory()
        {
            var Categories = ManageCategories.Instance.GetCategories();
            txtCategoryID.DataBindings.Clear();
            txtCategoryName.DataBindings.Clear();
            //Binding data to textbox
            txtCategoryID.DataBindings.Add("Text", Categories, "CategoryID");
            txtCategoryName.DataBindings.Add("Text", Categories, "CategoryName");
            //Binding data to datagridview
            dgvCategories.DataSource = Categories;
        }


    }
}
