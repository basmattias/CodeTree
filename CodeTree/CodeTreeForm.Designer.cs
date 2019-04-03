namespace CodeTree
{
    partial class CodeTreeForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arkivToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nyttToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öppnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sparaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sparaSomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripImport = new System.Windows.Forms.ToolStripMenuItem();
            this.exporteraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.avslutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trädToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.läggTillGruppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taBortGruppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.uppdateraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeTreeView = new System.Windows.Forms.TreeView();
            this.meaningListView = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCondensedInfo = new System.Windows.Forms.Button();
            this.btnRemoveCondensed = new System.Windows.Forms.Button();
            this.btnAddCondensed = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTopLevel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCodeInfo = new System.Windows.Forms.Button();
            this.btnRemoveCode = new System.Windows.Forms.Button();
            this.btnAddCode = new System.Windows.Forms.Button();
            this.codesListView = new System.Windows.Forms.ListView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCategoryInfo = new System.Windows.Forms.Button();
            this.btnRemoveCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.categoryListView = new System.Windows.Forms.ListView();
            this.btnExpand = new System.Windows.Forms.Button();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.lblThemes = new System.Windows.Forms.Label();
            this.lblCategories = new System.Windows.Forms.Label();
            this.lblCodes = new System.Windows.Forms.Label();
            this.lblCmus = new System.Windows.Forms.Label();
            this.btnExpandAll = new System.Windows.Forms.Button();
            this.btnThemes = new System.Windows.Forms.Button();
            this.btnExpandCategories = new System.Windows.Forms.Button();
            this.btnExpandCodes = new System.Windows.Forms.Button();
            this.lblFont = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arkivToolStripMenuItem,
            this.trädToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1263, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "mainMenu";
            // 
            // arkivToolStripMenuItem
            // 
            this.arkivToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nyttToolStripMenuItem,
            this.öppnaToolStripMenuItem,
            this.sparaToolStripMenuItem,
            this.sparaSomToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripImport,
            this.exporteraToolStripMenuItem,
            this.toolStripSeparator3,
            this.avslutaToolStripMenuItem});
            this.arkivToolStripMenuItem.Name = "arkivToolStripMenuItem";
            this.arkivToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.arkivToolStripMenuItem.Text = "&Arkiv";
            // 
            // nyttToolStripMenuItem
            // 
            this.nyttToolStripMenuItem.Name = "nyttToolStripMenuItem";
            this.nyttToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nyttToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.nyttToolStripMenuItem.Text = "&Nytt...";
            this.nyttToolStripMenuItem.Click += new System.EventHandler(this.nyttToolStripMenuItem_Click);
            // 
            // öppnaToolStripMenuItem
            // 
            this.öppnaToolStripMenuItem.Name = "öppnaToolStripMenuItem";
            this.öppnaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.öppnaToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.öppnaToolStripMenuItem.Text = "&Öppna...";
            this.öppnaToolStripMenuItem.Click += new System.EventHandler(this.öppnaToolStripMenuItem_Click);
            // 
            // sparaToolStripMenuItem
            // 
            this.sparaToolStripMenuItem.Name = "sparaToolStripMenuItem";
            this.sparaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.sparaToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.sparaToolStripMenuItem.Text = "&Spara...";
            this.sparaToolStripMenuItem.Click += new System.EventHandler(this.sparaToolStripMenuItem_Click);
            // 
            // sparaSomToolStripMenuItem
            // 
            this.sparaSomToolStripMenuItem.Name = "sparaSomToolStripMenuItem";
            this.sparaSomToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.sparaSomToolStripMenuItem.Text = "Spara so&m...";
            this.sparaSomToolStripMenuItem.Click += new System.EventHandler(this.sparaSomToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(188, 6);
            // 
            // toolStripImport
            // 
            this.toolStripImport.Name = "toolStripImport";
            this.toolStripImport.Size = new System.Drawing.Size(191, 26);
            this.toolStripImport.Text = "&Importera...";
            this.toolStripImport.Click += new System.EventHandler(this.toolStripImport_Click);
            // 
            // exporteraToolStripMenuItem
            // 
            this.exporteraToolStripMenuItem.Name = "exporteraToolStripMenuItem";
            this.exporteraToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.exporteraToolStripMenuItem.Text = "&Exportera...";
            this.exporteraToolStripMenuItem.Click += new System.EventHandler(this.exporteraToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(188, 6);
            // 
            // avslutaToolStripMenuItem
            // 
            this.avslutaToolStripMenuItem.Name = "avslutaToolStripMenuItem";
            this.avslutaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.avslutaToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.avslutaToolStripMenuItem.Text = "&Avsluta";
            this.avslutaToolStripMenuItem.Click += new System.EventHandler(this.avslutaToolStripMenuItem_Click);
            // 
            // trädToolStripMenuItem
            // 
            this.trädToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.läggTillGruppToolStripMenuItem,
            this.taBortGruppToolStripMenuItem,
            this.toolStripSeparator2,
            this.uppdateraToolStripMenuItem,
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem});
            this.trädToolStripMenuItem.Name = "trädToolStripMenuItem";
            this.trädToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.trädToolStripMenuItem.Text = "&Träd";
            // 
            // läggTillGruppToolStripMenuItem
            // 
            this.läggTillGruppToolStripMenuItem.Name = "läggTillGruppToolStripMenuItem";
            this.läggTillGruppToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.läggTillGruppToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.läggTillGruppToolStripMenuItem.Text = "&Lägg till tema...";
            this.läggTillGruppToolStripMenuItem.Click += new System.EventHandler(this.addThemeToolStripMenuItem_Click);
            // 
            // taBortGruppToolStripMenuItem
            // 
            this.taBortGruppToolStripMenuItem.Name = "taBortGruppToolStripMenuItem";
            this.taBortGruppToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.taBortGruppToolStripMenuItem.Text = "&Ta bort tema...";
            this.taBortGruppToolStripMenuItem.Click += new System.EventHandler(this.taBortGruppToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(260, 6);
            // 
            // uppdateraToolStripMenuItem
            // 
            this.uppdateraToolStripMenuItem.Name = "uppdateraToolStripMenuItem";
            this.uppdateraToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.uppdateraToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.uppdateraToolStripMenuItem.Text = "&Uppdatera";
            this.uppdateraToolStripMenuItem.Click += new System.EventHandler(this.uppdateraToolStripMenuItem_Click);
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.zoomInToolStripMenuItem.Text = "Zoom &in";
            this.zoomInToolStripMenuItem.Click += new System.EventHandler(this.zoomInToolStripMenuItem_Click);
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.zoomOutToolStripMenuItem.Text = "Zoom &out";
            this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
            // 
            // codeTreeView
            // 
            this.codeTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codeTreeView.Location = new System.Drawing.Point(9, 18);
            this.codeTreeView.Name = "codeTreeView";
            this.codeTreeView.Size = new System.Drawing.Size(408, 521);
            this.codeTreeView.TabIndex = 1;
            // 
            // meaningListView
            // 
            this.meaningListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.meaningListView.Location = new System.Drawing.Point(6, 21);
            this.meaningListView.Name = "meaningListView";
            this.meaningListView.Size = new System.Drawing.Size(220, 514);
            this.meaningListView.TabIndex = 2;
            this.meaningListView.UseCompatibleStateImageBehavior = false;
            this.meaningListView.DoubleClick += new System.EventHandler(this.meaningListView_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnCondensedInfo);
            this.groupBox1.Controls.Add(this.btnRemoveCondensed);
            this.groupBox1.Controls.Add(this.btnAddCondensed);
            this.groupBox1.Controls.Add(this.meaningListView);
            this.groupBox1.Location = new System.Drawing.Point(1025, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 578);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Condensed meaning units";
            // 
            // btnCondensedInfo
            // 
            this.btnCondensedInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCondensedInfo.Location = new System.Drawing.Point(173, 543);
            this.btnCondensedInfo.Name = "btnCondensedInfo";
            this.btnCondensedInfo.Size = new System.Drawing.Size(53, 27);
            this.btnCondensedInfo.TabIndex = 4;
            this.btnCondensedInfo.Text = "&Cmu";
            this.btnCondensedInfo.UseVisualStyleBackColor = true;
            this.btnCondensedInfo.Click += new System.EventHandler(this.btnCondensedInfo_Click);
            // 
            // btnRemoveCondensed
            // 
            this.btnRemoveCondensed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveCondensed.Location = new System.Drawing.Point(91, 541);
            this.btnRemoveCondensed.Name = "btnRemoveCondensed";
            this.btnRemoveCondensed.Size = new System.Drawing.Size(76, 28);
            this.btnRemoveCondensed.TabIndex = 3;
            this.btnRemoveCondensed.Text = "Ta &bort...";
            this.btnRemoveCondensed.UseVisualStyleBackColor = true;
            this.btnRemoveCondensed.Click += new System.EventHandler(this.btnRemoveCondensed_Click);
            // 
            // btnAddCondensed
            // 
            this.btnAddCondensed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCondensed.Location = new System.Drawing.Point(6, 542);
            this.btnAddCondensed.Name = "btnAddCondensed";
            this.btnAddCondensed.Size = new System.Drawing.Size(79, 28);
            this.btnAddCondensed.TabIndex = 3;
            this.btnAddCondensed.Text = "&Lägg till...";
            this.btnAddCondensed.UseVisualStyleBackColor = true;
            this.btnAddCondensed.Click += new System.EventHandler(this.btnAddCondensed_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblTopLevel);
            this.groupBox2.Controls.Add(this.codeTreeView);
            this.groupBox2.Location = new System.Drawing.Point(12, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(423, 582);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tematräd";
            // 
            // lblTopLevel
            // 
            this.lblTopLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTopLevel.AutoSize = true;
            this.lblTopLevel.Location = new System.Drawing.Point(6, 546);
            this.lblTopLevel.Name = "lblTopLevel";
            this.lblTopLevel.Size = new System.Drawing.Size(111, 17);
            this.lblTopLevel.TabIndex = 2;
            this.lblTopLevel.Text = "Toppnivå: Tema";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnCodeInfo);
            this.groupBox3.Controls.Add(this.btnRemoveCode);
            this.groupBox3.Controls.Add(this.btnAddCode);
            this.groupBox3.Controls.Add(this.codesListView);
            this.groupBox3.Location = new System.Drawing.Point(809, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 579);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Koder";
            // 
            // btnCodeInfo
            // 
            this.btnCodeInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCodeInfo.Location = new System.Drawing.Point(175, 542);
            this.btnCodeInfo.Name = "btnCodeInfo";
            this.btnCodeInfo.Size = new System.Drawing.Size(29, 28);
            this.btnCodeInfo.TabIndex = 2;
            this.btnCodeInfo.Text = "&I";
            this.btnCodeInfo.UseVisualStyleBackColor = true;
            this.btnCodeInfo.Click += new System.EventHandler(this.btnCodeInfo_Click);
            // 
            // btnRemoveCode
            // 
            this.btnRemoveCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveCode.Location = new System.Drawing.Point(94, 542);
            this.btnRemoveCode.Name = "btnRemoveCode";
            this.btnRemoveCode.Size = new System.Drawing.Size(75, 28);
            this.btnRemoveCode.TabIndex = 1;
            this.btnRemoveCode.Text = "Ta b&ort...";
            this.btnRemoveCode.UseVisualStyleBackColor = true;
            this.btnRemoveCode.Click += new System.EventHandler(this.btnRemoveCode_Click);
            // 
            // btnAddCode
            // 
            this.btnAddCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCode.Location = new System.Drawing.Point(6, 542);
            this.btnAddCode.Name = "btnAddCode";
            this.btnAddCode.Size = new System.Drawing.Size(82, 28);
            this.btnAddCode.TabIndex = 1;
            this.btnAddCode.Text = "L&ägg till...";
            this.btnAddCode.UseVisualStyleBackColor = true;
            this.btnAddCode.Click += new System.EventHandler(this.btnAddCode_Click);
            // 
            // codesListView
            // 
            this.codesListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codesListView.Location = new System.Drawing.Point(6, 22);
            this.codesListView.Name = "codesListView";
            this.codesListView.Size = new System.Drawing.Size(198, 514);
            this.codesListView.TabIndex = 0;
            this.codesListView.UseCompatibleStateImageBehavior = false;
            this.codesListView.DoubleClick += new System.EventHandler(this.CodesListView_DoubleClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btnCategoryInfo);
            this.groupBox4.Controls.Add(this.btnRemoveCategory);
            this.groupBox4.Controls.Add(this.btnAddCategory);
            this.groupBox4.Controls.Add(this.categoryListView);
            this.groupBox4.Location = new System.Drawing.Point(593, 32);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(210, 578);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kategorier";
            // 
            // btnCategoryInfo
            // 
            this.btnCategoryInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCategoryInfo.Location = new System.Drawing.Point(170, 542);
            this.btnCategoryInfo.Name = "btnCategoryInfo";
            this.btnCategoryInfo.Size = new System.Drawing.Size(34, 27);
            this.btnCategoryInfo.TabIndex = 2;
            this.btnCategoryInfo.Text = "&K";
            this.btnCategoryInfo.UseVisualStyleBackColor = true;
            this.btnCategoryInfo.Click += new System.EventHandler(this.btnCategoryInfo_Click);
            // 
            // btnRemoveCategory
            // 
            this.btnRemoveCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveCategory.Location = new System.Drawing.Point(89, 542);
            this.btnRemoveCategory.Name = "btnRemoveCategory";
            this.btnRemoveCategory.Size = new System.Drawing.Size(75, 28);
            this.btnRemoveCategory.TabIndex = 1;
            this.btnRemoveCategory.Text = "Ta bort&...";
            this.btnRemoveCategory.UseVisualStyleBackColor = true;
            this.btnRemoveCategory.Click += new System.EventHandler(this.btnRemoveCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCategory.Location = new System.Drawing.Point(6, 542);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(77, 28);
            this.btnAddCategory.TabIndex = 1;
            this.btnAddCategory.Text = "Lä&gg till...";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // categoryListView
            // 
            this.categoryListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryListView.Location = new System.Drawing.Point(6, 22);
            this.categoryListView.Name = "categoryListView";
            this.categoryListView.Size = new System.Drawing.Size(198, 513);
            this.categoryListView.TabIndex = 0;
            this.categoryListView.UseCompatibleStateImageBehavior = false;
            this.categoryListView.DoubleClick += new System.EventHandler(this.CategoryListView_DoubleClick);
            // 
            // btnExpand
            // 
            this.btnExpand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExpand.Location = new System.Drawing.Point(441, 91);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(107, 31);
            this.btnExpand.TabIndex = 7;
            this.btnExpand.Text = "E&xpandera";
            this.btnExpand.UseVisualStyleBackColor = true;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // btnCollapse
            // 
            this.btnCollapse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCollapse.Location = new System.Drawing.Point(441, 54);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(107, 31);
            this.btnCollapse.TabIndex = 7;
            this.btnCollapse.Text = "Kom&primera";
            this.btnCollapse.UseVisualStyleBackColor = true;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // lblThemes
            // 
            this.lblThemes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblThemes.AutoSize = true;
            this.lblThemes.Location = new System.Drawing.Point(442, 327);
            this.lblThemes.Name = "lblThemes";
            this.lblThemes.Size = new System.Drawing.Size(68, 17);
            this.lblThemes.TabIndex = 8;
            this.lblThemes.Text = "Teman: 0";
            // 
            // lblCategories
            // 
            this.lblCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(442, 344);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(90, 17);
            this.lblCategories.TabIndex = 9;
            this.lblCategories.Text = "Kategorier: 0";
            // 
            // lblCodes
            // 
            this.lblCodes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodes.AutoSize = true;
            this.lblCodes.Location = new System.Drawing.Point(442, 361);
            this.lblCodes.Name = "lblCodes";
            this.lblCodes.Size = new System.Drawing.Size(62, 17);
            this.lblCodes.TabIndex = 10;
            this.lblCodes.Text = "Koder: 0";
            // 
            // lblCmus
            // 
            this.lblCmus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCmus.AutoSize = true;
            this.lblCmus.Location = new System.Drawing.Point(442, 378);
            this.lblCmus.Name = "lblCmus";
            this.lblCmus.Size = new System.Drawing.Size(96, 17);
            this.lblCmus.TabIndex = 11;
            this.lblCmus.Text = "Condensed: 0";
            // 
            // btnExpandAll
            // 
            this.btnExpandAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExpandAll.Location = new System.Drawing.Point(460, 129);
            this.btnExpandAll.Name = "btnExpandAll";
            this.btnExpandAll.Size = new System.Drawing.Size(88, 23);
            this.btnExpandAll.TabIndex = 12;
            this.btnExpandAll.Text = "Allt";
            this.btnExpandAll.UseVisualStyleBackColor = true;
            this.btnExpandAll.Click += new System.EventHandler(this.btnExpandAll_Click);
            // 
            // btnThemes
            // 
            this.btnThemes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemes.Location = new System.Drawing.Point(460, 159);
            this.btnThemes.Name = "btnThemes";
            this.btnThemes.Size = new System.Drawing.Size(88, 23);
            this.btnThemes.TabIndex = 13;
            this.btnThemes.Text = "Teman";
            this.btnThemes.UseVisualStyleBackColor = true;
            this.btnThemes.Click += new System.EventHandler(this.btnThemes_Click);
            // 
            // btnExpandCategories
            // 
            this.btnExpandCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExpandCategories.Location = new System.Drawing.Point(460, 189);
            this.btnExpandCategories.Name = "btnExpandCategories";
            this.btnExpandCategories.Size = new System.Drawing.Size(88, 23);
            this.btnExpandCategories.TabIndex = 14;
            this.btnExpandCategories.Text = "Kategorier";
            this.btnExpandCategories.UseVisualStyleBackColor = true;
            this.btnExpandCategories.Click += new System.EventHandler(this.btnExpandCategories_Click);
            // 
            // btnExpandCodes
            // 
            this.btnExpandCodes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExpandCodes.Location = new System.Drawing.Point(460, 219);
            this.btnExpandCodes.Name = "btnExpandCodes";
            this.btnExpandCodes.Size = new System.Drawing.Size(88, 23);
            this.btnExpandCodes.TabIndex = 15;
            this.btnExpandCodes.Text = "Koder";
            this.btnExpandCodes.UseVisualStyleBackColor = true;
            this.btnExpandCodes.Click += new System.EventHandler(this.btnExpandCodes_Click);
            // 
            // lblFont
            // 
            this.lblFont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFont.AutoSize = true;
            this.lblFont.Location = new System.Drawing.Point(445, 549);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(60, 17);
            this.lblFont.TabIndex = 16;
            this.lblFont.Text = "Font: 12";
            // 
            // CodeTreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 613);
            this.Controls.Add(this.lblFont);
            this.Controls.Add(this.btnExpandCodes);
            this.Controls.Add(this.btnExpandCategories);
            this.Controls.Add(this.btnThemes);
            this.Controls.Add(this.btnExpandAll);
            this.Controls.Add(this.lblCmus);
            this.Controls.Add(this.lblCodes);
            this.Controls.Add(this.lblCategories);
            this.Controls.Add(this.lblThemes);
            this.Controls.Add(this.btnCollapse);
            this.Controls.Add(this.btnExpand);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CodeTreeForm";
            this.Text = "CodeTree";
            this.Load += new System.EventHandler(this.CodeTreeForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arkivToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nyttToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öppnaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sparaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem avslutaToolStripMenuItem;
        private System.Windows.Forms.TreeView codeTreeView;
        private System.Windows.Forms.ToolStripMenuItem trädToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem läggTillGruppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taBortGruppToolStripMenuItem;
        private System.Windows.Forms.ListView meaningListView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRemoveCondensed;
        private System.Windows.Forms.Button btnAddCondensed;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRemoveCode;
        private System.Windows.Forms.Button btnAddCode;
        private System.Windows.Forms.ListView codesListView;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnRemoveCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.ListView categoryListView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem uppdateraToolStripMenuItem;
        private System.Windows.Forms.Button btnExpand;
        private System.Windows.Forms.Button btnCollapse;
        private System.Windows.Forms.Button btnCondensedInfo;
        private System.Windows.Forms.Button btnCodeInfo;
        private System.Windows.Forms.Button btnCategoryInfo;
        private System.Windows.Forms.Label lblThemes;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.Label lblCodes;
        private System.Windows.Forms.Label lblCmus;
        private System.Windows.Forms.ToolStripMenuItem toolStripImport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Label lblTopLevel;
        private System.Windows.Forms.ToolStripMenuItem sparaSomToolStripMenuItem;
        private System.Windows.Forms.Button btnExpandAll;
        private System.Windows.Forms.Button btnThemes;
        private System.Windows.Forms.Button btnExpandCategories;
        private System.Windows.Forms.Button btnExpandCodes;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exporteraToolStripMenuItem;
        private System.Windows.Forms.Label lblFont;
    }
}

