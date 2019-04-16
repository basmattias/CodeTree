namespace CodeTree
{
    partial class CondensedMeaningUnitForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCodeList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbInterview = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbMeaningUnit = new System.Windows.Forms.TextBox();
            this.lbMeaningUnits = new System.Windows.Forms.ListBox();
            this.btnAddCode = new System.Windows.Forms.Button();
            this.lbCodes = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbCodes);
            this.groupBox1.Controls.Add(this.btnAddCode);
            this.groupBox1.Controls.Add(this.cmbCodeList);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbInterview);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 297);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Condensed meaning unit";
            // 
            // cmbCodeList
            // 
            this.cmbCodeList.FormattingEnabled = true;
            this.cmbCodeList.Location = new System.Drawing.Point(124, 116);
            this.cmbCodeList.Name = "cmbCodeList";
            this.cmbCodeList.Size = new System.Drawing.Size(196, 24);
            this.cmbCodeList.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "&Kod";
            // 
            // tbInterview
            // 
            this.tbInterview.Location = new System.Drawing.Point(124, 75);
            this.tbInterview.Name = "tbInterview";
            this.tbInterview.Size = new System.Drawing.Size(196, 22);
            this.tbInterview.TabIndex = 3;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(124, 45);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(196, 22);
            this.tbName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "&Intervju nr";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Namn";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(439, 328);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(136, 27);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(581, 328);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 27);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Avbryt";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.tbMeaningUnit);
            this.groupBox2.Controls.Add(this.lbMeaningUnits);
            this.groupBox2.Location = new System.Drawing.Point(346, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 297);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Meaning units";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(295, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(73, 28);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "&Lägg till";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbMeaningUnit
            // 
            this.tbMeaningUnit.Location = new System.Drawing.Point(12, 25);
            this.tbMeaningUnit.Name = "tbMeaningUnit";
            this.tbMeaningUnit.Size = new System.Drawing.Size(277, 22);
            this.tbMeaningUnit.TabIndex = 7;
            // 
            // lbMeaningUnits
            // 
            this.lbMeaningUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMeaningUnits.FormattingEnabled = true;
            this.lbMeaningUnits.ItemHeight = 16;
            this.lbMeaningUnits.Location = new System.Drawing.Point(12, 66);
            this.lbMeaningUnits.Name = "lbMeaningUnits";
            this.lbMeaningUnits.Size = new System.Drawing.Size(356, 212);
            this.lbMeaningUnits.TabIndex = 9;
            this.lbMeaningUnits.DoubleClick += new System.EventHandler(this.lbMeaningUnits_DoubleClick);
            // 
            // btnAddCode
            // 
            this.btnAddCode.Location = new System.Drawing.Point(7, 151);
            this.btnAddCode.Name = "btnAddCode";
            this.btnAddCode.Size = new System.Drawing.Size(73, 28);
            this.btnAddCode.TabIndex = 6;
            this.btnAddCode.Text = "L&ägg till";
            this.btnAddCode.UseVisualStyleBackColor = true;
            this.btnAddCode.Click += new System.EventHandler(this.btnAddCode_Click);
            // 
            // lbCodes
            // 
            this.lbCodes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCodes.FormattingEnabled = true;
            this.lbCodes.ItemHeight = 16;
            this.lbCodes.Location = new System.Drawing.Point(9, 195);
            this.lbCodes.Name = "lbCodes";
            this.lbCodes.Size = new System.Drawing.Size(311, 84);
            this.lbCodes.TabIndex = 7;
            this.lbCodes.DoubleClick += new System.EventHandler(this.lbCodes_DoubleClick);
            // 
            // CondensedMeaningUnitForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(742, 367);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.Name = "CondensedMeaningUnitForm";
            this.Text = "Condensed meaning unit";
            this.Load += new System.EventHandler(this.CondensedMeaningUnitForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbInterview;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbCodeList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbMeaningUnit;
        private System.Windows.Forms.ListBox lbMeaningUnits;
        private System.Windows.Forms.ListBox lbCodes;
        private System.Windows.Forms.Button btnAddCode;
    }
}