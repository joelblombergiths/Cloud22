namespace TextEditor
{
    internal class EditorTab : TabPage
    {
        private readonly TextBox _body;
        public string Content 
        {
            get => _body.Text;
            set => _body.Text = value;
        }

        public bool Modified 
        {
            get => _body.Modified;
            set => _body.Modified = value;
        }

        private readonly ToolStripLabel _filePathLabel;
        private string? _path;
        public string? Path 
        {
            get => _path;
            set 
            {
                _path = value;
                _filePathLabel.Text = _path;
            }
        }

        private readonly ToolStripStatusLabel _lengthLabel;
        private readonly ToolStripStatusLabel _linesLabel;

        public event EventHandler<bool> ContentModified;

        public EditorTab(string name, string? path, string? content) : base(name)
        {
            StatusStrip statusStrip = new()
            {
                Dock = DockStyle.Bottom
            };
            Controls.Add(statusStrip);

            _body = new()
            {
                BorderStyle = BorderStyle.None,
                Dock = DockStyle.Fill,
                Multiline = true,
                Text = content
            };
            Controls.Add(_body);

            _filePathLabel = new ToolStripStatusLabel(path)
            {
                Alignment = ToolStripItemAlignment.Left,
                BorderSides = ToolStripStatusLabelBorderSides.Right,
                Padding = new Padding(0, 0, 5, 0)
            };
            statusStrip.Items.Add(_filePathLabel);

            ToolStripStatusLabel spacing = new(string.Empty)
            {
                Spring = true
            };
            statusStrip.Items.Add(spacing);

            _lengthLabel = new ToolStripStatusLabel($"length: {_body.TextLength}")
            {
                Alignment = ToolStripItemAlignment.Right,
                BorderSides = ToolStripStatusLabelBorderSides.Left
            };
            statusStrip.Items.Add(_lengthLabel);

            _linesLabel = new ToolStripStatusLabel($"lines: {_body.Lines.Length}")
            {
                Alignment = ToolStripItemAlignment.Right,
                BorderSides = ToolStripStatusLabelBorderSides.Right
            };
            statusStrip.Items.Add(_linesLabel);

            Path = path;

            _body.ModifiedChanged += _body_ModifiedChanged;
            _body.TextChanged += _body_TextChanged;
        }

        private void _body_TextChanged(object? sender, EventArgs e)
        {
            _lengthLabel.Text = $"length: {_body.TextLength}";
            _linesLabel.Text = $"lines: {_body.Lines.Length}";
        }

        private void _body_ModifiedChanged(object? sender, EventArgs e)
        {
            if (_body.Modified) Text += "*";
            else Text = Text.EndsWith("*") ? Text[..^1] : Text;

            ContentModified.Invoke(this, _body.Modified);
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
