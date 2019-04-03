using CodeTree.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace CodeTree
{
    public partial class CodeTreeForm : Form
    {
        private Project project;
        private string projectFileName;
        private bool projectChanged;

        private int currentFontSize;

        public CodeTreeForm()
        {
            InitializeComponent();

            InitializeViews();

            project = new Project();
            projectChanged = false;
            projectFileName = string.Empty;

            currentFontSize = 12;
        }

        private void InitializeViews()
        {
            meaningListView.View = View.Details;
            meaningListView.Sorting = SortOrder.Ascending;
            meaningListView.Columns.Add("Condensed Meaning Units", 150, HorizontalAlignment.Left);
            codesListView.View = View.Details;
            codesListView.Sorting = SortOrder.Ascending;
            codesListView.Columns.Add("Koder", 130, HorizontalAlignment.Left);
            categoryListView.View = View.Details;
            categoryListView.Sorting = SortOrder.Ascending;
            categoryListView.Columns.Add("Kategorier", 130, HorizontalAlignment.Left);
        }

        private void avslutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (projectChanged && !AskPermission("Det finns osparade ändringar - vill du verkligen avsluta?"))
                return;

            this.Close();
        }

        private void nyttToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (projectChanged && !AskPermission("Nytt projekt?"))
                return;

            ClearProject();
            UpdateTree();
        }

        private bool AskPermission(string v)
        {
            if (System.Windows.Forms.MessageBox.Show(v, "CodeTree", MessageBoxButtons.YesNo) == DialogResult.Yes)
                return true;

            return false;
        }

        private void addThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new ThemeForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var theme = new Theme()
                {
                    Name = frm.GetName()
                };

                project.Themes.Add(theme);
                codeTreeView.Nodes.Add(theme.Name, theme.Name);
                ProjectChanged();
            }
        }

        private void ProjectChanged()
        {
            if (projectChanged)
                return;

            projectChanged = true;
            UpdateHeadline();
        }

        private void btnAddCondensed_Click(object sender, EventArgs e)
        {
            var condensedMeaningUnit = new CondensedMeaningUnit();

            var frm = new CondensedMeaningUnitForm(condensedMeaningUnit, project.Codes);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                project.CondensedMeaningUnits.Add(condensedMeaningUnit);
                var displayText = $"[{condensedMeaningUnit.InterviewNumber}] {condensedMeaningUnit.Name}";
                meaningListView.Items.Add(condensedMeaningUnit.Name, displayText, condensedMeaningUnit.CondensedMeaningUnitId);

                var selectedCodeName = condensedMeaningUnit.CodeName;
                if (!string.IsNullOrEmpty(selectedCodeName))
                {
                    // Check if add to code list
                    var existingCode = project.Codes.Find(x => x.Name == selectedCodeName);
                    if (existingCode == null)
                    {
                        // New code
                        var newCode = new Code()
                        {
                            Name = selectedCodeName
                        };

                        project.Codes.Add(newCode);
                        codesListView.Items.Add(selectedCodeName, selectedCodeName, newCode.CodeId);
                    }
                }

                ProjectChanged();
                UpdateTree();
            }
        }

        private void meaningListView_DoubleClick(object sender, EventArgs e)
        {
            if (meaningListView.SelectedItems.Count != 1)
                return;

            var selectedCmuText = meaningListView.SelectedItems[0].Name;
            var selectedCmu = project.CondensedMeaningUnits.Find(x => x.Name == selectedCmuText);
            if (selectedCmu != null)
            {
                var frm = new CondensedMeaningUnitForm(selectedCmu, project.Codes);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    var displayText = $"[{selectedCmu.InterviewNumber}] {selectedCmu.Name}";
                    meaningListView.SelectedItems[0].Text = displayText;
                    meaningListView.SelectedItems[0].Name = selectedCmu.Name;

                    var selectedCodeName = selectedCmu.CodeName;
                    if (!string.IsNullOrEmpty(selectedCodeName))
                    {
                        // Check if add to code list
                        var existingCode = project.Codes.Find(x => x.Name == selectedCodeName);
                        if (existingCode == null)
                        {
                            // New code
                            var newCode = new Code()
                            {
                                Name = selectedCodeName
                            };

                            project.Codes.Add(newCode);
                            codesListView.Items.Add(selectedCodeName, selectedCodeName, newCode.CodeId);
                        }
                    }
                    ProjectChanged();
                    UpdateTree();
                }
            }
        }

        private void btnRemoveCondensed_Click(object sender, EventArgs e)
        {
            string name;

            if (meaningListView.SelectedItems.Count == 1)
            {
                name = meaningListView.SelectedItems[0].Name;
            }
            else
            {
                return;
            }

            if (System.Windows.Forms.MessageBox.Show($"Ta bort {name}?", "Ta bort", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                meaningListView.Items.RemoveByKey(name);
                var item = project.CondensedMeaningUnits.Find(x => x.Name == name);
                if (item != null)
                {
                    project.CondensedMeaningUnits.Remove(item);
                    ProjectChanged();
                    UpdateTree();
                }
            }
        }

        private void btnAddCode_Click(object sender, EventArgs e)
        {
            var code = new Code();

            var frm = new CodeForm(code, project.Categories, 0);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                project.Codes.Add(code);
                var displayText = $"{code.Name}";
                codesListView.Items.Add(code.Name, displayText, code.CodeId);

                var selectedCategory = code.CategoryName;
                if (!string.IsNullOrEmpty(selectedCategory))
                {
                    // Check if add to category list
                    var existingCategory = project.Categories.Find(x => x.Name == selectedCategory);
                    if (existingCategory == null)
                    {
                        // New category
                        var newCategory = new Category()
                        {
                            Name = selectedCategory
                        };

                        project.Categories.Add(newCategory);
                        categoryListView.Items.Add(selectedCategory, selectedCategory, newCategory.CategoryId);
                    }
                }

                ProjectChanged();
                UpdateTree();
            }
        }

        private void CodesListView_DoubleClick(object sender, System.EventArgs e)
        {
            if (codesListView.SelectedItems.Count != 1)
                return;

            var selectedCodeText = codesListView.SelectedItems[0].Name;
            var selectedCode = project.Codes.Find(x => x.Name == selectedCodeText);
            if (selectedCode != null)
            {
                int cmuCount = project.CondensedMeaningUnits.Count(x => x.CodeName == selectedCodeText);
                var frm = new CodeForm(selectedCode, project.Categories, cmuCount);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    var displayText = $"{selectedCode.Name}";
                    codesListView.SelectedItems[0].Text = displayText;
                    codesListView.SelectedItems[0].Name = selectedCode.Name;

                    if (selectedCode.Name != selectedCodeText)
                    {
                        // Code has been renamed => update condensed meaning units
                        foreach (var item in project.CondensedMeaningUnits)
                        {
                            if (item.CodeName == selectedCodeText)
                            {
                                item.CodeName = selectedCode.Name;
                            }
                        }
                    }

                    var selectedCategoryName = selectedCode.CategoryName;
                    if (!string.IsNullOrEmpty(selectedCategoryName))
                    {
                        // Check if add to category list
                        var existingCategory = project.Categories.Find(x => x.Name == selectedCategoryName);
                        if (existingCategory == null)
                        {
                            // New category
                            var newcategory = new Category()
                            {
                                Name = selectedCategoryName
                            };

                            project.Categories.Add(newcategory);
                            categoryListView.Items.Add(selectedCategoryName, selectedCategoryName, newcategory.CategoryId);
                        }
                    }

                    ProjectChanged();
                    UpdateTree();
                }
            }
        }

        private void btnRemoveCode_Click(object sender, EventArgs e)
        {
            string name;

            if (codesListView.SelectedItems.Count == 1)
            {
                name = codesListView.SelectedItems[0].Name;
            }
            else
            {
                return;
            }

            if (System.Windows.Forms.MessageBox.Show($"Ta bort {name}?", "Ta bort", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                codesListView.Items.RemoveByKey(name);
                var item = project.Codes.Find(x => x.Name == name);
                if (item != null)
                {
                    project.Codes.Remove(item);
                }
                ProjectChanged();
                UpdateTree();
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            var category = new Category();

            var frm = new CategoryForm(category, project.Themes);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                project.Categories.Add(category);
                var displayText = $"{category.Name}";
                categoryListView.Items.Add(category.Name, displayText, category.CategoryId);

                var selectedTheme = category.ThemeName;
                if (!string.IsNullOrEmpty(selectedTheme))
                {
                    // Check if add to theme list
                    var existingTheme = project.Themes.Find(x => x.Name == selectedTheme);
                    if (existingTheme == null)
                    {
                        // New theme
                        var newTheme = new Theme()
                        {
                            Name = selectedTheme
                        };

                        project.Themes.Add(newTheme);
                    }
                }

                ProjectChanged();
                UpdateTree();
            }
        }

        private void CategoryListView_DoubleClick(object sender, System.EventArgs e)
        {
            if (categoryListView.SelectedItems.Count != 1)
                return;

            var selectedCategoryText = categoryListView.SelectedItems[0].Name;
            var selectedCategory = project.Categories.Find(x => x.Name == selectedCategoryText);
            if (selectedCategory != null)
            {
                var frm = new CategoryForm(selectedCategory, project.Themes);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    var displayText = $"{selectedCategory.Name}";
                    categoryListView.SelectedItems[0].Text = displayText;
                    categoryListView.SelectedItems[0].Name = selectedCategory.Name;

                    if (selectedCategory.Name != selectedCategoryText)
                    {
                        foreach (var item in project.Codes)
                        {
                            if (item.CategoryName == selectedCategoryText)
                            {
                                item.CategoryName = selectedCategory.Name;
                            }
                        }
                    }

                    var selectedThemeName = selectedCategory.ThemeName;
                    if (!string.IsNullOrEmpty(selectedThemeName))
                    {
                        // Check if add to category list
                        var existingTheme = project.Themes.Find(x => x.Name == selectedThemeName);
                        if (existingTheme == null)
                        {
                            // New theme
                            var newTheme = new Theme()
                            {
                                Name = selectedThemeName
                            };

                            project.Themes.Add(newTheme);
                        }
                    }
                    ProjectChanged();
                    UpdateTree();
                }
            }
        }

        private void UpdateTree()
        {
            codeTreeView.BeginUpdate();

            codeTreeView.Nodes.Clear();

            var currentFont = codeTreeView.Font;
            var newFont = new Font(currentFont.Name, currentFontSize);

            if (project.Themes.Any())
            {
                lblTopLevel.Text = "Toppnivå: Tema";
                foreach (var theme in project.Themes)
                {
                    var newNode = new TreeNode(theme.Name);
                    newNode.NodeFont = newFont;

                    foreach (var cat in project.Categories.Where(x => x.ThemeName == theme.Name))
                    {
                        var catNode = new TreeNode(cat.Name);
                        catNode.NodeFont = newFont;
                        foreach (var code in project.Codes.Where(x => x.CategoryName == cat.Name))
                        {
                            var codeNode = new TreeNode(code.Name);
                            codeNode.NodeFont = newFont;
                            foreach (var cmu in project.CondensedMeaningUnits.Where(x => x.CodeName == code.Name))
                            {
                                var cmuNode = new TreeNode($"[{cmu.InterviewNumber}] {cmu.Name}");
                                cmuNode.NodeFont = newFont;
                                foreach (var mu in cmu.MeaningUnits)
                                {
                                    var muNode = new TreeNode(mu.Name);
                                    muNode.NodeFont = newFont;
                                    cmuNode.Nodes.Add(muNode);
                                }
                                codeNode.Nodes.Add(cmuNode);
                            }
                            catNode.Nodes.Add(codeNode);
                        }
                        newNode.Nodes.Add(catNode);
                    }

                    codeTreeView.Nodes.Add(newNode);
                }
                // And then those without theme
                var unNode = new TreeNode("(saknar tema)");
                unNode.NodeFont = newFont;

                foreach (var cat in project.Categories.Where(x => string.IsNullOrEmpty(x.ThemeName)))
                {
                    var catNode = new TreeNode(cat.Name);
                    catNode.NodeFont = newFont;
                    foreach (var code in project.Codes.Where(x => x.CategoryName == cat.Name))
                    {
                        var codeNode = new TreeNode(code.Name);
                        codeNode.NodeFont = newFont;
                        foreach (var cmu in project.CondensedMeaningUnits.Where(x => x.CodeName == code.Name))
                        {
                            var cmuNode = new TreeNode($"[{cmu.InterviewNumber}] {cmu.Name}");
                            cmuNode.NodeFont = newFont;
                            foreach (var mu in cmu.MeaningUnits)
                            {
                                var muNode = new TreeNode(mu.Name);
                                muNode.NodeFont = newFont;
                                cmuNode.Nodes.Add(muNode);
                            }
                            codeNode.Nodes.Add(cmuNode);
                        }
                        catNode.Nodes.Add(codeNode);
                    }
                    unNode.Nodes.Add(catNode);
                }

                // Plus codes without categories
                var unCatNode = new TreeNode("(koder utan kategori)");
                unCatNode.NodeFont = newFont;

                foreach (var code in project.Codes.Where(x => string.IsNullOrEmpty(x.CategoryName)))
                {
                    var codeNode = new TreeNode(code.Name);
                    codeNode.NodeFont = newFont;
                    foreach (var cmu in project.CondensedMeaningUnits.Where(x => x.CodeName == code.Name))
                    {
                        var cmuNode = new TreeNode($"[{cmu.InterviewNumber}] {cmu.Name}");
                        cmuNode.NodeFont = newFont;
                        foreach (var mu in cmu.MeaningUnits)
                        {
                            var muNode = new TreeNode(mu.Name);
                            muNode.NodeFont = newFont;
                            cmuNode.Nodes.Add(muNode);
                        }
                        codeNode.Nodes.Add(cmuNode);
                    }
                    unCatNode.Nodes.Add(codeNode);
                }

                unNode.Nodes.Add(unCatNode);
                codeTreeView.Nodes.Add(unNode);
            }
            else if (project.Categories.Any())
            {
                lblTopLevel.Text = "Toppnivå: Kategori";
                foreach (var cat in project.Categories)
                {
                    var catNode = new TreeNode(cat.Name);
                    catNode.NodeFont = newFont;
                    foreach (var code in project.Codes.Where(x => x.CategoryName == cat.Name))
                    {
                        var codeNode = new TreeNode(code.Name);
                        codeNode.NodeFont = newFont;
                        foreach (var cmu in project.CondensedMeaningUnits.Where(x => x.CodeName == code.Name))
                        {
                            var cmuNode = new TreeNode($"[{cmu.InterviewNumber}] {cmu.Name}");
                            cmuNode.NodeFont = newFont;
                            foreach (var mu in cmu.MeaningUnits)
                            {
                                var muNode = new TreeNode(mu.Name);
                                muNode.NodeFont = newFont;
                                cmuNode.Nodes.Add(muNode);
                            }
                            codeNode.Nodes.Add(cmuNode);
                        }
                        catNode.Nodes.Add(codeNode);
                    }
                    codeTreeView.Nodes.Add(catNode);
                }
                // And then those without category
                var unNode = new TreeNode("(saknar kategori)");
                unNode.NodeFont = newFont;
                foreach (var code in project.Codes.Where(x => string.IsNullOrEmpty(x.CategoryName)))
                {
                    var codeNode = new TreeNode(code.Name);
                    codeNode.NodeFont = newFont;
                    foreach (var cmu in project.CondensedMeaningUnits.Where(x => x.CodeName == code.Name))
                    {
                        var cmuNode = new TreeNode($"[{cmu.InterviewNumber}] {cmu.Name}");
                        cmuNode.NodeFont = newFont;
                        foreach (var mu in cmu.MeaningUnits)
                        {
                            var muNode = new TreeNode(mu.Name);
                            muNode.NodeFont = newFont;
                            cmuNode.Nodes.Add(muNode);
                        }
                        codeNode.Nodes.Add(cmuNode);
                    }
                    unNode.Nodes.Add(codeNode);
                }
                codeTreeView.Nodes.Add(unNode);
            }
            else if (project.Codes.Any())
            {
                lblTopLevel.Text = "Toppnivå: Kod";
                foreach (var code in project.Codes)
                {
                    var codeNode = new TreeNode(code.Name);
                    codeNode.NodeFont = newFont;
                    foreach (var cmu in project.CondensedMeaningUnits.Where(x => x.CodeName == code.Name))
                    {
                        var cmuNode = new TreeNode($"[{cmu.InterviewNumber}] {cmu.Name}");
                        cmuNode.NodeFont = newFont;
                        foreach (var mu in cmu.MeaningUnits)
                        {
                            var muNode = new TreeNode(mu.Name);
                            muNode.NodeFont = newFont;
                            cmuNode.Nodes.Add(muNode);
                        }
                        codeNode.Nodes.Add(cmuNode);
                    }
                    codeTreeView.Nodes.Add(codeNode);
                }
                var unNode = new TreeNode("(saknar kategori)");
                unNode.NodeFont = newFont;
                foreach (var cmu in project.CondensedMeaningUnits.Where(x => string.IsNullOrEmpty(x.CodeName)))
                {
                    var cmuNode = new TreeNode($"[{cmu.InterviewNumber}] {cmu.Name}");
                    cmuNode.NodeFont = newFont;
                    foreach (var mu in cmu.MeaningUnits)
                    {
                        var muNode = new TreeNode(mu.Name);
                        muNode.NodeFont = newFont;
                        cmuNode.Nodes.Add(muNode);
                    }
                    unNode.Nodes.Add(cmuNode);
                }
                codeTreeView.Nodes.Add(unNode);
            }
            else if (project.CondensedMeaningUnits.Any())
            {
                lblTopLevel.Text = "Toppnivå: Condensed Meaning Unit";
                foreach (var cmu in project.CondensedMeaningUnits)
                {
                    var cmuNode = new TreeNode($"[{cmu.InterviewNumber}] {cmu.Name}");
                    cmuNode.NodeFont = newFont;
                    foreach (var mu in cmu.MeaningUnits)
                    {
                        var muNode = new TreeNode(mu.Name);
                        muNode.NodeFont = newFont;
                        cmuNode.Nodes.Add(muNode);
                    }
                    codeTreeView.Nodes.Add(cmuNode);
                }
            }

            lblThemes.Text = $"Teman: {project.Themes.Count}";
            lblCategories.Text = $"Kategorier: {project.Categories.Count}";
            lblCodes.Text = $"Koder: {project.Codes.Count}";
            lblCmus.Text = $"Condensed: {project.CondensedMeaningUnits.Count}";

            codeTreeView.EndUpdate();

            UpdateHeadline();
        }

        private void UpdateHeadline()
        {
            var headline = "CodeTree";
            if (!string.IsNullOrEmpty(projectFileName))
                headline += $" - {projectFileName}";
            if (projectChanged)
                headline += "*";

            this.Text = headline;
        }

        private void btnRemoveCategory_Click(object sender, EventArgs e)
        {
            string name;

            if (categoryListView.SelectedItems.Count == 1)
            {
                name = categoryListView.SelectedItems[0].Name;
            }
            else
            {
                return;
            }

            if (System.Windows.Forms.MessageBox.Show($"Ta bort {name}?", "Ta bort", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                categoryListView.Items.RemoveByKey(name);
                var item = project.Categories.Find(x => x.Name == name);
                if (item != null)
                {
                    project.Categories.Remove(item);
                    ProjectChanged();
                    UpdateTree();
                }
            }
        }

        private void taBortGruppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name;

            if (codeTreeView.SelectedNode != null)
            {
                name = codeTreeView.SelectedNode.Name;
            }
            else
            {
                return;
            }

            if (System.Windows.Forms.MessageBox.Show($"Ta bort {name}?", "Ta bort", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                codeTreeView.Nodes.RemoveByKey(name);
                var item = project.Themes.Find(x => x.Name == name);
                if (item != null)
                {
                    project.Themes.Remove(item);
                    ProjectChanged();
                    UpdateTree();
                }
            }
        }

        private void uppdateraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateTree();
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            btnExpandCodes_Click(sender, e);
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            codeTreeView.BeginUpdate();
            codeTreeView.CollapseAll();
            codeTreeView.EndUpdate();
        }

        private void btnCategoryInfo_Click(object sender, EventArgs e)
        {
            CategoryListView_DoubleClick(sender, e);
        }

        private void btnCodeInfo_Click(object sender, EventArgs e)
        {
            CodesListView_DoubleClick(sender, e);
        }

        private void btnCondensedInfo_Click(object sender, EventArgs e)
        {
            meaningListView_DoubleClick(sender, e);
        }

        private void sparaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(projectFileName))
            {
                sparaSomToolStripMenuItem_Click(sender, e);
                return;
            }

            SaveProject(projectFileName);
        }

        private void ClearProject()
        {
            project = new Project();
            projectFileName = string.Empty;
            projectChanged = false;

            meaningListView.Clear();
            codesListView.Clear();
            categoryListView.Clear();

            InitializeViews();
        }

        private void öppnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.DefaultExt = "xml";
            dlg.ValidateNames = true;
            dlg.Filter = "XML file (.xml)|*.xml|All files (*.*)|*.*";

            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            ClearProject();

            XmlSerializer xsReceive = new XmlSerializer(typeof(Project));
            var xml = File.ReadAllText(dlg.FileName);

            using (var sr = new StringReader(xml))
            {
                using (XmlReader reader = XmlReader.Create(sr))
                {
                    project = (Project) xsReceive.Deserialize(reader);
                }
            }

            projectChanged = false;
            projectFileName = dlg.FileName;

            UpdateTree();

            foreach (var condensedMeaningUnit in project.CondensedMeaningUnits)
            {
                var displayText = $"[{condensedMeaningUnit.InterviewNumber}] {condensedMeaningUnit.Name}";
                meaningListView.Items.Add(condensedMeaningUnit.Name, displayText, condensedMeaningUnit.CondensedMeaningUnitId);
            }

            foreach (var code in project.Codes)
            {
                codesListView.Items.Add(code.Name, code.Name, code.CodeId);
            }

            foreach (var cat in project.Categories)
            {
                categoryListView.Items.Add(cat.Name, cat.Name, cat.CategoryId);
            }
        }

        private void sparaSomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new SaveFileDialog();
            frm.DefaultExt = "xml";
            frm.ValidateNames = true;
            frm.Filter = "XML file (.xml)|*.xml|All files (*.*)|*.*";
            if (frm.ShowDialog() != DialogResult.OK)
                return;

            SaveProject(frm.FileName);
        }

        private void SaveProject(string fileName)
        {
            XmlSerializer xsSubmit = new XmlSerializer(typeof(Project));
            var xml = "";

            using (var sww = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sww))
                {
                    xsSubmit.Serialize(writer, project);
                    xml = sww.ToString();
                }
            }

            File.WriteAllText(fileName, xml);
            projectFileName = fileName;
            projectChanged = false;
            UpdateHeadline();
        }

        private void btnExpandAll_Click(object sender, EventArgs e)
        {
            codeTreeView.BeginUpdate();
            codeTreeView.ExpandAll();
            codeTreeView.EndUpdate();
        }

        private void btnThemes_Click(object sender, EventArgs e)
        {
            codeTreeView.BeginUpdate();
            codeTreeView.CollapseAll();

            foreach (var node in codeTreeView.Nodes)
            {
                ((TreeNode)node).Expand();
            }
            codeTreeView.EndUpdate();
        }

        private void btnExpandCategories_Click(object sender, EventArgs e)
        {
            codeTreeView.BeginUpdate();
            codeTreeView.CollapseAll();

            foreach (var node in codeTreeView.Nodes)
            {
                var themeNode = node as TreeNode;
                themeNode.Expand();

                foreach (var item in themeNode.Nodes)
                {
                    ((TreeNode)item).Expand();
                }
            }
            codeTreeView.EndUpdate();
        }

        private void btnExpandCodes_Click(object sender, EventArgs e)
        {
            codeTreeView.BeginUpdate();
            codeTreeView.CollapseAll();

            foreach (var theme in codeTreeView.Nodes)
            {
                var themeNode = theme as TreeNode;
                themeNode.Expand();

                foreach (var cat in themeNode.Nodes)
                {
                    var catNode = cat as TreeNode;
                    catNode.Expand();

                    foreach (var code in catNode.Nodes)
                    {
                        var codeNode = code as TreeNode;
                        codeNode.Expand();
                    }
                }
            }
            codeTreeView.EndUpdate();
        }

        private void toolStripImport_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.DefaultExt = "txt";
            dlg.ValidateNames = true;
            dlg.Filter = "OpenCode file (.txt)|*.txt|All files (*.*)|*.*";

            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            if (!File.Exists(dlg.FileName))
            {
                System.Windows.Forms.MessageBox.Show("Filen finns inte.", "Importera", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int interviewNumber = 0;
            var name = Path.GetFileNameWithoutExtension(dlg.FileName);
            var len = name.Length;
            if (Char.IsDigit(name[len-2]) && Char.IsDigit(name[len-2]) &&
                Char.IsDigit(name[len-1]) && Char.IsDigit(name[len-1]))
            {
                // two last numeric
                interviewNumber = int.Parse(name.Substring(len - 2));
            }
            else if (Char.IsDigit(name[len - 1]) && Char.IsDigit(name[len - 1]))
            {
                interviewNumber = int.Parse(name.Substring(len - 1));
            }

            ImportOpenCodeFile(dlg.FileName, interviewNumber);
        }

        private void ImportOpenCodeFile(string fileName, int interviewNumber)
        {
            var textLines = File.ReadAllLines(fileName, Encoding.GetEncoding(1252));
            if (textLines.Count() > 0)
            {
                // Add an extra line to update the last package
                var tmpList = textLines.ToList();
                tmpList.Add("99999\t\t\t\t\t");
                textLines = tmpList.ToArray();
            }

            var lastLineNumber = 0;
            var currentMeaningUnits = new List<string>();
            var condensedMeaningUnits = new List<CondensedMeaningUnit>();

            foreach (var textLine in textLines)
            {
                var textParts = textLine.Split('\t');
                if (textParts.Length < 4)
                    continue;

                int lineNumber = int.Parse(textParts[0]);
                var meaningUnit = textParts[1];
                var condensed = textParts[2];
                var code = textParts[3];

                if (lineNumber > lastLineNumber + 1)
                {
                    // New paragraph - add meaning units to newly added condensed ones, and restart
                    foreach (var cmu in condensedMeaningUnits)
                    {
                        foreach (var mu in currentMeaningUnits)
                        {
                            cmu.MeaningUnits.Add(new MeaningUnit()
                            {
                                Name = mu
                            });
                        }
                    }

                    currentMeaningUnits = new List<string>();
                    condensedMeaningUnits = new List<CondensedMeaningUnit>();

                    lastLineNumber = lineNumber - 1;
                }

                if (lineNumber == lastLineNumber + 1)
                {
                    if (!string.IsNullOrEmpty(code))
                    {
                        AddCode(code);
                    }
                    if (!string.IsNullOrEmpty(condensed))
                    {
                        var newCondensed = AddCondensedMeaningUnit(interviewNumber, condensed, code);
                        if (newCondensed != null)
                            condensedMeaningUnits.Add(newCondensed);
                    }
                    if (!string.IsNullOrEmpty(meaningUnit))
                    {
                        currentMeaningUnits.Add(meaningUnit);
                    }
                }

                lastLineNumber = lineNumber;
            }

            UpdateTree();
        }

        private CondensedMeaningUnit AddCondensedMeaningUnit(int interviewNumber, string condensed, string code)
        {
            var iNrString = interviewNumber.ToString();
            if (project.CondensedMeaningUnits.Any(cmu => cmu.Name == condensed && cmu.InterviewNumber == iNrString))
                return null;

            var newCondensed = new CondensedMeaningUnit()
            {
                InterviewNumber = iNrString,
                Name = condensed,
                CodeName = code,
                MeaningUnits = new List<MeaningUnit>()
            };

            project.CondensedMeaningUnits.Add(newCondensed);
            var displayText = $"[{newCondensed.InterviewNumber}] {newCondensed.Name}";
            meaningListView.Items.Add(newCondensed.Name, displayText, newCondensed.CondensedMeaningUnitId);

            return newCondensed;
        }

        private void AddCode(string code)
        {
            if (project.Codes.Any(c => c.Name == code))
                return;

            var newCode = new Code() { Name = code };
            project.Codes.Add(newCode);
            codesListView.Items.Add(code, code, newCode.CodeId);
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (codeTreeView.Nodes.Count == 0)
                return;

            ChangeTreeViewFont(1);
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (codeTreeView.Nodes.Count == 0)
                return;

            ChangeTreeViewFont(-1);
        }

        private void ChangeTreeViewFont(int change)
        {
            codeTreeView.BeginUpdate();

            var currentFont = codeTreeView.Nodes[0].NodeFont;
            if (currentFont == null)
            {
                currentFont = codeTreeView.Font;
            }

            currentFontSize += change;
            lblFont.Text = $"Font: {currentFontSize}";

            var newFont = new Font(currentFont.Name, currentFontSize);

            foreach (TreeNode node in codeTreeView.Nodes)
            {
                node.NodeFont = newFont;
                node.Text = node.Text;

                foreach (TreeNode subNode in node.Nodes)
                {
                    subNode.NodeFont = newFont;
                    subNode.Text = subNode.Text;

                    foreach (TreeNode subsubNode in subNode.Nodes)
                    {
                        subsubNode.NodeFont = newFont;
                        subsubNode.Text = subsubNode.Text;

                        foreach (TreeNode subsubsubNode in subsubNode.Nodes)
                        {
                            subsubsubNode.NodeFont = newFont;
                            subsubsubNode.Text = subsubsubNode.Text;
                        }
                    }
                }
            }

            Rectangle myRectangle = codeTreeView.Nodes[0].Bounds;
            int myNodeHeight = myRectangle.Height;
            codeTreeView.ItemHeight = myNodeHeight + 3 * change;

            codeTreeView.EndUpdate();
        }

        private void exporteraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new SaveFileDialog();
            frm.DefaultExt = "txt";
            frm.ValidateNames = true;
            frm.Filter = "TXT file (.txt)|*.txt|All files (*.*)|*.*";
            if (frm.ShowDialog() != DialogResult.OK)
                return;

            var sb = new StringBuilder();

            foreach (TreeNode node in codeTreeView.Nodes)
            {
                sb.AppendLine($"+---{node.Text}");

                foreach (TreeNode subNode in node.Nodes)
                {
                    sb.AppendLine($"|   +---{subNode.Text}");

                    foreach (TreeNode subsubNode in subNode.Nodes)
                    {
                        sb.AppendLine($"|   |   +---{subsubNode.Text}");

                        foreach (TreeNode subsubsubNode in subsubNode.Nodes)
                        {
                            sb.AppendLine($"|   |   |   +---{subsubsubNode.Text}");
                        }
                    }
                }
            }

            var outputStrings = sb.ToString();
            File.WriteAllText(frm.FileName, outputStrings);
        }

        private void CodeTreeForm_Load(object sender, EventArgs e)
        {
            var currentFont = codeTreeView.Font;
            var newFont = new Font(currentFont.Name, currentFontSize);
            int myNodeHeight = newFont.Height;
            codeTreeView.ItemHeight = myNodeHeight + 4;
        }
    }
}
