namespace TextEditor
{
    public partial class MainForm : Form
    {        
        public MainForm()
        {
            InitializeComponent();
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewTab(string.Empty);
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                NewTab(openFileDialog.FileName);
            }
        }

        private void NewTab(string? fileName)
        {
            string name;
            string content;
            string path;

            if (!string.IsNullOrEmpty(fileName))
            {
                FileInfo file = new(fileName);

                if (file.Exists)
                {
                    name = file.Name;
                    path = file.FullName;

                    using StreamReader reader = new(file.OpenRead());
                    content = reader.ReadToEnd();
                }
                else throw new FileNotFoundException();
            }
            else
            {
                name = GetNewTabName();
                content = string.Empty;
                path = string.Empty;
            }

            EditorTab newTab = new(name, path, content);

            newTab.ContentModified += Tab_ContentModified;
            
            tcTabs.TabPages.Add(newTab);
            tcTabs.SelectTab(newTab);
            
            closeToolStripMenuItem.Enabled = true;
        }       

        private void Tab_ContentModified(object? sender, bool e)
        {
            saveToolStripMenuItem.Enabled = e;
            saveAsToolStripMenuItem.Enabled = e;
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save(saveAs: true);
        }

        private void Save(EditorTab? tab = null, bool saveAs = false)
        {
            EditorTab current = tab ?? (EditorTab)tcTabs.SelectedTab;
            FileInfo file;

            if (string.IsNullOrEmpty(current.Path) || saveAs)
            {
                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    file = new(saveFileDialog.FileName);
                }
                else return;

                if (!saveAs)
                {
                    tcTabs.SelectedTab.Text = file.Name;
                    current.Path = file.FullName;
                }
            }
            else file = new(current.Path);

            using StreamWriter writer = new(file.OpenWrite());
            writer.Write(current.Content);
            writer.Close();

            current.Saved();
        }

        private string GetNewTabName()
        {
            int inc = 1;
            foreach(EditorTab tab in tcTabs.TabPages)
            {
                if (tab.IsNewFile) inc++;
            }
            return $"New File {inc}";
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tcTabs.SelectedTab != null)
            {
                EditorTab current = (EditorTab)tcTabs.SelectedTab;
                CloseTab(current);
            }
        }

        private void CloseTab(EditorTab? tab = null)
        {
            EditorTab current = tab ?? (EditorTab)tcTabs.SelectedTab;

            if (current.Modified)
            {
                DialogResult saveBeforeClosing = MessageBox.Show
                (
                    $"Save file \"{current.Text}\" before closing?",
                    "Unsaved changes",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning
                );

                if (saveBeforeClosing == DialogResult.Cancel) return;
                else if (saveBeforeClosing == DialogResult.Yes) Save();
            }

            tcTabs.TabPages.Remove(current);

            if (tcTabs.TabPages.Count == 0) closeToolStripMenuItem.Enabled = false;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            List<EditorTab> unsavedTabs = new();

            foreach (EditorTab tab in tcTabs.TabPages)
            {
                if (tab.Modified) unsavedTabs.Add(tab);
            }

            if(unsavedTabs.Count > 0)
            {
                DialogResult saveBeforeClosing = MessageBox.Show
                (
                    $"The following tab(s) has unsaved changes, save before closing?\n{string.Join("\n", unsavedTabs)}",
                    "Unsaved changes",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning
                );

                if (saveBeforeClosing == DialogResult.Cancel) e.Cancel = true;
                else if (saveBeforeClosing == DialogResult.Yes)
                {
                    unsavedTabs.ForEach(t => Save(tab: t));
                }
            }
        }
       
        private void TcTabs_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                CloseTab();
            }                      
        }

        private void TcTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcTabs.SelectedIndex >= 0)
            {
                EditorTab current = (EditorTab)tcTabs.SelectedTab;

                saveToolStripMenuItem.Enabled = current.Modified;
                saveAsToolStripMenuItem.Enabled = current.Modified;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            NewTab(string.Empty);
        }

        private void DuplicateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditorTab current = (EditorTab)tcTabs.SelectedTab;
            NewTab(current.Path);
        }       

        private void tcTabs_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                for(int i = 0; i < tcTabs.TabPages.Count; i++)
                {
                    if (tcTabs.GetTabRect(i).Contains(e.Location))
                    {
                       // MessageBox.Show(tcTabs.TabPages[i].Text);

                        //tab.Focus();
                        //tcTabs.SelectTab(tab);
                        //break;
                    }
                }
            }
        }
    }
}
