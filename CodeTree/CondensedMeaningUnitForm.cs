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
    public partial class CondensedMeaningUnitForm : Form
    {
        private IEnumerable<Code> codeList;
        private CondensedMeaningUnit condensedMeaningUnit;

        public CondensedMeaningUnitForm(CondensedMeaningUnit condensedMeaningUnit, IEnumerable<Code> codeList)
        {
            InitializeComponent();

            this.condensedMeaningUnit = condensedMeaningUnit;
            this.tbName.Text = condensedMeaningUnit.Name;
            this.tbInterview.Text = condensedMeaningUnit.InterviewNumber;
            this.codeList = codeList;
        }

        public CondensedMeaningUnitForm()
        {
            InitializeComponent();
        }

        private void CondensedMeaningUnitForm_Load(object sender, EventArgs e)
        {
            cmbCodeList.Items.AddRange(codeList.OrderBy(x => x.Name).Select(x => x.Name).ToArray());
            if (!string.IsNullOrEmpty(condensedMeaningUnit.CodeName))
            {
                cmbCodeList.Text = condensedMeaningUnit.CodeName;
            }

            if ((condensedMeaningUnit.MeaningUnits != null) && (condensedMeaningUnit.MeaningUnits.Count() > 0))
            {
                lbMeaningUnits.Items.AddRange(condensedMeaningUnit.MeaningUnits.Select(x => x.Name).ToArray());
            }

            foreach (var item in condensedMeaningUnit.CodeNames)
            {
                lbCodes.Items.Add(item);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            condensedMeaningUnit.Name = tbName.Text;
            condensedMeaningUnit.InterviewNumber = tbInterview.Text;
            condensedMeaningUnit.CodeName = cmbCodeList.Text;

            var muList = new List<MeaningUnit>();
            foreach (var item in lbMeaningUnits.Items)
            {
                muList.Add(new MeaningUnit()
                {
                    Name = item.ToString()
                });
            }
            condensedMeaningUnit.MeaningUnits = muList;

            condensedMeaningUnit.CodeNames = new List<string>();
            foreach (var item in lbCodes.Items)
            {
                condensedMeaningUnit.CodeNames.Add((string)item);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var meaningUnit = tbMeaningUnit.Text;
            if (!string.IsNullOrEmpty(meaningUnit))
            {
                lbMeaningUnits.Items.Add(meaningUnit);
                tbMeaningUnit.Text = "";
                tbMeaningUnit.Focus();
            }
        }

        private void btnAddCode_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbCodeList.Text))
            {
                if (!lbCodes.Items.Contains(cmbCodeList.Text))
                {
                    lbCodes.Items.Add(cmbCodeList.Text);
                }
            }
        }

        private void lbCodes_DoubleClick(object sender, EventArgs e)
        {
            lbCodes.Items.RemoveAt(lbCodes.SelectedIndex);
            cmbCodeList.Text = string.Empty;
        }

        private void lbMeaningUnits_DoubleClick(object sender, EventArgs e)
        {
            lbMeaningUnits.Items.RemoveAt(lbMeaningUnits.SelectedIndex);
            tbMeaningUnit.Text = string.Empty;
        }
    }
}
