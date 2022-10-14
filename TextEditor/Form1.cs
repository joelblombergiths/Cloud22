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


            TextBox textBox = new()
            {
                BorderStyle = BorderStyle.None,
                Dock = DockStyle.Fill,
                Multiline = true,
                Text = content
            };           

            EditorTab newTab = new(name, textBox, path);

            newTab.Controls.Add(textBox);

            tcTabs.TabPages.Add(newTab);
            tcTabs.SelectTab(newTab);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save(true);
        }

        private void Save(bool saveAs = false)
        {
            EditorTab current = (EditorTab)tcTabs.SelectedTab;
            FileInfo file;

            if (string.IsNullOrEmpty(current.Path) || saveAs)
            {
                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    file = new(saveFileDialog.FileName);
                }
                else return;

                if (!saveAs) tcTabs.SelectedTab.Text = file.Name;
            }
            else file = new(current.Path);

            using TextWriter writer = new StreamWriter(file.OpenWrite());
            writer.Write(current.Body.Text);
            writer.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tcTabs.SelectedTab != null) tcTabs.TabPages.Remove(tcTabs.SelectedTab);
        }
    }
}