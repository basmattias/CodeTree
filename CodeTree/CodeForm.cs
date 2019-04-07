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
    public partial class CodeForm : Form
    {
        private IEnumerable<Category> categoryList;
        private Code code;
        private int cmuCount;

        public CodeForm(Code code, IEnumerable<Category> categoryList, int cmuCount)
        {
            InitializeComponent();

            this.code = code;
            this.categoryList = categoryList;
            this.cmuCount = cmuCount;
        }

        public CodeForm()
        {
            InitializeComponent();
        }

        private void CodeForm_Load(object sender, EventArgs e)
        {
            tbName.Text = code.Name;
            tbCmuCount.Text = cmuCount.ToString();

            cmbCategories.Items.AddRange(categoryList.OrderBy(x => x.Name).Select(x => x.Name).ToArray());
            if (!string.IsNullOrEmpty(code.CategoryName))
            {
                cmbCategories.Text = code.CategoryName;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            code.Name = tbName.Text;
            code.CategoryName = cmbCategories.Text;
        }
    }
}
