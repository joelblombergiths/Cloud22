#pragma warning disable CS8602 // Dereference of a possibly null reference.
namespace TextEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewTab(string.Empty);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
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

                    using TextReader reader = new StreamReader(file.OpenRead());
                    content = reader.ReadToEnd();
                }
                else throw new FileNotFoundException();
            }
            else
            {
                name = "New File";
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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save(saveAs: true);
        }

        private void Save(EditorTab? tab = null, bool saveAs = false)
        {
            EditorTab current = tab is null ? (EditorTab)tcTabs.SelectedTab : tab;
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

            using TextWriter writer = new StreamWriter(file.OpenWrite());
            writer.Write(current.Content);
            writer.Close();

            current.Modified = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tcTabs.SelectedTab != null)
            {
                EditorTab current = (EditorTab)tcTabs.SelectedTab;
                CloseTab(current);
            }
        }

        private void CloseTab(EditorTab? tab = null)
        {
            EditorTab current = tab is null ? (EditorTab)tcTabs.SelectedTab : tab;

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
       
        private void tcTabs_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle) CloseTab();
        }

        private void tcTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcTabs.SelectedIndex >= 0)
            {
                EditorTab current = (EditorTab)tcTabs.SelectedTab;

                saveToolStripMenuItem.Enabled = current.Modified;
                saveAsToolStripMenuItem.Enabled = current.Modified;
            }
        }
    }
}