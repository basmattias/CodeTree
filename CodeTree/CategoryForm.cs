using CodeTree.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeTree
{
    public partial class CategoryForm : Form
    {
        private IEnumerable<Theme> themeList;
        private Category category;

        public CategoryForm(Category category, IEnumerable<Theme> themeList)
        {
            InitializeComponent();

            this.category = category;
            tbName.Text = category.Name;
            this.themeList = themeList;
        }

        public CategoryForm()
        {
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            cmbThemes.Items.AddRange(themeList.Select(x => x.Name).ToArray());
            if (!string.IsNullOrEmpty(category.ThemeName))
            {
                cmbThemes.Text = category.ThemeName;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            category.Name = tbName.Text;
            category.ThemeName = cmbThemes.Text;
        }
    }
}
