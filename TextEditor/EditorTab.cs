namespace TextEditor
{
    internal class EditorTab : TabPage
    {
        private readonly Caret _caret;
        private readonly RichTextBox _body;

        public string Content
        {
            get => _body.Text;
            set => _body.Text = value;
        }
        
        public bool Modified => _body.Modified;        
        public bool IsNewFile { get; private set; }
        
        public void Saved()
        {
            _body.Modified = false;
            IsNewFile = false;
        }

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

        private readonly ToolStripStatusLabel _filePathLabel;
        private readonly ToolStripStatusLabel _lengthLabel;
        private readonly ToolStripStatusLabel _linesLabel;
        private readonly ToolStripStatusLabel _posLabel;

        public event EventHandler<bool>? ContentModified;

        public EditorTab(string name, string? path, string? content) : base(name)
        {
            BorderStyle = BorderStyle.Fixed3D;

            StatusStrip statusStrip = new()
            {
                Dock = DockStyle.Bottom
            };
            Controls.Add(statusStrip);

            _body = new()
            {
                Dock = DockStyle.Fill,
                Multiline = true,
                Text = content                
            };
            Controls.Add(_body);

            _caret = new(_body)
            {
                Style = Caret.CaretStyle.Block,
                Size = new Size(6, _body.Font.Height - 3)
            };

            _filePathLabel = new(path)
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

            _posLabel = new($"row: 1 col: 0")
            {
                Alignment = ToolStripItemAlignment.Right,
                BorderSides = ToolStripStatusLabelBorderSides.Left
            };
            statusStrip.Items.Add(_posLabel);

            _lengthLabel = new($"length: {_body.TextLength}")
            {
                Alignment = ToolStripItemAlignment.Right,
                BorderSides = ToolStripStatusLabelBorderSides.Left
            };
            statusStrip.Items.Add(_lengthLabel);

            _linesLabel = new($"lines: {_body.Lines.Length}")
            {
                Alignment = ToolStripItemAlignment.Right,
                BorderSides = ToolStripStatusLabelBorderSides.Right
            };
            statusStrip.Items.Add(_linesLabel);

            if (string.IsNullOrEmpty(path)) IsNewFile = true;
            else
            {
                IsNewFile = false;
                Path = path;
            }

            _body.ModifiedChanged += Body_ModifiedChanged;
            _body.TextChanged += Body_TextChanged;
            _body.KeyDown += Body_KeyDown;
            _body.Click += Body_Click;
        }

        private void UpdateCaretPos()
        {
            int lineCharIndex = _body.GetFirstCharIndexOfCurrentLine();
            int row = _body.GetLineFromCharIndex(lineCharIndex);
            int col = _body.GetCharIndexFromPosition(_caret.Location) - Math.Abs(lineCharIndex);

            _posLabel.Text = $"row: {row + 1} col: {col + 1}";
        }
        private void Body_Click(object? sender, EventArgs e)
        {
            UpdateCaretPos();
        }

        private void Body_KeyDown(object? sender, KeyEventArgs e)
        {
            UpdateCaretPos();
        }

        private void Body_TextChanged(object? sender, EventArgs e)
        {
            _lengthLabel.Text = $"length: {_body.TextLength}";
            _linesLabel.Text = $"lines: {_body.Lines.Length}";

            UpdateCaretPos();
        }

        private void Body_ModifiedChanged(object? sender, EventArgs e)
        {
            if (_body.Modified) Text += "*";
            else Text = Text.EndsWith("*") ? Text[..^1] : Text;

            ContentModified?.Invoke(this, _body.Modified);
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
