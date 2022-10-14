namespace TextEditor
{
    internal class EditorTab : TabPage
    {
        public TextBox Body { get; private set; }
        public string? Path { get; set; } = string.Empty;

        public EditorTab(string name, TextBox textBox, string? path) : base(name)
        {
            Body = textBox;
            Path = path;
        }
    }
}
